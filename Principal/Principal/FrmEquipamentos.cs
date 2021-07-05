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
    public partial class FrmEquipamentos : Form
    {
        public void PesquisarEquipamento(string nome)
        {
            EquipamentoControle equipControl = new EquipamentoControle();

            //coloquei o padrao -1 por que ainda nao tem o combobox
            var bindingList = equipControl.ListarEquipamentos(-1, nome);
            var source = new BindingSource(bindingList, null);

            dataGridViewEquipamentos.DataSource = bindingList;
            dataGridViewEquipamentos.DataSource = source;

            //Atualiza o Grid.
            dataGridViewEquipamentos.Update();
            dataGridViewEquipamentos.Refresh();
        }
        public FrmEquipamentos()
        {            
            InitializeComponent();
            dataGridViewEquipamentos.AutoGenerateColumns = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Instanciar o formulário de cadastro
            FrmGestaoEquipamentos CadastrarEquipamento = new FrmGestaoEquipamentos();
            CadastrarEquipamento.ShowDialog();

            //PesquisarEquipamento(txtBoxPesquisa.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarEquipamento(txtBoxPesquisa.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewEquipamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Equipamento Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            FrmGestaoEquipamentos CadastrarEquipamento = new FrmGestaoEquipamentos(AcaoNaTela.Alterar, dataGridViewEquipamentos.SelectedRows[0].DataBoundItem as Equipamento);
            CadastrarEquipamento.ShowDialog();
            PesquisarEquipamento(txtBoxPesquisa.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            //Verifica se tem algum registro selecionado
            if (dataGridViewEquipamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Equipamento Selecionado!",
                "Exclusão",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Tem Certeza Que Deseja Remover o Equipamento Selecionado?",
                "Remover Equipamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EquipamentoControle equipControl = new EquipamentoControle();
                string retorno = equipControl.RemoverEquipamento((dataGridViewEquipamentos.SelectedRows[0].DataBoundItem as Equipamento).IdEquipamento);

                if (retorno == "")
                {
                    MessageBox.Show("Removido com Sucesso!!!",
                    "Remover Equipamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(retorno,
                    "Erro ao Remover Equipamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnFecharMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
