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
    public class Mov_CaixaDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public string InserirMovimentacaoCaixa(Mov_Caixa mc)
        {
            string resp = "";

            MySqlTransaction trans = null;


            string sql = "INSERT INTO mov_caixa(data,numero_caixa,valor,tipo_pgto,id_plano_de_conta) " +
                " values(@data,@numero_caixa,@valor,@tipo_pgto,@id_plano_de_conta)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@data", mc.Data);
            cmd.Parameters.AddWithValue("@numero_caixa", mc.Numero_caixa);
            cmd.Parameters.AddWithValue("@valor", mc.Valor);
            cmd.Parameters.AddWithValue("@tipo_pgto", mc.Tipo_pgto);
            cmd.Parameters.AddWithValue("@id_plano_de_conta", mc.Id_plano_de_conta);
           

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

        public string InserirMovimentacaoCaixa(Mov_Caixa mc, MySqlTransaction trans, MySqlConnection conn)
        {
            string resp = "";

            string sql = "INSERT INTO mov_caixa(data,numero_caixa,valor,tipo_pgto,id_plano_de_conta) " +
                " values(@data,@numero_caixa,@valor,@tipo_pgto,@id_plano_de_conta)";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@data", mc.Data);
            cmd.Parameters.AddWithValue("@numero_caixa", mc.Numero_caixa);
            cmd.Parameters.AddWithValue("@valor", mc.Valor);
            cmd.Parameters.AddWithValue("@tipo_pgto", mc.Tipo_pgto);
            cmd.Parameters.AddWithValue("@id_plano_de_conta", mc.Id_plano_de_conta);


            try
            {
                // atribui a transaction
                cmd.Transaction = trans;

                // executa o comando
                cmd.ExecuteNonQuery();               
                resp = "";
            }
            catch (Exception ex)
            {                
                resp = "Erro ao Cadastrar : " + ex.Message;
            }

            finally {
                //if (conn.State == ConnectionState.Open) conn.Close();
            }

            return resp;
        }
        
        public int SelecionarProximoid()
        {
            int maxID = 0;
            string sql = "SHOW table status LIKE 'mov_caixa' ";

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
    }
}
