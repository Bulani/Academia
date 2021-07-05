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
    public partial class FrmExercicios : Form
    {
        public FrmExercicios()
        {
            InitializeComponent();
            dataGridViewExercicios.AutoGenerateColumns = false;
        }
        public void pesqusiarExercicios(String nome)
        {
            ExercicioControle exerControl = new ExercicioControle();
            //coloquei o padrao -1 por que ainda nao tem o combobox
            var bindingList = exerControl.ListarExercicios( nome);
            var source = new BindingSource(bindingList, null);

            dataGridViewExercicios.DataSource = bindingList;
            dataGridViewExercicios.DataSource = source;

            //Atualiza o Grid.
            dataGridViewExercicios.Update();
            dataGridViewExercicios.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesqusiarExercicios(txtBoxPesquisa.Text);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmGestaoExercicios gestaoExercicios = new FrmGestaoExercicios();
            gestaoExercicios.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewExercicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Exercicio Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }            


            FrmGestaoExercicios gestaoExercicios = new FrmGestaoExercicios(AcaoNaTela.Alterar, (dataGridViewExercicios.SelectedRows[0].DataBoundItem as Exercicio));
            gestaoExercicios.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewExercicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Exercicio Selecionado!",
                "Selecione um Exercicio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pergunta se deseja realmente excluir registro
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir o Exercicio Selecionado?",
            "Remover Exercicio",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o aluno selecionado do grid
            Exercicio exercicioSelecionado = (dataGridViewExercicios.SelectedRows[0].DataBoundItem as Exercicio);

            ExercicioControle exerControle = new ExercicioControle();
            string retorno = exerControle.ExcluirExercicio(exercicioSelecionado.IdExercicio);


            //Verifica se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é exbido a mesagem de erro
            if (retorno == "")
            {
                MessageBox.Show("Exercicio excluído com Sucesso!",
                "Exercicio Excluído",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                pesqusiarExercicios(txtBoxPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Não foi possível Excluir. Detalhes: " + retorno,
                "Erro ao Excluir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnFecharMod_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
