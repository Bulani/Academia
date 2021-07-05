using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FrmModalidadeSelecionar : Form
    {
        public FrmModalidadeSelecionar()
        {
            InitializeComponent();
        }
        private void PesqusiarModalidades(String parametro)
        {
            dataGridViewModalidade.AutoGenerateColumns = false;

            ModalidadeControle mControl = new ModalidadeControle();

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = mControl.CarregarModalidades(parametro);
            var source = new BindingSource(bindingList, null);

            dataGridViewModalidade.DataSource = bindingList;
            dataGridViewModalidade.DataSource = source;

            //Atualiza o Grid.
            dataGridViewModalidade.Update();
            dataGridViewModalidade.Refresh();
        }

        private void btnPesquisarMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //AtualizarGrid();
            }
        }

        private void btnInserirMod_Click(object sender, EventArgs e)
        {
            FrmGestaoModalidades frmModalidadeCadastrar = new FrmGestaoModalidades();
            frmModalidadeCadastrar.ShowDialog();
            PesqusiarModalidades(txtBoxPesquisa.Text);
        }

        private void btnPesquisarMod_Click(object sender, EventArgs e)
        {
            PesqusiarModalidades(txtBoxPesquisa.Text);
        }

        private void btnAlterarMod_Click(object sender, EventArgs e)
        {

            //Verifica se tem algum registro selecionado
            if (dataGridViewModalidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Modalidade Selecionada!",
                "Consultar Modalidade",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            FrmGestaoModalidades frmModalidadeCadastrar = new FrmGestaoModalidades(AcaoNaTela.Alterar, dataGridViewModalidade.SelectedRows[0].DataBoundItem as Modalidade);
            frmModalidadeCadastrar.ShowDialog();
            PesqusiarModalidades(txtBoxPesquisa.Text);
        }

        private void btnConsultarMod_Click(object sender, EventArgs e)
        {

            //Verifica se tem algum registro selecionado
            if (dataGridViewModalidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Modalidade Selecionada!",
                "Consultar Modalidade",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            FrmGestaoModalidades frmModalidadeCadastrar = new FrmGestaoModalidades(AcaoNaTela.Consultar, dataGridViewModalidade.SelectedRows[0].DataBoundItem as Modalidade);
            frmModalidadeCadastrar.ShowDialog();            
        }

        private void btnExcluirMod_Click(object sender, EventArgs e)
        {

            //Verifica se tem algum registro selecionado
            if (dataGridViewModalidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Modalidade Selecionada!",
                "Consultar Modalidade",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Tem realmente certeza de que deseja excluir a modalidade selecionada ?",
                "Excluir Modalidade",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ModalidadeControle modCOntrole = new ModalidadeControle();
                string resposta = modCOntrole.ExcluirMOdalidade((dataGridViewModalidade.SelectedRows[0].DataBoundItem as Modalidade).IdModalidade);

                if (resposta != "")
                {
                    MessageBox.Show("Problema ao excluir modalidade: "+ resposta,
                    "Excluir Modalidade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Modalidade exclusa com sucesso",
                    "Excluir Modalidade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    PesqusiarModalidades(txtBoxPesquisa.Text);
                }

            }
        }

        private void btnFecharMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
