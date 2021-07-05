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
    class RepeticaoDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public bool JaCadastrada(Repeticao repeticao)
        {
            bool retorno = true;
            

            string sql = "select idrepeticao from repeticoes"+
                "where idExercicio=@idExercicio and qtdeRepeticoes=@qtdeRepeticoes"+
                "and qtdeSeries=@qtdeSeries and minutos = @minutos";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idExercicio", repeticao.IdExercicio);
            cmd.Parameters.AddWithValue("@qtdeRepeticoes", repeticao.QtdeRepeticoes);
            cmd.Parameters.AddWithValue("@qtdeSeries", repeticao.QtdeSeries);
            cmd.Parameters.AddWithValue("@minutos", repeticao.Minutos);

            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                retorno = dr.HasRows;
                conn.Close();
                


            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("Problema ao ler valor do banco: "+ex.Message, "Opa");
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public string AdicionarRepeticao(Repeticao repeticao)
        {
            if (JaCadastrada(repeticao))
            {
                return  "Repetição já esta cadastrada";
            }
            string retorno = "";            

            string sql = "insert into repeticoes(idExercicio,qtdeRepeticoes,qtdeSeries,minutos) values(@idExercicio,@qtdeRepeticoes,@qtdeSeries,@minutos)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idExercicio", repeticao.IdExercicio);
            cmd.Parameters.AddWithValue("@qtdeRepeticoes", repeticao.QtdeRepeticoes);
            cmd.Parameters.AddWithValue("@qtdeSeries", repeticao.QtdeSeries);
            cmd.Parameters.AddWithValue("@minutos", repeticao.Minutos);

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
        public string AlterarRepeticao(Repeticao repeticao)
        {
            string retorno = "";

            string sql  = "update repeticoes set idExercicio=@idExercicio,qtdeRepeticoes=@qtdeRepeticoes,qtdeSeries=@qtdeSeries,minutos=@minutos";
            sql         += " where idRepeticao=@idRepeticao";            

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idExercicio", repeticao.IdExercicio);
            cmd.Parameters.AddWithValue("@qtdeRepeticoes", repeticao.QtdeRepeticoes);
            cmd.Parameters.AddWithValue("@qtdeSeries", repeticao.QtdeSeries);
            cmd.Parameters.AddWithValue("@minutos", repeticao.Minutos);
            cmd.Parameters.AddWithValue("@idRepeticao", repeticao.IdRepeticao);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Alterar : " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public List<Repeticao> ListarRepeticoes(string nome = "")
        {
            List<Repeticao> lista = new List<Repeticao>();
                      


            string sql = "select distinct rep.*,exe.nome as Exercicio,equ.nome as Equipamento";
            sql = sql + " from repeticoes as rep, exercicios as exe, equipamentos as equ ";
            sql = sql + " where rep.idexercicio=exe.idexercicio";
            sql = sql + " and exe.idequipamento=equ.idequipamento";

            if (nome != "")
            {
                sql = sql + " and exe.nome like @nome";
            }

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
                    
                    Repeticao repeticao = new Repeticao();
                    repeticao.IdRepeticao = dr.GetInt32("idRepeticao");
                    repeticao.IdExercicio = dr.GetInt32("IdExercicio");
                    repeticao.QtdeRepeticoes = dr.GetInt32("QtdeRepeticoes");
                    repeticao.QtdeSeries = dr.GetInt32("QtdeSeries");
                    repeticao.Minutos = dr.GetInt32("Minutos");
                    repeticao.NomeExercicio = dr.GetString("Exercicio");
                    repeticao.NomeEquipamento = dr.GetString("Equipamento");                  

                    lista.Add(repeticao);
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
        public List<Repeticao> ListarRepeticoesDoTreino(int idTreino )
        {
            List<Repeticao> lista = new List<Repeticao>();


            string sql = "select distinct rep.*,exe.nome as Exercicio,equ.nome as Equipamento ";
            sql = sql + " from repeticoes as rep, exercicios as exe, equipamentos as equ,repeticoes_treinos as rep_tre ";
            sql = sql + " where rep_tre.idTreino=@idTreino ";
            sql = sql + " and rep_tre.idrepeticao = rep.idRepeticao ";
            sql = sql + " and rep.idexercicio=exe.idexercicio ";
            sql = sql + " and exe.idequipamento=equ.idequipamento ";
            
            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

           
            cmd.Parameters.AddWithValue("@idTreino",  idTreino);
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Repeticao repeticao = new Repeticao();
                    repeticao.IdRepeticao = dr.GetInt32("idRepeticao");
                    repeticao.IdExercicio = dr.GetInt32("IdExercicio");
                    repeticao.QtdeRepeticoes = dr.GetInt32("QtdeRepeticoes");
                    repeticao.QtdeSeries = dr.GetInt32("QtdeSeries");
                    repeticao.Minutos = dr.GetInt32("Minutos");
                    repeticao.NomeExercicio = dr.GetString("Exercicio");
                    repeticao.NomeEquipamento = dr.GetString("Equipamento");

                    lista.Add(repeticao);
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
    }    
}
