using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Principal.AppCode.ClassesModelo;

namespace Principal.AppCode.DAL
{
    class CategoriaTreinoDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public string AdicionarGrupoTreino(CategoriaTreino grupoTreino)
        {
            string retorno = "";

            string sql = "insert into grupos_treinos(nome) values(@nome)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
                        
            cmd.Parameters.AddWithValue("@nome", grupoTreino.Nome);            

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Cadastrar Grupode treino: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public List<CategoriaTreino> ListarGruposDeTreino(string nome = "")
        {
            List<CategoriaTreino> lista = new List<CategoriaTreino>();

            string sql = "select * from grupos_treinos";

            if (nome != "")
            {
                sql = sql + " where nome like @nome";
            }

            sql = sql + " order by nome";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            if (nome != "")
            {
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            }

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CategoriaTreino gt = new CategoriaTreino();
                    gt.Id = dr.GetInt32("idgrupostreinos");
                    gt.Nome = dr.GetString("Nome");  
                    
                    lista.Add(gt);
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar Lista:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return lista;
        }

        public string AlterarGrupoTreino(CategoriaTreino grupoTreino)
        {
            string retorno = "";

            string sql = "update grupos_treinos set nome=@nome where idgrupostreinos=@idgrupostreinos";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idgrupostreinos", grupoTreino.Id);
            cmd.Parameters.AddWithValue("@nome", grupoTreino.Nome);
           

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Alterar Grupo de treino: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public string ExcluirGrupoTreino(int idGrupotreino)
        {
            string retorno = "";

            string sql = "delete from grupos_treinos where idgrupostreinos=@idgrupostreinos";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idgrupostreinos", idGrupotreino);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Remover Grupo Treino: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

    }
}
