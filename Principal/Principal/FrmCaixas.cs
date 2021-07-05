using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.AppCode.ClassesControle;
using Principal.AppCode.ClassesModelo;


namespace Principal
{
    public partial class FrmCaixas : Form
    {
        public FrmCaixas()
        {
            InitializeComponent();
            dgvCaixas.AutoGenerateColumns = false;
        }
        public void ListarCaixas()
        {
            
            CaixaControle cControle = new CaixaControle();

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = cControle.SelecionarCaixas();
            var source = new BindingSource(bindingList, null);

            dgvCaixas.DataSource = bindingList;
            dgvCaixas.DataSource = source;

            //Atualiza o Grid.
            dgvCaixas.Update();
            dgvCaixas.Refresh();
        }
        public void VerificaCaixaAberto()
        {
            CaixaControle cControle = new CaixaControle();
            if (cControle.ExisteCaixaAberto())
            {
                lblStatusCaixa.Text = "Aberto";
                lblStatusCaixa.ForeColor = Color.Blue;
                btnAbrirCaixa.Enabled = false;
                btnFecharCaixa.Enabled = true;
                btnReabrirCaixa.Enabled = false;
            }
            else
            {
                lblStatusCaixa.Text = "Fechado";
                lblStatusCaixa.ForeColor = Color.Red;
                btnAbrirCaixa.Enabled = true;
                btnFecharCaixa.Enabled = false;
                btnReabrirCaixa.Enabled = true;
            }
        }
        private void FrmCaixas_Load(object sender, EventArgs e)
        {
            // listar os caixas e verificar se existe um aberto
            ListarCaixas();
            VerificaCaixaAberto();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            CaixaControle cControle = new CaixaControle();

            DialogResult resultado = MessageBox.Show("Você realmente deseja Fechar o Caixa Atual?",
              "Fechar Caixa Atual?",
              MessageBoxButtons.YesNoCancel,
              MessageBoxIcon.Question);

            if(resultado== DialogResult.Yes)
            {
                string resp = cControle.FechaCaixaAtual();

                if (resp == "")
                {
                    MessageBox.Show("Caixa Fechado com sucesso!");
                    ListarCaixas();
                    VerificaCaixaAberto();
                }
                else
                {
                    MessageBox.Show(resp);
                }
            }            

        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            CaixaControle cControle = new CaixaControle();

            string resp = cControle.AbreNovoCaixa();
            if (resp == "")
            {
                MessageBox.Show("Caixa aberto com sucesso!");
                ListarCaixas();
                VerificaCaixaAberto();
            }
            else
            {
                MessageBox.Show("Não foi possível abrir um novo caixa: "+resp);
            }
        }

        private void btnReabrirCaixa_Click(object sender, EventArgs e)
        {
            CaixaControle cControle = new CaixaControle();

            string resp = cControle.ReabrirUltimoCaixa();
            if (resp == "")
            {
                MessageBox.Show("Caixa reaberto com sucesso!");
                ListarCaixas();
                VerificaCaixaAberto();
            }
            else
            {
                MessageBox.Show("Não foi possível reabrir o caixa: " + resp);
            }

        }
    }
}
