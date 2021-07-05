using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


    public class FuncionarioDAL
    {

        //Criar a conexão
        private MySqlConnection CriarConexao()
        {  
            return new MySqlConnection( ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }

        //Insere Dados no Banco de Dados
        public string AdicionarFuncionario(Funcionario funcionario)
        {
            string retorno = "";

            string sql = "INSERT INTO funcionarios(Nome,Sexo,Nascimento,CPF,RG,Cidade,Logradouro,Numero,Bairro,UF,CEP,Admissao,Demissao,Telefone,Celular,Funcao,Salario,Situacao)values(@Nome,@Sexo,@Nascimento,@CPF,@RG,@Cidade,@Logradouro,@Numero,@Bairro,@UF,@CEP,@Admissao,@Demissao,@Telefone,@Celular,@Funcao,@Salario,@Situacao)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@Sexo", funcionario.Sexo);
            cmd.Parameters.AddWithValue("@Nascimento", funcionario.Nascimento);
            cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            cmd.Parameters.AddWithValue("@RG", funcionario.RG);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@Logradouro", funcionario.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", funcionario.Numero);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
            cmd.Parameters.AddWithValue("@UF", funcionario.UF);
            cmd.Parameters.AddWithValue("@CEP", funcionario.CEP);
            cmd.Parameters.AddWithValue("@Admissao", funcionario.Admissao);
            cmd.Parameters.AddWithValue("@Demissao", funcionario.Demissao);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@Celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@Funcao", funcionario.Funcao);
            cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
            cmd.Parameters.AddWithValue("@Situacao", funcionario.Situacao);

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
                    funcionario.IdFuncionario    = dr.GetInt32("IdFuncionario");
                    funcionario.Nome             = dr.GetString("Nome");
                    funcionario.Sexo             = dr.GetString("Sexo");
                    funcionario.Nascimento       = dr.GetDateTime("Nascimento");
                    funcionario.CPF              = dr.GetString("CPF");
                    funcionario.RG               = dr.GetString("RG"); ;
                    funcionario.Cidade           = dr.GetString("Cidade");
                    funcionario.Logradouro       = dr.GetString("Logradouro");
                    funcionario.Numero           = dr.GetString("Numero");
                    funcionario.Bairro           = dr.GetString("Bairro");
                    funcionario.UF               = dr.GetString("UF");
                    funcionario.CEP              = dr.GetString("CEP");
                    funcionario.Admissao         = dr.GetDateTime("Admissao");
                    funcionario.Demissao         = dr.GetDateTime("Demissao");
                    funcionario.Telefone         = dr.GetString("Telefone");
                    funcionario.Celular          = dr.GetString("Celular");
                    funcionario.Funcao           = dr.GetString("Funcao");
                    funcionario.Salario          = dr.GetDouble("Salario");
                    funcionario.Situacao         = dr.GetInt32("Situacao");

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

            cmd.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);
            cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@Sexo", funcionario.Sexo);
            cmd.Parameters.AddWithValue("@Nascimento", funcionario.Nascimento);
            cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            cmd.Parameters.AddWithValue("@RG", funcionario.RG);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@Logradouro", funcionario.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", funcionario.Numero);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
            cmd.Parameters.AddWithValue("@UF", funcionario.UF);
            cmd.Parameters.AddWithValue("@CEP", funcionario.CEP);
            cmd.Parameters.AddWithValue("@Admissao", funcionario.Admissao);
            cmd.Parameters.AddWithValue("@Demissao", funcionario.Demissao);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@Celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@Funcao", funcionario.Funcao);
            cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
            cmd.Parameters.AddWithValue("@Situacao", funcionario.Situacao);

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
