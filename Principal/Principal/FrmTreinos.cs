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
    public partial class FrmTreinos : Form
    {
        public FrmTreinos()
        {
            InitializeComponent();
            dataGridViewTreinos.AutoGenerateColumns = false;            
        }
        public void PesquisarTreinos(string nome)
        {
            TreinoControle tControl = new TreinoControle();

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = tControl.ListarTreinos(nome);
            var source = new BindingSource(bindingList, null);

            dataGridViewTreinos.DataSource = bindingList;
            dataGridViewTreinos.DataSource = source;

            //Atualiza o Grid.
            dataGridViewTreinos.Update();
            dataGridViewTreinos.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarTreinos(txtBoxPesquisa.Text);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmGestaoTreinos frmGestaoTreinos   = new FrmGestaoTreinos();            
            frmGestaoTreinos.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewTreinos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Treino Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }           

            FrmGestaoTreinos frmGestaoTreinos = new FrmGestaoTreinos( AcaoNaTela.Alterar, dataGridViewTreinos.SelectedRows[0].DataBoundItem as Treino);
            frmGestaoTreinos.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewTreinos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!",
                "Selecione um Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pergunta se deseja realmente excluir registro
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir o Registro Selecionado?",
            "Remover Registro",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o aluno selecionado do grid
            Treino treinoSelecionado = (dataGridViewTreinos.SelectedRows[0].DataBoundItem as Treino);

            TreinoControle treControle = new TreinoControle();
            string retorno = treControle.ExcluirTreino(treinoSelecionado.Id);


            //Verifica se excluiu com sucesso            
            if (retorno == "")
            {
                MessageBox.Show("Excluído com Sucesso!",
                "Excluído com sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                PesquisarTreinos(txtBoxPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Não foi possível Excluir. Detalhes: " + retorno,
                "Erro ao Excluir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnExerciciosDoTreino_Click(object sender, EventArgs e)
        {
            //FrmGestaoTreinos frmGestaoTreinos = new FrmGestaoTreinos(AcaoNaTela.Alterar, dataGridViewTreinos.SelectedRows[0].DataBoundItem as Treino);
            //frmGestaoTreinos.ShowDialog();
            FrmExerciciosTreino frmExerciciosTreino = new FrmExerciciosTreino(dataGridViewTreinos.SelectedRows[0].DataBoundItem as Treino);                       
            frmExerciciosTreino.ShowDialog();
        }

        private void btnFecharMod_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
