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
    public partial class FrmFuncionarioSelecionar : Form
    {

        public void FormataHeader()
        {
            dataGridViewFuncionario.Columns[0].Name = "Código";
            dataGridViewFuncionario.Columns[1].Name = "Nome";
            dataGridViewFuncionario.Columns[2].Name = "Sexo";
            dataGridViewFuncionario.Columns[3].Name = "Nascimento";
            dataGridViewFuncionario.Columns[4].Name = "CPF";
            dataGridViewFuncionario.Columns[5].Name = "RG";
            dataGridViewFuncionario.Columns[6].Name = "Cidade";
            dataGridViewFuncionario.Columns[7].Name = "Endereço";
            dataGridViewFuncionario.Columns[8].Name = "Número";
            dataGridViewFuncionario.Columns[9].Name = "Bairro";
            dataGridViewFuncionario.Columns[10].Name = "UF";
            dataGridViewFuncionario.Columns[11].Name = "CEP";
            dataGridViewFuncionario.Columns[12].Name = "Admissão";
            dataGridViewFuncionario.Columns[13].Name = "Demissão";
            dataGridViewFuncionario.Columns[14].Name = "Telefone";
            dataGridViewFuncionario.Columns[15].Name = "Celular";
            dataGridViewFuncionario.Columns[16].Name = "Função";
            dataGridViewFuncionario.Columns[17].Name = "Salário";
        }

        public FrmFuncionarioSelecionar()
        {
            InitializeComponent();

            //Não gerar linhas automaticamente.
            dataGridViewFuncionario.AutoGenerateColumns = false;

        }

        private void btnPesquisarFunc_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            //Procura no banco os registro digitado na caixa de pesquisa.
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = funcionarioDAL.CarregarFuncionarios(txtBoxPesquisa.Text);            
            var source = new BindingSource(bindingList, null);

            dataGridViewFuncionario.DataSource = bindingList;
            dataGridViewFuncionario.DataSource = source;
            FormataHeader();

            //Atualiza o Grid.
            dataGridViewFuncionario.Update();
            dataGridViewFuncionario.Refresh();

        }

        private void btnFecharFunc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

            //Verifica se tem algum registro selecionado
            if (dataGridViewFuncionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Funcionário Selecionado!",
                "Selecione um Funcionário",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pergunta se deseja realmente excluir registro
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir o Funcionário?",
            "Deletar?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o funcionario selecionado do grid
            Funcionario funcionariosSelecionado = (dataGridViewFuncionario.SelectedRows[0].DataBoundItem as Funcionario);

            //Chama o método para excluir
            string retorno = funcionarioDAL.ExcluirFuncionario(funcionariosSelecionado.IdFuncionario);


            //Verifica se excluiu com sucesso
            //Se o retorno for um número é porque deu certo, senão é exbido a mesagem de erro
            if (retorno == "")
            {
                MessageBox.Show("Funcionário excluído com Sucesso!",
                "Funcionário Excluído",
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

        private void btnConsultarFunc_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewFuncionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Funcionário Selecionado!",
                "Consultar Funcionário",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pegar o produto selecionado do grid
            Funcionario funcionarioSelecionado = (dataGridViewFuncionario.SelectedRows[0].DataBoundItem as Funcionario);

            //Instanciar o formulário de consulatr
            FrmGestaoFuncionarios frmFuncionarioCadastrar = new FrmGestaoFuncionarios(AcaoNaTela.Consultar, funcionarioSelecionado);
            frmFuncionarioCadastrar.ShowDialog();
        }

        private void btnAlterarFunc_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dataGridViewFuncionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Funcionário Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //Pegar o produto selecionado do grid
            Funcionario funcionarioSelecionado = (dataGridViewFuncionario.SelectedRows[0].DataBoundItem as Funcionario);

            //Instanciar o formulário de alterar
            FrmGestaoFuncionarios Abrir = new FrmGestaoFuncionarios(AcaoNaTela.Alterar, funcionarioSelecionado);

            DialogResult resultado = Abrir.ShowDialog();
            AtualizarGrid();
        }

        private void btnInserirFunc_Click(object sender, EventArgs e)
        {
            //Instanciar o formulário de cadastro
            FrmGestaoFuncionarios Abrir = new FrmGestaoFuncionarios(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = Abrir.ShowDialog();
            AtualizarGrid();
   
        }

        private void txtBoxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AtualizarGrid();
            }
        }
    }
}
