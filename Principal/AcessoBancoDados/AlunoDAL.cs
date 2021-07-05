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
    public class AlunoDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(Settings.Default.stringConexaoMysql);
        }


        //Insere Dados no Banco de Dados
        public string AdicionarAluno(Aluno aluno)
        {
            string retorno = "";

            string sql = "INSERT INTO alunos(Nome,Apelido,Sexo,Nascimento,CPF,RG,Cidade,Logradouro,Numero,Bairro,UF,CEP,Admissao,Telefone,Celular,Situacao)values(@Nome,@Apelido,@Sexo,@Nascimento,@CPF,@RG,@Cidade,@Logradouro,@Numero,@Bairro,@UF,@CEP,@Admissao,@Telefone,@Celular,@Situacao)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nome", aluno.NomeP);
            cmd.Parameters.AddWithValue("@Apelido", aluno.ApelidoP );
            cmd.Parameters.AddWithValue("@Sexo", aluno.SexoP);
            cmd.Parameters.AddWithValue("@Nascimento", aluno.NascimentoP);
            cmd.Parameters.AddWithValue("@CPF", aluno.CPFP);
            cmd.Parameters.AddWithValue("@RG", aluno.RGP);
            cmd.Parameters.AddWithValue("@Cidade", aluno.CidadeP);
            cmd.Parameters.AddWithValue("@Logradouro", aluno.LogradouroP);
            cmd.Parameters.AddWithValue("@Numero", aluno.NumeroP );
            cmd.Parameters.AddWithValue("@Bairro", aluno.BairroP);
            cmd.Parameters.AddWithValue("@UF", aluno.UFP);
            cmd.Parameters.AddWithValue("@CEP", aluno.CEPP);
            cmd.Parameters.AddWithValue("@Admissao", aluno.AdmissaoP );
            cmd.Parameters.AddWithValue("@Telefone", aluno.TelefoneP);
            cmd.Parameters.AddWithValue("@Celular", aluno.CelularP );
            cmd.Parameters.AddWithValue("@Situacao", aluno.SituacaoP );

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Cadastrar Aluno: " +ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        public List<Aluno> CarregarAlunos(int ordernarPor = 0, string parametro = "")
        {
            // 0 id
            // 1 nome
            // 2 apelido
            

            List<Aluno> alunos = new List<Aluno>();

            string sql = "SELECT * FROM alunos ";       

            switch (ordernarPor)
            {
                case -1:
                case 0 :
                    {
                        if (parametro != "")
                        {
                            sql += " WHERE IdAluno like @parametro ";
                        }
                        sql += " ORDER BY IdAluno ";
                        break;
                    }
                case 1:
                    {
                        if (parametro != "")
                        {
                            sql += " WHERE Nome like @parametro ";
                        }
                        sql += " ORDER BY Nome ";
                        break;
                    }
                case 2:
                    {
                        if (parametro != "")
                        {
                            sql += " WHERE Apelido like @parametro ";
                        }
                        sql += " ORDER BY Apelido ";
                        break;
                    }
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
                    Aluno aluno = new Aluno();
                    aluno.IdAlunoP      = int.Parse( dr["IdAluno"].ToString());
                    aluno.NomeP         = dr["Nome"].ToString();
                    aluno.ApelidoP      = dr["Apelido"].ToString();
                    aluno.SexoP         = dr["Sexo"].ToString();
                    aluno.NascimentoP   = DateTime.Parse( dr["Nascimento"].ToString());
                    aluno.CPFP          = dr["CPF"].ToString();
                    aluno.RGP           = dr["RG"].ToString(); ;
                    aluno.CidadeP       = dr["Cidade"].ToString();
                    aluno.LogradouroP   = dr["Logradouro"].ToString();
                    aluno.NumeroP       = dr["Numero"].ToString();
                    aluno.BairroP       = dr["Bairro"].ToString();
                    aluno.UFP           = dr["UF"].ToString();
                    aluno.CEPP          = dr["CEP"].ToString();
                    aluno.AdmissaoP     = DateTime.Parse(dr["Admissao"].ToString());
                    aluno.TelefoneP     = dr["Telefone"].ToString();
                    aluno.CelularP      = dr["Celular"].ToString();
                    aluno.SituacaoP     = int.Parse(dr["Situacao"].ToString());

                    alunos.Add(aluno);

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
            return alunos;            
        }

        //Altera Dados no Banco de Dados
        public string AlterarAluno(Aluno aluno)
        {
            string retorno = "";

            string sql = "UPDATE alunos SET Nome=@Nome,Apelido=@Apelido,Sexo=@Sexo,Nascimento=@Nascimento,CPF=@CPF,RG=@RG,Cidade=@Cidade,Logradouro=@Logradouro,Numero=@Numero,Bairro=@Bairro,UF=@UF,CEP=@CEP,Admissao=@Admissao,Telefone=@Telefone,Celular=@Celular,Situacao=@Situacao WHERE IdAluno=@IdAluno";
            

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@IdAluno", aluno.IdAlunoP);
            cmd.Parameters.AddWithValue("@Nome", aluno.NomeP);
            cmd.Parameters.AddWithValue("@Apelido", aluno.ApelidoP);
            cmd.Parameters.AddWithValue("@Sexo", aluno.SexoP);
            cmd.Parameters.AddWithValue("@Nascimento", aluno.NascimentoP);
            cmd.Parameters.AddWithValue("@CPF", aluno.CPFP);
            cmd.Parameters.AddWithValue("@RG", aluno.RGP);
            cmd.Parameters.AddWithValue("@Cidade", aluno.CidadeP);
            cmd.Parameters.AddWithValue("@Logradouro", aluno.LogradouroP);
            cmd.Parameters.AddWithValue("@Numero", aluno.NumeroP);
            cmd.Parameters.AddWithValue("@Bairro", aluno.BairroP);
            cmd.Parameters.AddWithValue("@UF", aluno.UFP);
            cmd.Parameters.AddWithValue("@CEP", aluno.CEPP);
            cmd.Parameters.AddWithValue("@Admissao", aluno.AdmissaoP);
            cmd.Parameters.AddWithValue("@Telefone", aluno.TelefoneP);
            cmd.Parameters.AddWithValue("@Celular", aluno.CelularP);
            cmd.Parameters.AddWithValue("@Situacao", aluno.SituacaoP);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            { retorno = "Erro ao Alterar Aluno: " + ex.Message; }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        //Excluir dados no Banco de Dados
        public string ExcluirAluno(int idAlunoP)
        {
            
            string retorno = "";

            string sql = "DELETE FROM alunos WHERE IdAluno=" + idAlunoP;

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@IdAluno", idAlunoP);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (MySqlException ex)
            { retorno = "Erro ao Excluir Aluno: " + ex.Message; }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return retorno;

        }

        public bool TestaConexao()
        {
            //criar a conexão
            MySqlConnection sqlConnection = CriarConexao();
            //Abrir conexão
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            { return true; }
            else
            { return false; }
        }



    }
}
