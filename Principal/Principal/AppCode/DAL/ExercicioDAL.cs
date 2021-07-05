using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


public class ExercicioDAL
{
    //Criar a conexão
    private MySqlConnection CriarConexao()
    {
        return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
    }
    public string AdicionarExercicio(Exercicio exercicio)
    {
        string retorno = "";

        string sql = "insert into exercicios (idEquipamento,nome,Obs) values(@idEquipamento,@nome,@Obs)";

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@idEquipamento", exercicio.IdEquipamento);
        cmd.Parameters.AddWithValue("@nome", exercicio.Nome);
        cmd.Parameters.AddWithValue("@Obs", exercicio.Obs);        

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            retorno = "";
        }
        catch (Exception ex)
        {
            retorno = "Erro ao Cadastrar Exercicio: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }
    public string AlterarExercicio(Exercicio exercicio)
    {
        string retorno = "";

        string sql = "update exercicios set idEquipamento=@idEquipamento,nome=@nome,obs=@obs where idExercicio=@idExercicio";

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@idEquipamento", exercicio.IdEquipamento);
        cmd.Parameters.AddWithValue("@nome", exercicio.Nome);
        cmd.Parameters.AddWithValue("@Obs", exercicio.Obs);
        cmd.Parameters.AddWithValue("@idExercicio", exercicio.IdExercicio);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            retorno = "";
        }
        catch (Exception ex)
        {
            retorno = "Erro ao Alterar Exercicio: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }
    public string ExcluirExercicio(int Idexercicio)
    {
        string retorno = "";

        string sql = "delete from exercicios where idExercicio=@idExercicio";

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@idExercicio", Idexercicio);
        
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            retorno = "";
        }
        catch (Exception ex)
        {
            retorno = "Erro ao Remover Exercicio: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }

    public List<Exercicio> ListarExercicios(string nome = "")
    {
        List<Exercicio> lista = new List<Exercicio>();

        string sql = "select exer.*,equip.Nome Equipamento from exercicios exer,equipamentos equip where exer.IdEquipamento=equip.IdEquipamento ";
       
        if (nome != "")
        {
            sql = sql + " and exer.nome like @nome";
        }

        sql = sql + " order by exer.nome";

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
                Exercicio exercicio = new Exercicio();
                exercicio.IdExercicio = dr.GetInt32("idExercicio");
                exercicio.IdEquipamento = dr.GetInt32("idEquipamento");
                exercicio.Nome = dr.GetString("Nome");
                exercicio.Obs =dr.GetString("Obs");
                exercicio.NomeEquipamento = dr.GetString("Equipamento");
                lista.Add(exercicio);
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

