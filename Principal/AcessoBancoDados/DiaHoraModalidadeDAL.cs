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
    public class DiaHoraModalidadeDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(Settings.Default.stringConexaoMysql);
        }
        public List<DiaHoraModalidade> DiasHorasModalidade(int IdModalidade)
        {
            List<DiaHoraModalidade> lista = new List<DiaHoraModalidade>();
            lista = null;

            string sql = "select * from dia_hora_modalidade where idmodalidade=@idmodalidade";                   


            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

          
            cmd.Parameters.AddWithValue("@idmodalidade", IdModalidade); 
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DiaHoraModalidade dhm = new DiaHoraModalidade();
                    dhm.IdDiaHoraP = int.Parse(dr["idDiaHoraM"].ToString());
                    dhm.DiaP        = int.Parse(dr["dia"].ToString());
                    dhm.HoraInicioP = DateTime.Parse(dr["Hora_inicio"].ToString());
                    dhm.HoraFimP = DateTime.Parse(dr["Hora_FIm"].ToString());
                    dhm.IDModalidadeP = int.Parse(dr["idModalidade"].ToString());
                    lista.Add(dhm);

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

            return lista;

        }
    }
}
