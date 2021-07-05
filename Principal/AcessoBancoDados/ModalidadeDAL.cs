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
    public class ModalidadeDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(Settings.Default.stringConexaoMysql);
        }


        //Insere Dados no Banco de Dados
        public string AdicionarModalidade(Modalidade modalidade)
        {
            string retorno = "";

            string sql = "INSERT INTO modalidades(Nome,ValorMensal,ValorAula,IdFuncionario)values(@Nome,@ValorMensal,@ValorAula,@IdFuncionario)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nome", modalidade.NomeP);
            cmd.Parameters.AddWithValue("@ValorMensal", modalidade.ValorMensalP);
            cmd.Parameters.AddWithValue("@ValorAula", modalidade.ValorAulaP);
            cmd.Parameters.AddWithValue("@IdFuncionario", modalidade.IdFuncionarioP);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
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
                    modalidade.IdFuncionarioP = int.Parse(dr["IdModalidade"].ToString());
                    modalidade.NomeP = dr["Nome"].ToString();
                    modalidade.ValorMensalP = Double.Parse(dr["ValorMensal"].ToString());
                    modalidade.ValorAulaP = Double.Parse(dr["ValorAula"].ToString());
                    modalidade.IdFuncionarioP = int.Parse(dr["CPF"].ToString());

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

    }
}
