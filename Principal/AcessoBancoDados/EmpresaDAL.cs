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
    public class EmpresaDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(Settings.Default.stringConexaoMysql);
        }

        //Insere Dados no Banco de Dados
        public string AdicionarEmpresa(Empresa empresa)
        {
            string retorno = "";

            string sql = "INSERT INTO empresa(NomeFantasia,Razao,CNPJ,IE,Fundacao,Logradouro,Bairro,Cidade,UF,Numero,CEP,Telefone,Celular,Email,Responsavel)values(@NomeFantasia,@Razao,@CNPJ,@IE,@Fundacao,@Logradouro,@Bairro,@Cidade,@UF,@Numero,@CEP,@Telefone,@Celular,@Email,@Responsavel)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasiaP);
            cmd.Parameters.AddWithValue("@Razao", empresa.RazaoP);
            cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJP);
            cmd.Parameters.AddWithValue("@IE", empresa.IEP);
            cmd.Parameters.AddWithValue("@Fundacao", empresa.FundacaoP);
            cmd.Parameters.AddWithValue("@Logradouro", empresa.LogradouroP);
            cmd.Parameters.AddWithValue("@Bairro", empresa.BairroP);
            cmd.Parameters.AddWithValue("@Cidade", empresa.CidadeP);
            cmd.Parameters.AddWithValue("@UF", empresa.UFP);
            cmd.Parameters.AddWithValue("@Numero", empresa.NumeroP);
            cmd.Parameters.AddWithValue("@CEP", empresa.CEPP);
            cmd.Parameters.AddWithValue("@Telefone", empresa.TelefoneP);
            cmd.Parameters.AddWithValue("@Celular", empresa.CelularP);
            cmd.Parameters.AddWithValue("@Email", empresa.EmailP);
            cmd.Parameters.AddWithValue("@Responsavel", empresa.ResponsavelP);

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
                    empresa.IdEmpresaP = int.Parse(dr["IdEmpresa"].ToString());
                    empresa.NomeFantasiaP = dr["NomeFantasia"].ToString();
                    empresa.RazaoP = dr["Razao"].ToString();
                    empresa.CNPJP = dr["CNPJ"].ToString();
                    empresa.IEP = dr["IE"].ToString();
                    empresa.FundacaoP = DateTime.Parse(dr["Fundacao"].ToString());
                    empresa.LogradouroP = dr["Logradouro"].ToString();
                    empresa.BairroP = dr["Bairro"].ToString();
                    empresa.CidadeP = dr["Cidade"].ToString();
                    empresa.UFP = dr["UF"].ToString();
                    empresa.NumeroP = dr["Numero"].ToString();
                    empresa.CEPP = dr["CEP"].ToString();
                    empresa.TelefoneP = dr["Telefone"].ToString();
                    empresa.CelularP = dr["Celular"].ToString();
                    empresa.EmailP = dr["Email"].ToString();
                    empresa.ResponsavelP = dr["Responsavel"].ToString();

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

            cmd.Parameters.AddWithValue("@IdEmpresa", empresa.IdEmpresaP);
            cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasiaP);
            cmd.Parameters.AddWithValue("@Razao", empresa.RazaoP);
            cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJP);
            cmd.Parameters.AddWithValue("@IE", empresa.IEP);
            cmd.Parameters.AddWithValue("@Fundacao", empresa.FundacaoP);
            cmd.Parameters.AddWithValue("@Logradouro", empresa.LogradouroP);
            cmd.Parameters.AddWithValue("@Bairro", empresa.BairroP);
            cmd.Parameters.AddWithValue("@Cidade", empresa.CidadeP);
            cmd.Parameters.AddWithValue("@UF", empresa.UFP);
            cmd.Parameters.AddWithValue("@Numero", empresa.NumeroP);
            cmd.Parameters.AddWithValue("@CEP", empresa.CEPP);
            cmd.Parameters.AddWithValue("@Telefone", empresa.TelefoneP);
            cmd.Parameters.AddWithValue("@Celular", empresa.CelularP);
            cmd.Parameters.AddWithValue("@Email", empresa.EmailP);
            cmd.Parameters.AddWithValue("@Responsavel", empresa.ResponsavelP);

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
}
