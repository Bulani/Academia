using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using AcessoBancoDados.Properties;

using ObjetoTransferencia;

namespace AcessoBancoDados
{
    public class FuncionarioDAL
    {

        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(Settings.Default.stringConexaoMysql);
        }

        //Insere Dados no Banco de Dados
        public string AdicionarFuncionario(Funcionario funcionario)
        {
            string retorno = "";

            string sql = "INSERT INTO funcionarios(Nome,Sexo,Nascimento,CPF,RG,Cidade,Logradouro,Numero,Bairro,UF,CEP,Admissao,Demissao,Telefone,Celular,Funcao,Salario,Situacao)values(@Nome,@Sexo,@Nascimento,@CPF,@RG,@Cidade,@Logradouro,@Numero,@Bairro,@UF,@CEP,@Admissao,@Demissao,@Telefone,@Celular,@Funcao,@Salario,@Situacao)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nome", funcionario.NomeP);
            cmd.Parameters.AddWithValue("@Sexo", funcionario.SexoP);
            cmd.Parameters.AddWithValue("@Nascimento", funcionario.NascimentoP);
            cmd.Parameters.AddWithValue("@CPF", funcionario.CPFP);
            cmd.Parameters.AddWithValue("@RG", funcionario.RGP);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.CidadeP);
            cmd.Parameters.AddWithValue("@Logradouro", funcionario.LogradouroP);
            cmd.Parameters.AddWithValue("@Numero", funcionario.NumeroP);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.BairroP);
            cmd.Parameters.AddWithValue("@UF", funcionario.UFP);
            cmd.Parameters.AddWithValue("@CEP", funcionario.CEPP);
            cmd.Parameters.AddWithValue("@Admissao", funcionario.AdmissaoP);
            cmd.Parameters.AddWithValue("@Demissao", funcionario.DemissaoP);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.TelefoneP);
            cmd.Parameters.AddWithValue("@Celular", funcionario.CelularP);
            cmd.Parameters.AddWithValue("@Funcao", funcionario.FuncaoP);
            cmd.Parameters.AddWithValue("@Salario", funcionario.SalarioP);
            cmd.Parameters.AddWithValue("@Situacao", funcionario.SituacaoP);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Cadastrar Funcionário: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        //Pesquisa no banco de dados
        public List<Funcionario> CarregarFuncionarios(string parametro = "")
        {

            List<Funcionario> funcionarios = new List<Funcionario>();

            string sql = "";

            if (parametro != "")
            {

                sql = "SELECT * FROM funcionarios WHERE Nome LIKE @parametro";
            }

            else
            {
                sql = "SELECT * FROM funcionarios";
            }
            

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            if (parametro != "")
            {

                cmd.Parameters.AddWithValue("@parametro", "%" + parametro + "%");
            }


            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.IdFuncionarioP = int.Parse(dr["IdFuncionario"].ToString());
                    funcionario.NomeP = dr["Nome"].ToString();
                    funcionario.SexoP = dr["Sexo"].ToString();
                    funcionario.NascimentoP = DateTime.Parse(dr["Nascimento"].ToString());
                    funcionario.CPFP = dr["CPF"].ToString();
                    funcionario.RGP = dr["RG"].ToString(); ;
                    funcionario.CidadeP = dr["Cidade"].ToString();
                    funcionario.LogradouroP = dr["Logradouro"].ToString();
                    funcionario.NumeroP = dr["Numero"].ToString();
                    funcionario.BairroP = dr["Bairro"].ToString();
                    funcionario.UFP = dr["UF"].ToString();
                    funcionario.CEPP = dr["CEP"].ToString();
                    funcionario.AdmissaoP = DateTime.Parse(dr["Admissao"].ToString());
                    funcionario.DemissaoP = DateTime.Parse(dr["Demissao"].ToString());
                    funcionario.TelefoneP = dr["Telefone"].ToString();
                    funcionario.CelularP = dr["Celular"].ToString();
                    funcionario.FuncaoP = dr["Funcao"].ToString();
                    funcionario.SalarioP = Double.Parse(dr["Salario"].ToString());
                    funcionario.SituacaoP = int.Parse(dr["Situacao"].ToString());

                    funcionarios.Add(funcionario);

                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar Grid:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return funcionarios;
        }

        //Altera Dados no Banco de Dados
        public string AlterarFuncionario(Funcionario funcionario)
        {
            string retorno = "";

            string sql = "UPDATE funcionarios SET Nome=@Nome,Sexo=@Sexo,Nascimento=@Nascimento,CPF=@CPF,RG=@RG,Cidade=@Cidade,Logradouro=@Logradouro,Numero=@Numero,Bairro=@Bairro,UF=@UF,CEP=@CEP,Admissao=@Admissao,Demissao=@Demissao,Telefone=@Telefone,Celular=@Celular,Funcao=@Funcao,Salario=@Salario,Situacao=@Situacao WHERE IdFuncionario=@IdFuncionario";


            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionarioP);
            cmd.Parameters.AddWithValue("@Nome", funcionario.NomeP);
            cmd.Parameters.AddWithValue("@Sexo", funcionario.SexoP);
            cmd.Parameters.AddWithValue("@Nascimento", funcionario.NascimentoP);
            cmd.Parameters.AddWithValue("@CPF", funcionario.CPFP);
            cmd.Parameters.AddWithValue("@RG", funcionario.RGP);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.CidadeP);
            cmd.Parameters.AddWithValue("@Logradouro", funcionario.LogradouroP);
            cmd.Parameters.AddWithValue("@Numero", funcionario.NumeroP);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.BairroP);
            cmd.Parameters.AddWithValue("@UF", funcionario.UFP);
            cmd.Parameters.AddWithValue("@CEP", funcionario.CEPP);
            cmd.Parameters.AddWithValue("@Admissao", funcionario.AdmissaoP);
            cmd.Parameters.AddWithValue("@Demissao", funcionario.DemissaoP);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.TelefoneP);
            cmd.Parameters.AddWithValue("@Celular", funcionario.CelularP);
            cmd.Parameters.AddWithValue("@Funcao", funcionario.FuncaoP);
            cmd.Parameters.AddWithValue("@Salario", funcionario.SalarioP);
            cmd.Parameters.AddWithValue("@Situacao", funcionario.SituacaoP);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            { retorno = "Erro ao Alterar Funcionário: " + ex.Message; }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        //Excluir dados no Banco de Dados
        public string ExcluirFuncionario(int idFuncionarioP)
        {

            string retorno = "";

            string sql = "DELETE FROM funcionarios WHERE IdFuncionario=" + idFuncionarioP;

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionarioP);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (MySqlException ex)
            { retorno = "Erro ao Excluir Funcionário: " + ex.Message; }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return retorno;

        }
    }
}
