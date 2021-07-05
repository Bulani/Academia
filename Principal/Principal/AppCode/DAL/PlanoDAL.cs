using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

using Principal.AppCode.ClassesModelo;

namespace Principal.AppCode.DAL
{
    public class PlanoDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public string AdicionarPlano(Plano plano)
        {
            string retorno = "";

            string sql = "insert into planos (nome,descricao,valor,qtde_alunos,freq_pagamento,taxa_inscricao) "+
                "values(@nome,@descricao,@valor,@qtde_alunos,@freq_pagamento,@taxa_inscricao)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", plano.Nome);
            cmd.Parameters.AddWithValue("@descricao", plano.Descricao);
            cmd.Parameters.AddWithValue("@valor", plano.Valor);
            cmd.Parameters.AddWithValue("@qtde_alunos", plano.Qtde_alunos);
            cmd.Parameters.AddWithValue("@freq_pagamento", plano.Freq_pagamento);
            cmd.Parameters.AddWithValue("@taxa_inscricao", plano.Taxa_inscricao);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Problema ao Realizar Cadastro: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public string AlterarPlano(Plano plano)
        {
            string retorno = "";

            string sql = "update Planos set nome=@nome,descricao=@descricao,valor=@valor,"+
                "freq_pagamento=@freq_pagamento,qtde_alunos=@qtde_alunos where idPlano=@idPlano,taxa_inscricao=@taxa_inscricao";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idPlano", plano.IdPlano);
            cmd.Parameters.AddWithValue("@nome", plano.Nome);
            cmd.Parameters.AddWithValue("@descricao", plano.Descricao);
            cmd.Parameters.AddWithValue("@valor", plano.Valor);
            cmd.Parameters.AddWithValue("@qtde_alunos", plano.Qtde_alunos);
            cmd.Parameters.AddWithValue("@freq_pagamento", plano.Freq_pagamento);
            cmd.Parameters.AddWithValue("@taxa_inscricao", plano.Taxa_inscricao);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Problema ao Alterar cadastro: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }
        public string ExcluirPlano(int idPlano)
        {
            string retorno = "";

            string sql = "delete from planos where idPlano=@idPlano";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idPlano", idPlano);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Problema ao Remover Cadastro: " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        public List<Plano> ListarPlanos(string nome = "")
        {
            List<Plano> lista = new List<Plano>();

            string sql = "Select * from planos where idPlano>0  ";

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


            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Plano plano = new Plano();
                    plano.IdPlano = dr.GetInt32("idPlano");
                    plano.Nome = dr.GetString("nome");
                    plano.Descricao = dr.GetString("Descricao");
                    plano.Valor = dr.GetFloat("valor");
                    plano.Qtde_alunos = dr.GetInt32("qtde_alunos");
                    plano.Freq_pagamento = dr.GetInt32("Freq_pagamento");
                    plano.Taxa_inscricao = dr.GetFloat("taxa_inscricao");

                    lista.Add(plano);
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Problema ao Carregar Lista:" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return lista;

        }
    }
}
