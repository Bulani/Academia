using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;



    public class DiaHoraModalidadeDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public List<DiaHoraModalidade> DiasHorasModalidade(int IdModalidade)
        {
            List<DiaHoraModalidade> lista = new List<DiaHoraModalidade>();           

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
                        dhm.IdDiaHora     = dr.GetInt32("idDiaHoraM");
                        dhm.Dia           = dr.GetInt32("dia");
                        dhm.HoraInicio    = dr.GetDateTime("Hora_inicio");
                        dhm.HoraFim       = dr.GetDateTime("Hora_FIm");
                        dhm.IDModalidade  = dr.GetInt32("idModalidade");

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
