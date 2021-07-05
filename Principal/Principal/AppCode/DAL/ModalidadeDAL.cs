using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;



public class ModalidadeDAL
{
    //Criar a conexão
    private MySqlConnection CriarConexao()
    {
        return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
    }

    public Modalidade CarregarModalidade(int idModalidade)
    {
        Modalidade mod = new Modalidade();        
        string sql = "SELECT * FROM modalidades where idModalidade=@idModalidade";    

        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@idModalidade",idModalidade);  

        try
        {
            // primeira parte
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                mod.IdModalidade = dr.GetInt32("IdModalidade");
                mod.Nome = dr.GetString("Nome");
                mod.ValorMensal = dr.GetDouble("ValorMensal");
                mod.ValorAula = dr.GetDouble("ValorAula");

                DiaHoraModalidadeDAL dhmDal = new DiaHoraModalidadeDAL();

                mod.DiasEHorarios = dhmDal.DiasHorasModalidade(mod.IdModalidade);
            }
            conn.Close();           
            
        }
        catch (MySqlException ex)
        {
            throw new Exception("Erro ao Carregar informações da modalidade:" + ex.Message);
        }
        finally
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        return mod;
    }
    public String AlterarModalidade(Modalidade modalidade)
    {
           
        string retorno = "";
        // altera a modaldiade
        string sql = "update modalidades set nome=@nome,ValorMensal=@ValorMensal,ValorAula=@valorAula where idModalidade=@idModalidade";

        // limpa os dias anteriores
        string sql2 = "delete from dia_hora_modalidade where idModalidade=@idMOdalidade";
        
        // insere os novos registros
        string sql3 = "insert into dia_hora_modalidade(dia,hora_inicio,idModalidade,Hora_fim)values(@dia,@hora_inicio,@idModalidade,@Hora_fim)";

        MySqlConnection conn = CriarConexao();
        MySqlTransaction trans;
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
        MySqlCommand cmd3 = new MySqlCommand(sql3, conn);

        cmd.Parameters.AddWithValue("@nome", modalidade.Nome);
        cmd.Parameters.AddWithValue("@ValorMensal", modalidade.ValorMensal);
        cmd.Parameters.AddWithValue("@ValorAula", modalidade.ValorAula);
        cmd.Parameters.AddWithValue("@idModalidade", modalidade.IdModalidade);

        cmd2.Parameters.AddWithValue("@idMOdalidade", modalidade.IdModalidade);

        try
        {
            conn.Open();
            trans   = conn.BeginTransaction();
            cmd.Transaction = trans;
            cmd2.Transaction = trans;
            cmd3.Transaction = trans;

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            foreach (DiaHoraModalidade dhm in modalidade.DiasEHorarios)
            {
                cmd3.Parameters.Clear();
                cmd3.Parameters.AddWithValue("@dia", dhm.Dia);
                cmd3.Parameters.AddWithValue("@hora_inicio", dhm.HoraInicio);
                cmd3.Parameters.AddWithValue("@idModalidade", modalidade.IdModalidade);
                cmd3.Parameters.AddWithValue("@Hora_fim", dhm.HoraFim);
                cmd3.ExecuteNonQuery();
            }

            trans.Commit();
            conn.Close();
            retorno = "";
        }
        catch (MySqlException ex)
        {
            //trans.Rollback();
            retorno = "Erro ao Cadastrar Modalidade: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }


    //Insere Dados no Banco de Dados
    public string AdicionarModalidade(Modalidade modalidade)
    {
        string retorno = "";

        string sql = "INSERT INTO modalidades(Nome,ValorMensal,ValorAula)values(@Nome,@ValorMensal,@ValorAula)";

        string sql2 = "INSERT INTO dia_hora_modalidade(dia,hora_inicio,idmodalidade,hora_fim)values(@dia,@hora_inicio,@idmodalidade,@hora_fim)";

        MySqlConnection conn = CriarConexao();

        MySqlCommand cmd = new MySqlCommand(sql, conn);
        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

        try
        {
            conn.Open();  

            cmd.Parameters.AddWithValue("@Nome", modalidade.Nome);
            cmd.Parameters.AddWithValue("@ValorMensal", modalidade.ValorMensal);
            cmd.Parameters.AddWithValue("@ValorAula", modalidade.ValorAula);

            cmd.ExecuteNonQuery();

            modalidade.IdModalidade = SelecionarUltimoID();


            foreach (DiaHoraModalidade dhm in modalidade.DiasEHorarios)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@dia", dhm.Dia);
                cmd2.Parameters.AddWithValue("@hora_inicio", dhm.HoraInicio);
                cmd2.Parameters.AddWithValue("@idmodalidade", modalidade.IdModalidade);
                cmd2.Parameters.AddWithValue("@hora_fim", dhm.HoraFim);
                cmd2.ExecuteNonQuery();
            }           
            conn.Close();
            retorno = "";
        }
        catch (MySqlException ex)
        {
            retorno = "Erro ao Cadastrar Modalidade: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        return retorno;
    }

    //Pesquisa no banco de dados
    public List<Modalidade> CarregarModalidades(string parametro = "")
    {

        List<Modalidade> modalidades = new List<Modalidade>();

        string sql = "";

        if (parametro != "")
        {

            sql = "SELECT * FROM modalidades WHERE Nome LIKE @parametro";
        }

        else
        {
            sql = "SELECT * FROM modalidades";
        }


        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        if (parametro != "")
        {

            cmd.Parameters.AddWithValue("@parametro", "%" + parametro + "%");
        }


        try
        {
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Modalidade modalidade = new Modalidade();
                modalidade.IdModalidade = dr.GetInt32("IdModalidade");
                modalidade.Nome = dr.GetString("Nome");
                modalidade.ValorMensal = dr.GetDouble("ValorMensal");
                modalidade.ValorAula = dr.GetDouble("ValorAula");

                DiaHoraModalidadeDAL dhmDal = new DiaHoraModalidadeDAL();

                modalidade.DiasEHorarios = dhmDal.DiasHorasModalidade(modalidade.IdModalidade);
                modalidades.Add(modalidade);
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
        return modalidades;
    }
    public int SelecionarUltimoID()
    {
        int idModalidade = 0;

        string sql = "select idmodalidade from modalidades order by idmodalidade desc limit 1;";

      
        MySqlConnection conn = CriarConexao();
        MySqlCommand cmd = new MySqlCommand(sql, conn);
              
        try
        {
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                idModalidade = dr.GetInt32("IdModalidade");
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

        return idModalidade;
    }
    public string ExcluirMOdalidade(int idModalidade)
    {
        string resposta = "";
        
        string sql = "delete from dia_hora_modalidade where idModalidade=@idModalidade ";

        string sql2 = "delete from modalidades where idModalidade=@idModalidade";

        MySqlConnection conn = CriarConexao();

        MySqlCommand cmd = new MySqlCommand(sql, conn);
        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

        try
        {
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();
            cmd.Transaction = trans;
            cmd2.Transaction = trans;

            cmd.Parameters.AddWithValue("@idModalidade", idModalidade);
            cmd2.Parameters.AddWithValue("@idModalidade", idModalidade);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }
        catch (MySqlException ex)
        {
            resposta = "Erro ao Excluir Modalidade: " + ex.Message;
        }

        finally { if (conn.State == ConnectionState.Open) conn.Close(); }

        return resposta;
    }


}
