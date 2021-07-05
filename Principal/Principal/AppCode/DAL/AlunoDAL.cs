using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


    public class AlunoDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }


        //Insere Dados no Banco de Dados
        public string AdicionarAluno(Aluno aluno)
        {
            string retorno = "";

            string sql = "INSERT INTO alunos(Nome,Apelido,Sexo,Nascimento,CPF,RG,Cidade,Logradouro,Numero,Bairro,UF,CEP,Admissao,Telefone,Celular,Situacao)values(@Nome,@Apelido,@Sexo,@Nascimento,@CPF,@RG,@Cidade,@Logradouro,@Numero,@Bairro,@UF,@CEP,@Admissao,@Telefone,@Celular,@Situacao)";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@Apelido", aluno.Apelido );
            cmd.Parameters.AddWithValue("@Sexo", aluno.Sexo);
            cmd.Parameters.AddWithValue("@Nascimento", aluno.Nascimento);
            cmd.Parameters.AddWithValue("@CPF", aluno.CPF);
            cmd.Parameters.AddWithValue("@RG", aluno.RG);
            cmd.Parameters.AddWithValue("@Cidade", aluno.Cidade);
            cmd.Parameters.AddWithValue("@Logradouro", aluno.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", aluno.Numero );
            cmd.Parameters.AddWithValue("@Bairro", aluno.Bairro);
            cmd.Parameters.AddWithValue("@UF", aluno.UF);
            cmd.Parameters.AddWithValue("@CEP", aluno.CEP);
            cmd.Parameters.AddWithValue("@Admissao", aluno.Admissao );
            cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
            cmd.Parameters.AddWithValue("@Celular", aluno.Celular );
            cmd.Parameters.AddWithValue("@Situacao", aluno.Situacao );

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao Cadastrar : " +ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        public List<Aluno> CarregarAlunos(int PesquisarPor = 0, string parametro = "")
        {
            // 0 id
            // 1 nome
            // 2 apelido
            

            List<Aluno> alunos = new List<Aluno>();

            string sql = "SELECT * FROM alunos ";       

            switch (PesquisarPor)
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
                    aluno.IdAluno      = dr.GetInt32("IdAluno");
                    aluno.Nome         = dr.GetString("Nome"); 
                    aluno.Apelido      = dr.GetString("Apelido");
                    aluno.Sexo         = dr.GetString("Sexo");
                    aluno.Nascimento   = dr.GetDateTime("Nascimento");
                    aluno.CPF          = dr.GetString("CPF");
                    aluno.RG           = dr.GetString("RG");
                    aluno.Cidade       = dr.GetString("Cidade");
                    aluno.Logradouro   = dr.GetString("Logradouro");
                    aluno.Numero       = dr.GetString("Numero");
                    aluno.Bairro       = dr.GetString("Bairro");
                    aluno.UF           = dr.GetString("UF");
                    aluno.CEP          = dr.GetString("CEP");
                    aluno.Admissao     = dr.GetDateTime("Admissao");
                    aluno.Telefone     = dr.GetString("Telefone");
                    aluno.Celular      = dr.GetString("Celular");
                    aluno.Situacao     = dr.GetInt32("Situacao");

                    alunos.Add(aluno);

                }
                conn.Close();                
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao Carregar :" + ex.Message);
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

            cmd.Parameters.AddWithValue("@IdAluno", aluno.IdAluno);
            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@Apelido", aluno.Apelido);
            cmd.Parameters.AddWithValue("@Sexo", aluno.Sexo);
            cmd.Parameters.AddWithValue("@Nascimento", aluno.Nascimento);
            cmd.Parameters.AddWithValue("@CPF", aluno.CPF);
            cmd.Parameters.AddWithValue("@RG", aluno.RG);
            cmd.Parameters.AddWithValue("@Cidade", aluno.Cidade);
            cmd.Parameters.AddWithValue("@Logradouro", aluno.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", aluno.Numero);
            cmd.Parameters.AddWithValue("@Bairro", aluno.Bairro);
            cmd.Parameters.AddWithValue("@UF", aluno.UF);
            cmd.Parameters.AddWithValue("@CEP", aluno.CEP);
            cmd.Parameters.AddWithValue("@Admissao", aluno.Admissao);
            cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
            cmd.Parameters.AddWithValue("@Celular", aluno.Celular);
            cmd.Parameters.AddWithValue("@Situacao", aluno.Situacao);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = "";
            }
            catch (Exception ex)
            { retorno = "Erro ao Alterar: " + ex.Message; }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            return retorno;
        }

        //Excluir dados no Banco de Dados
        public string ExcluirAluno(int idAlunoP)
        {
            
            string retorno = "";

            string sql = "DELETE FROM alunos WHERE IdAluno=@idAluno";

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
            { retorno = "Erro ao Excluir : " + ex.Message; }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return retorno;

        }

}