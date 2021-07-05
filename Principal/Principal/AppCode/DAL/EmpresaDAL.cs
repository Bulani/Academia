using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


    public class EmpresaDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }

        //Insere Dados no Banco de Dados
        public string AdicionarEmpresa(Empresa empresa)
        {
            string retorno = "";

            string sql = "INSERT INTO empresa(NomeFantasia,Razao,CNPJ,IE,Fundacao,Logradouro,Bairro,Cidade,UF,Numero,CEP,Telefone,Celular,Email,Responsavel)values(@NomeFantasia,@Razao,@CNPJ,@IE,@Fundacao,@Logradouro,@Bairro,@Cidade,@UF,@Numero,@CEP,@Telefone,@Celular,@Email,@Responsavel)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasia);
            cmd.Parameters.AddWithValue("@Razao", empresa.Razao);
            cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJ);
            cmd.Parameters.AddWithValue("@IE", empresa.IE);
            cmd.Parameters.AddWithValue("@Fundacao", empresa.Fundacao);
            cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro);
            cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade);
            cmd.Parameters.AddWithValue("@UF", empresa.UF);
            cmd.Parameters.AddWithValue("@Numero", empresa.Numero);
            cmd.Parameters.AddWithValue("@CEP", empresa.CEP);
            cmd.Parameters.AddWithValue("@Telefone", empresa.Telefone);
            cmd.Parameters.AddWithValue("@Celular", empresa.Celular);
            cmd.Parameters.AddWithValue("@Email", empresa.Email);
            cmd.Parameters.AddWithValue("@Responsavel", empresa.Responsavel);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (MySqlException ex)
            {
                retorno = "Erro ao Cadastrar Empresa: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        //Pesquisa no banco de dados
        public Empresa CarregarEmpresa()
        {
            Empresa empresa = null;
            string sql = "SELECT * FROM empresa ";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);            

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    empresa = new Empresa();
                    empresa.IdEmpresa       = dr.GetInt32("IdEmpresa");
                    empresa.NomeFantasia    = dr.GetString("NomeFantasia");
                    empresa.Razao           = dr.GetString("Razao");
                    empresa.CNPJ            = dr.GetString("CNPJ");
                    empresa.IE              = dr.GetString("IE");
                    empresa.Fundacao        = dr.GetDateTime("Fundacao");
                    empresa.Logradouro      = dr.GetString("Logradouro");
                    empresa.Bairro          = dr.GetString("Bairro");
                    empresa.Cidade          = dr.GetString("Cidade");
                    empresa.UF              = dr.GetString("UF");
                    empresa.Numero          = dr.GetString("Numero");
                    empresa.CEP             = dr.GetString("CEP");
                    empresa.Telefone        = dr.GetString("Telefone");
                    empresa.Celular         = dr.GetString("Celular");
                    empresa.Email           = dr.GetString("Email");
                    empresa.Responsavel     = dr.GetString("Responsavel");

                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar Empresa:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return empresa;
        }

        //Altera Dados no Banco de Dados
        public string AlterarEmpresa(Empresa empresa)
        {
            string retorno = "";

            string sql = "UPDATE empresa SET NomeFantasia=@NomeFantasia,Razao=@Razao,CNPJ=@CNPJ,IE=@IE,Fundacao=@Fundacao,Logradouro=@Logradouro,Bairro=@Bairro,Cidade=@Cidade,UF=@UF,Numero=@Numero,CEP=@CEP,Telefone=@Telefone,Celular=@Celular,Email=@Email,Responsavel=@Responsavel WHERE IdEmpresa=@IdEmpresa";


            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@IdEmpresa", empresa.IdEmpresa);
            cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasia);
            cmd.Parameters.AddWithValue("@Razao", empresa.Razao);
            cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJ);
            cmd.Parameters.AddWithValue("@IE", empresa.IE);
            cmd.Parameters.AddWithValue("@Fundacao", empresa.Fundacao);
            cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro);
            cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade);
            cmd.Parameters.AddWithValue("@UF", empresa.UF);
            cmd.Parameters.AddWithValue("@Numero", empresa.Numero);
            cmd.Parameters.AddWithValue("@CEP", empresa.CEP);
            cmd.Parameters.AddWithValue("@Telefone", empresa.Telefone);
            cmd.Parameters.AddWithValue("@Celular", empresa.Celular);
            cmd.Parameters.AddWithValue("@Email", empresa.Email);
            cmd.Parameters.AddWithValue("@Responsavel", empresa.Responsavel);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (MySqlException ex)
            { retorno = "Erro ao Alterar Empresa: " + ex.Message; }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

    }
