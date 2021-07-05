using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

using Principal.AppCode.ClassesModelo;


namespace Principal.AppCode.DAL
{
    public class ContratoDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        private string AdicionarAlunosContrato(int idContrato, List<Aluno> alunos, MySqlTransaction trans, MySqlConnection conn)
        {
            // nao deve comittar ou rollback
            // quem vai fazer isso eh a função que chama

            string retorno = "";            

            string sql = "insert into contrato_alunos(idContrato,idAluno) " +
                " values(@idContrato,@idAluno)";
           
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.Transaction = trans;
                foreach (Aluno aluno in alunos)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idContrato", idContrato);
                    cmd.Parameters.AddWithValue("@idAluno", aluno.IdAluno);
                    cmd.ExecuteNonQuery();
                }               
                retorno = "";
            }
            catch (Exception ex)
            {                
                retorno = "Erro ao Cadastrar : " + ex.Message;
            }

            finally {  }
            return retorno;
        }
        private string AdicionarAlunosContrato(int idContrato, List<Aluno> alunos)
        {
            string retorno = "";
            MySqlTransaction trans = null;

            string sql = "insert into contrato_alunos(idContrato,idAluno) " +
                " values(@idContrato,@idAluno)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);


            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                foreach (Aluno aluno in alunos)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idContrato", idContrato);
                    cmd.Parameters.AddWithValue("@idAluno", aluno.IdAluno);
                    cmd.ExecuteNonQuery();
                }
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
        private int SelecionarProximoid()
        {
            int maxID=0;
            string sql = "SHOW table status LIKE 'contratos' ";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {                    
                    maxID = dr.GetInt32("Auto_increment");
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao ultimoID:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return maxID;
        }

        public string AdicionarContrato(Contrato contrato)
        {
            string retorno = "";
            int idContrato;
            MySqlTransaction trans = null;


            string sql = "INSERT INTO contratos(data_emissao,ativo,idAluno_responsavel,desconto,acrescimo,subtotal,dia_vencimento,total) "+
                " values(@data_emissao,@ativo,@idAluno_responsavel,@desconto,@acrescimo,@subtotal,@dia_vencimento,@total)";
                        
            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            idContrato = SelecionarProximoid();
            
            cmd.Parameters.AddWithValue("@data_emissao", contrato.DataEmissao);
            cmd.Parameters.AddWithValue("@ativo", contrato.Ativo);
            cmd.Parameters.AddWithValue("@idAluno_responsavel", contrato.IdAlunoResponsavel);
            cmd.Parameters.AddWithValue("@desconto", contrato.Desconto);
            cmd.Parameters.AddWithValue("@acrescimo", contrato.Acrescimo);
            cmd.Parameters.AddWithValue("@subtotal", contrato.Subtotal);
            cmd.Parameters.AddWithValue("@dia_vencimento", contrato.DiaVencimento);
            cmd.Parameters.AddWithValue("@total", contrato.Total); 

            try
            {

                // abre a conexao e inicia a transaction
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                // executa o comando
                cmd.ExecuteNonQuery();
               
                retorno = AdicionarAlunosContrato(idContrato, contrato.AlunosContrato,trans,conn);
                // se ao adicionar alunos retornou erro entao para
                if (retorno != "")
                {
                    throw new Exception(retorno);
                }
                Conta_Receber cr;
                Contas_receberDAL crDAL = new Contas_receberDAL(); 

                // insere a taxa de isncrição
                if (contrato.PlanoContratado.Taxa_inscricao > 0)
                {
                    cr     = new Conta_Receber(idContrato, contrato.PlanoContratado.Taxa_inscricao, DateTime.Now);                    

                    retorno = crDAL.Adicionar_Conta_receber(cr, conn, trans);
                    if (retorno != "")
                    {
                        throw new Exception(retorno);
                    }
                }
                // insere a primeira mensalidade
                // posso colcoar um parametro aqui
                cr  = new Conta_Receber(idContrato, contrato.PlanoContratado.Valor,contrato.PrimeiroVencimento );//DateTime.Now.AddDays(contrato.PlanoContratado.Freq_pagamento) usar como exmeplo                
                retorno = crDAL.Adicionar_Conta_receber(cr, conn, trans);
                if (retorno != "")
                {
                    throw new Exception(retorno);
                }


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

        private string AlterarContrato(Contrato contrato)
        {
            string resp = "";
            // implementar

            return resp;
        }
        private string RemoverContrato(int IDcontrato)
        {
            string resp = "";
            // implementar

            return resp;
        }
    }
}
