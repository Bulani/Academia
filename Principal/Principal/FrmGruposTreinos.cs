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
    public partial class FrmGruposTreinos : Form
    {
        public FrmGruposTreinos()
        {
            InitializeComponent();
            dataGridViewGrupoTreino.AutoGenerateColumns = false;
        }
        public void pesqusiarGruposTreinos(string nome)
        {
            GrupoTreinoControle gtControle = new GrupoTreinoControle();
            //coloquei o padrao -1 por que ainda nao tem o combobox
            var bindingList = gtControle.ListarGruposDeTreino(nome);
            var source = new BindingSource(bindingList, null);

            dataGridViewGrupoTreino.DataSource = bindingList;
            dataGridViewGrupoTreino.DataSource = source;

            //Atualiza o Grid.
            dataGridViewGrupoTreino.Update();
            dataGridViewGrupoTreino.Refresh();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesqusiarGruposTreinos(txtBoxPesquisa.Text);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmGestaoGruposTreinos gestaoGruposTreinos = new FrmGestaoGruposTreinos();
            gestaoGruposTreinos.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewGrupoTreino.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum grupo Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            FrmGestaoGruposTreinos gestaoGruposTreinos = new FrmGestaoGruposTreinos(AcaoNaTela.Alterar, (dataGridViewGrupoTreino.SelectedRows[0].DataBoundItem as CategoriaTreino));
            gestaoGruposTreinos.ShowDialog();
        }

        private void btnFecharMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewGrupoTreino.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum grupo Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pergunta se deseja realmente excluir registro
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir o grupo Selecionado?",
            "Remover Grupo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //(dataGridViewGrupoTreino.SelectedRows[0].DataBoundItem as GrupoTreino)
            GrupoTreinoControle gtControle = new GrupoTreinoControle();

            string resposta = gtControle.ExcluirGrupoTreino((dataGridViewGrupoTreino.SelectedRows[0].DataBoundItem as CategoriaTreino).Id);

            if (resposta == "")
            {
                MessageBox.Show("Removido com Sucesso!!!",
               "Gestão de Grupos de treinos",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show(resposta,
               "Gestão de Grupos de treinos",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }


        }
    }
}
