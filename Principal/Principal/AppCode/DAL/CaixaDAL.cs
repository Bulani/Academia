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
    public class CaixaDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }

        public bool ExisteCaixaAberto()
        {
            bool resp = false;

            string sql = "select * from caixas order by id desc limit 1 ";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    resp = (dr.IsDBNull(2));
                }

                conn.Close();

            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar Info:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return resp;
        }

        public int NumeroAbertoCaixaAtual()
        {
            int resp = 0;

            string sql = "select * from caixas where data_fechamento is null order by id desc limit 1 ";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    resp = dr.GetInt32("id");
                }

                conn.Close();

            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar Info:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return resp;
        }

        public string AbreNovoCaixa()
        {
            string retorno = "";

            if (ExisteCaixaAberto())
            {
                retorno = "Já existe um caixa aberto";
            }
            else
            {
                string sql = "insert into caixas(data_abertura) values(@data_abertura)";

                MySqlConnection conn = CriarConexao();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@data_abertura", DateTime.Now);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    retorno = "";
                }
                catch (Exception ex)
                { retorno = "Erro ao Abrir o Caixa: " + ex.Message; }
                finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            }
            return retorno;
        }
                
        public string FechaCaixaAtual()
        {
            int CaixaAtual = NumeroAbertoCaixaAtual();

            string retorno = "";

            if(CaixaAtual>0)
            {
                string sql = "update caixas set data_fechamento=@dataFec where id=@id";

                MySqlConnection conn = CriarConexao();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@dataFec", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", CaixaAtual);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    retorno = "";
                }
                catch (Exception ex)
                { retorno = "Erro ao Abrir o Caixa: " + ex.Message; }
                finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            }
            else
            {
                retorno = "Não existe caixa aberto";
            }
            
            return retorno;
        }

        public string ReabrirUltimoCaixa()
        {
            string resp = "";

            if (ExisteCaixaAberto())
            {
                resp = "Já Existe um caixa aberto";
            }
            else
            {
                string sql = "update caixas set data_fechamento=null order by id desc limit 1";

                MySqlConnection conn = CriarConexao();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    resp = "";
                }
                catch (Exception ex)
                { resp = "Erro ao Reabrir o Caixa: " + ex.Message; }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }

            return resp;
        }

        public List<Caixa> SelecionarCaixas()
        {
            List<Caixa> caixas = new List<Caixa>();

            string sql = "select * from caixas order by id ";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Caixa cx = new Caixa();
                    cx.IdCaixa = dr.GetInt32("id");
                    cx.Data_abertura = dr.GetDateTime("Data_abertura");
                    if(!dr.IsDBNull(2))
                    {
                        cx.Data_fechamento= dr.GetDateTime("Data_Fechamento");
                    }
                    caixas.Add(cx);
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar lista:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return caixas;
        }

    }
}
