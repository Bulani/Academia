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
    public partial class FrmAlunoSelecionar : Form
    {
        public FrmAlunoSelecionar()
        {
            InitializeComponent();

            //Não gerar linhas automaticamente.
            dataGridViewAluno.AutoGenerateColumns = false;
            
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            //Procura no banco os registro digitado na caixa de pesquisa.
            AlunoControle aControle = new AlunoControle();

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = aControle.CarregarAlunos(cbBoxTipoPesquisa.SelectedIndex, txtBoxPesquisa.Text);            
            var source = new BindingSource(bindingList, null);

            dataGridViewAluno.DataSource = bindingList;
            dataGridViewAluno.DataSource = source;
            
            //Atualiza o Grid.
            dataGridViewAluno.Update();
            dataGridViewAluno.Refresh();
            
        }

        private void btnFecharAluno_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {

            AlunoControle aControle = new AlunoControle();

            //Verifica se tem algum registro selecionado
            if (dataGridViewAluno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Aluno Selecionado!",
                "Selecione um Aluno",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pergunta se deseja realmente excluir registro
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir o Aluno?",
            "Deletar?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o aluno selecionado do grid
            Aluno alunosSelecionado = (dataGridViewAluno.SelectedRows[0].DataBoundItem as Aluno);

            //Chama o método para excluir
            string retorno = aControle.ExcluirAluno(alunosSelecionado.IdAluno);


            //Verifica se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é exbido a mesagem de erro
            if (retorno == "")
            {
                MessageBox.Show("Aluno excluído com Sucesso!",
                "Aluno Excluído",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Não foi possível Excluir. Detalhes: " + retorno,
                "Erro ao Excluir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnConsultarAluno_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewAluno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Aluno Selecionado!",
                "Consultar Aluno",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pegar o aluno selecionado do grid
            Aluno alunoSelecionado = (dataGridViewAluno.SelectedRows[0].DataBoundItem as Aluno);

            //Instanciar o formulário de consulatr
            FrmGestaoAlunos frmAlunoCadastrar = new FrmGestaoAlunos(AcaoNaTela.Consultar, alunoSelecionado);
            frmAlunoCadastrar.ShowDialog();
        }

        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewAluno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Aluno Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pegar o aluno selecionado do grid
            Aluno alunoSelecionado = (dataGridViewAluno.SelectedRows[0].DataBoundItem as Aluno);

            //Instanciar o formulário de alterar
            FrmGestaoAlunos Abrir = new FrmGestaoAlunos(AcaoNaTela.Alterar, alunoSelecionado);

            DialogResult resultado = Abrir.ShowDialog();
            AtualizarGrid();
           
        }

        private void btnInserirAluno_Click(object sender, EventArgs e)
        {
            //Instanciar o formulário de cadastro
            FrmGestaoAlunos Abrir = new FrmGestaoAlunos(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = Abrir.ShowDialog();

            AtualizarGrid();
        }

        private void FrmAlunoSelecionar_Load(object sender, EventArgs e)
        {
            cbBoxTipoPesquisa.SelectedIndex = 0;
        }

        private void txtBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPesquisa.Text != "")
            {            
                var intAux=0;
                if (int.TryParse(txtBoxPesquisa.Text, out intAux))
                {
                    // se eh numerico muda pra código
                    cbBoxTipoPesquisa.SelectedIndex = 0;
                }
                else
                if(cbBoxTipoPesquisa.SelectedIndex==0) 
                {
                    cbBoxTipoPesquisa.SelectedIndex = 1;
                }
            }
        }

        private void btnPesquisarAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AtualizarGrid();
            }
        }

        private void dataGridViewAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
