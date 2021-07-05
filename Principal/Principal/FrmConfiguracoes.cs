using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Principal
{

    public partial class FrmConfiguracoes : Form
    {

        public FrmConfiguracoes()
        {
            InitializeComponent();
        }
        public bool SalvarConfiguracoes()
        {
            bool resp = false;

            FuncoesINI fini = new FuncoesINI("Configs.ini");
            fini.IniWriteString("Backup","Diretorio", txtBoxPesquisa.Text);

            resp = true;
            return resp;
        }
        public void CarregarConfiguracoes()
        {
            FuncoesINI fini = new FuncoesINI("Configs.ini");
            txtBoxPesquisa.Text = fini.IniReadString("Backup", "Diretorio", Application.ExecutablePath );            


        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                txtBoxPesquisa.Text = fbd.SelectedPath;
                //string[] files = Directory.GetFiles(fbd.SelectedPath);

                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (SalvarConfiguracoes())
            {
                MessageBox.Show("Configurações foram Salvas!");
            }            

        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            CarregarConfiguracoes();
        }
    }
}
