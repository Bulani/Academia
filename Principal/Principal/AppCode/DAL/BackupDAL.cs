using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;

namespace Principal.AppCode.DAL
{
    public class BackupDAL
    {
        //Criar a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["connStrAcademia"].ConnectionString);
        }
        public string ExecutarBakcup(string caminhoComNome)
        {
            string resp = "";

            //string constring = _StringConexao;
            //string CaminhoBackup = Caminho + "\\databases.sql";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand( );
            MySqlBackup mb = new MySqlBackup(cmd);
            if (Directory.Exists(System.IO.Path.GetDirectoryName(caminhoComNome)))//MessageBox.Show( System.IO.Path.GetDirectoryName(@"C:\Temp\bancoDedados\BASE.FDB'"));
            {
                try
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ExportToFile(caminhoComNome);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    resp = "Erro ao realizar backup : " + ex.Message;
                }
                finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            }
            else
            {
                resp = "Diretório não existe";
            }
            return resp;
        }

        public string RestaurarBanco(string caminhoComNome)
        {
            string resp = "";

            //string constring = _StringConexao;
            //string CaminhoBackup = Caminho + "\\databases.sql";

            MySqlConnection conn = CriarConexao();
            MySqlCommand cmd = new MySqlCommand();
            MySqlBackup mb = new MySqlBackup(cmd);

            try
            {
                cmd.Connection = conn;
                conn.Open();
                mb.ImportFromFile(caminhoComNome);
                conn.Close();
            }
            catch (Exception ex)
            {
                resp = "Erro ao realizar backup : " + ex.Message;
            }

            finally { if (conn.State == ConnectionState.Open) conn.Close(); }

            return resp;
        }
    }
}
