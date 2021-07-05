using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;



class EquipamentoDAL
{
    //Criar a conexão
    private MySqlConnection CriarConexao()
    {
        return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
    }
    public List<Equipamento> ListarEquipamentos(int situacao = -1, string nome = "")
    {
        List<Equipamento> lista = new List<Equipamento>();

        string sql = "select * from equipamentos where idEquipamento>0";
        if (situacao > -1)
        {
            sql = sql + " and situacao=@situacao";
        }
        if (nome != "")
        {
            sql = sql + " and nome like @nome";
        }

        sql = sql + " order by nome";

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        if (nome != "")
        {
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
        }
        if (situacao > -1)
        {
            cmd.Parameters.AddWithValue("@situacao", situacao);
        }

        try
        {
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Equipamento equip = new Equipamento();
                equip.IdEquipamento = dr.GetInt32("idEquipamento");
                equip.Nome = dr.GetString("Nome");
                equip.Situacao = dr.GetInt32("situacao");

                lista.Add(equip);
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
    public string AdicionarEquipamento(Equipamento equipamento)
    {
        string retorno = "";

        string sql = "insert into equipamentos(nome,situacao)values(@nome,@situacao)";

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@nome", equipamento.Nome);
        cmd.Parameters.AddWithValue("@situacao", equipamento.Situacao);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            retorno = "";
        }
        catch (MySqlException ex)
        {
            retorno = "Erro ao Cadastrar Equipamento: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }
    public string AlterarEquipamento(Equipamento equipamento)
    {
        string retorno = "";

        string sql = "update equipamentos set nome=@nome,situacao=@situacao where idEquipamento=@idequipamento";

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@nome", equipamento.Nome);
        cmd.Parameters.AddWithValue("@situacao", equipamento.Situacao);
        cmd.Parameters.AddWithValue("@idequipamento", equipamento.IdEquipamento);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            retorno = "";
        }
        catch (MySqlException ex)
        {
            retorno = "Erro ao Alterar Equipamento: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }
    public string RemoverEquipamento(int IdEquipamento)
    {
        string retorno = "";

        string sql = "DELETE FROM equipamentos WHERE idEquipamento=@idequipamento";

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@idequipamento", IdEquipamento);       

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            retorno = "";
        }
        catch (MySqlException ex)
        {
            retorno = "Erro ao Excluir Equipamento: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }

}
