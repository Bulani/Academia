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
    public class Contas_receber_movcaixaDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public string InserirContas_receber_movCaixa(Contas_Receber_Movcaixa crm, MySqlTransaction trans, MySqlConnection conn)
        {
            string resp = "";


            string sql = "INSERT INTO contas_receber_movcaixa(id_contas_receber,id_mov_caixa) " +
                " values(@id_contas_receber,@id_mov_caixa)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id_contas_receber", crm.Id_contas_receber);
            cmd.Parameters.AddWithValue("@id_mov_caixa", crm.Id_mov_caixa);

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
                resp = ex.Message;
            }

            finally
            {
                //if (conn.State == ConnectionState.Open) conn.Close();
            }


            return resp;
        }
    }
}
