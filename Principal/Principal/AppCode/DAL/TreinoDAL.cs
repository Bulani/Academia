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
    class TreinoDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public List<Treino> ListarTreinos(string nome = "")
        {
            List<Treino> lista = new List<Treino>();

            string sql = "select tre.*,gt.nome NomeCategoria from treinos tre, grupos_treinos gt where tre.idTreino >0";
            
            if (nome != "")
            {
                sql = sql + " and tre.nome like @nome";
            }
            sql = sql + " and tre.idGrupoTreino = gt.idGruposTreinos";

            sql = sql + " order by tre.nome";

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
                    Treino treino = new Treino();

                    treino.Id                = dr.GetInt32("idtreino");
                    treino.Nome              = dr.GetString("Nome");
                    treino.Id_Grupo_Treino   = dr.GetInt32("idgrupotreino");
                    treino.Nome_grupo_treino = dr.GetString("NomeCategoria");

                    //nome_grupo_treino

                    lista.Add(treino);
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
        
        public string AdicionarTreino(Treino treino)
        {
            string retorno = "";

            string sql = "insert into treinos(nome,idgrupotreino) values (@nome,@idgrupotreino)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", treino.Nome);
            cmd.Parameters.AddWithValue("@idgrupotreino", treino.Id_Grupo_Treino);           

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Cadastrar : " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public string AtualizarTreino(Treino treino)
        {
            string retorno = "";

            string sql = "update treinos set nome=@nome, idGrupoTreino = @idGrupoTreino where idTreino=@idTreino";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", treino.Nome);
            cmd.Parameters.AddWithValue("@idgrupotreino", treino.Id_Grupo_Treino);
            cmd.Parameters.AddWithValue("@idTreino", treino.Id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Atualizar : " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public string ExcluirTreino(int idTreino)
        {

            string retorno = "";

            string sql = "DELETE FROM treinos WHERE idTreino = @idTreino" ;

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idTreino", idTreino);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (MySqlException ex)
            { retorno = "Erro ao Excluir : " + ex.Message; }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return retorno;

        }
        public string SalvarRepeticoesDoTreino(int idTreino, List<Repeticao> repeticoes)
        {
            string retorno = "";
            MySqlTransaction trans = null;
            MySqlConnection conn = null;

            string sql = "DELETE FROM repeticoes_treinos WHERE idTreino = @idTreino";
            try
            {                               
                conn = CriarConexao();
                conn.Open();

                trans = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand(sql, conn)
                {
                    Transaction = trans          
                };          

                cmd.Parameters.AddWithValue("@idTreino", idTreino);
                // primeira parte limpa os anteriores
                cmd.ExecuteNonQuery();                

                // segunda parte insere tudo de novo
                sql = "insert into repeticoes_treinos(idRepeticao,idTreino)values(@idRepeticao,@idTreino)";
                cmd = new MySqlCommand(sql, conn);

                foreach (Repeticao rep in repeticoes)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idTreino", idTreino);
                    cmd.Parameters.AddWithValue("@idRepeticao", rep.IdRepeticao);
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                conn.Close();
                retorno = "";
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                retorno = "Erro ao Excluir : " + ex.Message;
            }
            finally
            {               
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return retorno;
        }
    }
}
