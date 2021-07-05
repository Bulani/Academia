using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

using Principal.AppCode.ClassesModelo;
using Principal.AppCode.DAL;

namespace Principal.AppCode.DAL
{
    public class Contas_receberDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }

        public string Adicionar_Conta_receber(Conta_Receber conta)
        {
            string retorno = "";
            MySqlTransaction trans = null;

            string sql = "INSERT INTO contas_receber(idContrato,valor,data_emissao,data_vencimento,valor_juros,pendente,idAluno,valor_desconto) " +
                " values(@idContrato,@valor,@data_emissao,@data_vencimento,@valor_juros,@pendente,@idAluno,@valor_desconto)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idContrato", conta.IdContrato);
            cmd.Parameters.AddWithValue("@valor", conta.Valor);
            cmd.Parameters.AddWithValue("@data_emissao", conta.Data_emissao);
            cmd.Parameters.AddWithValue("@data_vencimento", conta.Data_vencimento);
            cmd.Parameters.AddWithValue("@valor_juros", conta.Valor_juros);
            cmd.Parameters.AddWithValue("@pendente", conta.Pendente);
            cmd.Parameters.AddWithValue("@idAluno", conta.Idaluno);
            cmd.Parameters.AddWithValue("@valor_desconto", conta.ValorDesconto);

            try
            {
                // abre a conexao e inicia a transaction
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                // executa o comando
                cmd.ExecuteNonQuery();              

                trans.Commit();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                retorno = "Erro ao Cadastrar : " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public string Adicionar_Conta_receber(Conta_Receber conta, MySqlConnection conn, MySqlTransaction trans)
        {
            // vai executar tudo sem salvar nada 
            // quem vai salvar é a função que chama aqui
            string retorno = "";           

            string sql = "INSERT INTO contas_receber(idContrato,valor,data_emissao,data_vencimento,valor_juros,pendente,idAluno) " +
                " values(@idContrato,@valor,@data_emissao,@data_vencimento,@valor_juros,@pendente,@idAluno)";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idContrato", conta.IdContrato);
            cmd.Parameters.AddWithValue("@valor", conta.Valor);
            cmd.Parameters.AddWithValue("@data_emissao", conta.Data_emissao);
            cmd.Parameters.AddWithValue("@data_vencimento", conta.Data_vencimento);
            cmd.Parameters.AddWithValue("@valor_juros", conta.Valor_juros);
            cmd.Parameters.AddWithValue("@pendente", conta.Pendente);
            cmd.Parameters.AddWithValue("@idAluno", conta.Idaluno);

            try
            {  
                cmd.Transaction = trans;
                // executa o comando
                cmd.ExecuteNonQuery();                               
                retorno = "";
            }
            catch (Exception ex)
            {                
                retorno = "Erro ao Cadastrar : " + ex.Message;
            }

            finally { }
            return retorno;
        }
        public string AtualizaContasReceber(List<int> ids_contas_receber, MySqlConnection conn, MySqlTransaction trans)
        {
            string resp = "";

            string sql = "update contas_Receber set pendente=0 where  " +
                "(idcontas_receber=@idcontas_receber) and " +
                " (((valor+valor_juros) - valor_desconto) <= " +

                "(coalesce((select sum(mc.valor) " +
                " from mov_caixa mc,contas_receber_movcaixa crm " +
                " where @idcontas_receber=crm.id_contas_receber " +
                "and crm.id_mov_caixa=mc.idmov_caixa),0))) ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Transaction = trans;                  

            try
            {
                // executa o comando
                foreach(int idReceber in ids_contas_receber)
                {                    
                    cmd.Parameters.AddWithValue("@idcontas_receber", idReceber);
                    cmd.ExecuteNonQuery();
                }
                resp = "";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally { }

            return resp;
        }

        public string ReceberPagamento(List<int> idsConta_receber, float valor, int forma_pgto, int id_plano_de_conta=0)
        {
            string resp = "";

            CaixaDAL cDAL = new CaixaDAL();

            if (!cDAL.ExisteCaixaAberto())
            {
                return "Não existe caixa aberto, abra um caixa antes de continuar...";
            }


            Mov_Caixa mc = new Mov_Caixa();
            Mov_CaixaDAL mcDAL = new Mov_CaixaDAL();            

            // preciso pegar isso pq o commit só sera dado se der tudo certo
            int idMovCaixa = mcDAL.SelecionarProximoid();

            mc.Data = DateTime.Now;
            mc.Id_plano_de_conta = id_plano_de_conta;
            mc.Numero_caixa = cDAL.NumeroAbertoCaixaAtual();
            mc.Tipo_pgto = forma_pgto;
            mc.Valor = valor;

            MySqlTransaction trans = null;           
            MySqlConnection conn = CriarConexao();           

            try
            {
                // abro a conexao
                conn.Open();
                // inicio a transaction
                trans = conn.BeginTransaction();
                // tento inserir a movimentação
                resp = mcDAL.InserirMovimentacaoCaixa( mc,trans,conn);
                // se der erro gero uma excecao pra forçar o tratamento
                if (resp != "")
                {
                    throw new System.ArgumentException(resp, "Ops...");
                }
                // relaciona com o contas a receber utilizando o objeto contas_receber_movcaixaDAL
                Contas_receber_movcaixaDAL crmDAL = new Contas_receber_movcaixaDAL();

                foreach(int idReceber in idsConta_receber)
                { 
                    Contas_Receber_Movcaixa crm = new Contas_Receber_Movcaixa();
                    crm.Id_contas_receber = idReceber;
                    crm.Id_mov_caixa = idMovCaixa;

                    // tenta inserir o registro
                    resp = crmDAL.InserirContas_receber_movCaixa(crm, trans, conn);
                    if (resp != "")
                    {
                        throw new System.ArgumentException(resp, "Ops...");
                    }
                }

                // agora só preciso verificar se ja pagou tudo
                resp = AtualizaContasReceber(idsConta_receber, conn,trans);
                if (resp != "")
                {
                    throw new System.ArgumentException(resp, "Ops...");
                }

                trans.Commit();
                conn.Close();
                resp = "";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                resp = "Erro ao Cadastrar : " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }

            return resp;
        }

        public List<Conta_Receber> PesquisarPendenciasAluno(int idAluno)
        {
            List<Conta_Receber> listaPendencias = new List<Conta_Receber>();

            string sql = "select cr.*,"

                +"coalesce((select sum(mc.valor) "+
                " from mov_caixa mc,contas_receber_movcaixa crm "+
                " where cr.idcontas_receber=crm.id_contas_receber "+
                "and crm.id_mov_caixa=mc.idmov_caixa),0)total_recebido " +

                "from contas_receber cr,contratos c, contrato_alunos ca " +
                "where(cr.idaluno = @idaluno and cr.pendente = 1) " +
                "or(ca.idaluno = @idaluno and ca.idcontrato = c.idcontrato and cr.idcontrato = c.idcontrato and cr.pendente = 1) ";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
         
           cmd.Parameters.AddWithValue("@idaluno", idAluno);

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Conta_Receber cr = new Conta_Receber();

                    cr.Idcontas_receber = dr.GetInt32("idcontas_receber");
                    cr.IdContrato = dr.GetInt32("idcontrato");
                    cr.Valor = dr.GetFloat("valor");
                    cr.Data_emissao = dr.GetDateTime("data_emissao");
                    cr.Data_vencimento = dr.GetDateTime("data_vencimento");
                    cr.Valor_juros = dr.GetFloat("valor_juros");
                    cr.Pendente = dr.GetBoolean("pendente");
                    cr.Idaluno = dr.GetInt32("idaluno");
                    cr.ValorPago = dr.GetFloat("total_recebido");
                    cr.ValorDesconto = dr.GetFloat("valor_desconto");
                    cr.Restante =( (dr.GetFloat("valor")+ cr.Valor_juros)-
                    dr.GetFloat("total_recebido"))- dr.GetFloat("valor_desconto");

                    listaPendencias.Add(cr);

                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar :" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }            

            return listaPendencias;
        }
    }
}
