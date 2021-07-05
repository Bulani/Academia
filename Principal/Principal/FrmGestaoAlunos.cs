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
    public partial class FrmGestaoAlunos : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;

        public FrmGestaoAlunos(AcaoNaTela acaoNaTela, Aluno alunos)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //Altera o texto do formulario
                this.Text = "Cadastrar Aluno";
                dateAdmissao.Value = DateTime.Now.Date;
                dateNascimento.Value = DateTime.Now.Date;
            }

            else if (acaoNaTela == AcaoNaTela.Alterar)
            {

                Image imgAlterar = Properties.Resources.alunos_edit;

                //Altera os texto do formulario
                this.Text = "Alterar Aluno";
                this.lblCadastro.Text = "Alterar Aluno:";
                this.pictureBox1.Image = imgAlterar;
                

                //Joga os dados do aluno do formulario Alterar
                txtBoxCodigo.Text = alunos.IdAluno.ToString();
                txtBoxNome.Text = alunos.Nome;
                txtBoxApelido.Text = alunos.Apelido;
                comboSexo.Text = alunos.Sexo;
                dateNascimento.Value = alunos.Nascimento;
                txtBoxCPF.Text = alunos.CPF;
                txtBoxRG.Text = alunos.RG;
                txtBoxCidade.Text = alunos.Cidade;
                txtBoxEndereco.Text = alunos.Logradouro;
                txtBoxNumero.Text = alunos.Numero.ToString();
                txtBoxBairro.Text = alunos.Bairro;
                comboEstado.Text = alunos.UF;
                txtBoxCEP.Text = alunos.CEP.ToString();
                dateAdmissao.Value = alunos.Admissao;
                txtBoxTelefone.Text = alunos.Telefone;
                txtBoxCelular.Text = alunos.Celular;
                cbBoxSituacao.SelectedIndex = alunos.Situacao;

            }

            else if (acaoNaTela == AcaoNaTela.Consultar)
            {

                Image imgConsultar = Properties.Resources.alunos_pesquisar;

                //Altera o nome dos componentes formulario
                this.Text = "Consultar Aluno";
                this.lblCadastro.Text = "Consultar Aluno:";
                this.btnCancelar.Focus();
                this.pictureBox1.Image = imgConsultar;

                //Desabilita os campos.
                btnSalvar.Enabled = false;
                panelAlunos.Enabled = false;


                //Joga os dados do aluno do formulario Consultar
                txtBoxCodigo.Text = alunos.IdAluno.ToString();
                txtBoxNome.Text = alunos.Nome;
                txtBoxApelido.Text = alunos.Apelido;
                comboSexo.Text = alunos.Sexo;
                dateNascimento.Value = alunos.Nascimento;
                txtBoxCPF.Text = alunos.CPF;
                txtBoxRG.Text = alunos.RG;
                txtBoxCidade.Text = alunos.Cidade;
                txtBoxEndereco.Text = alunos.Logradouro;
                txtBoxNumero.Text = alunos.Numero.ToString();
                txtBoxBairro.Text = alunos.Bairro;
                comboEstado.Text = alunos.UF;
                txtBoxCEP.Text = alunos.CEP.ToString();
                dateAdmissao.Value = alunos.Admissao;
                txtBoxTelefone.Text = alunos.Telefone;
                txtBoxCelular.Text = alunos.Celular;
                cbBoxSituacao.SelectedIndex = alunos.Situacao;

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //if (!ValidaCPF.ValidarCPF(txtBoxCPF.Text))
            //{

            //    MessageBox.Show("CPF INVÁLIDO!",
            //    "CPF INVÁLIDO",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);

            //    txtBoxCPF.Text = "";
            //    txtBoxCPF.Focus();
            //    txtBoxCPF.Select();
            //}

            //Verifica se há algum campo sem preencher
            if (txtBoxNome.Text == "")
            {
                txtBoxNome.Text = "";

                MessageBox.Show("Preencha o campo Nome!",
                "Campo não preenchido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                txtBoxNome.Focus();
                txtBoxNome.Select();

            }

            else if (comboSexo.Text == "")
            {
                comboSexo.Text = "";

                MessageBox.Show("Preencha o campo Sexo!",
                "Campo não preenchido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                comboSexo.Focus();
                comboSexo.Select();

            }

            else
	        {

                //Verificar se é  inserção ou alteração
                if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
                {
                    Aluno aluno         = new Aluno();
                    aluno.Nome         = txtBoxNome.Text;
                    aluno.Apelido      = txtBoxApelido.Text;
                    aluno.Sexo         = comboSexo.Text;
                    aluno.Nascimento   = dateNascimento.Value.Date;
                    aluno.CPF          = txtBoxCPF.Text;
                    aluno.RG           = txtBoxRG.Text;
                    aluno.Cidade       = txtBoxCidade.Text;
                    aluno.Logradouro   = txtBoxEndereco.Text;
                    aluno.Numero       = txtBoxNumero.Text;
                    aluno.Bairro       = txtBoxBairro.Text;
                    aluno.UF           = comboEstado.Text;
                    aluno.CEP          = txtBoxCEP.Text;
                    aluno.Admissao     = dateAdmissao.Value.Date;
                    aluno.Telefone     = txtBoxTelefone.Text;
                    aluno.Celular      = txtBoxCelular.Text;
                    aluno.Situacao     = cbBoxSituacao.SelectedIndex;


                    AlunoControle aControle = new AlunoControle();
                    string resposta = aControle.AdicionarAluno(aluno);
                    if (resposta != "")
                    {
                        MessageBox.Show(resposta,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Aluno Inserido com Sucesso!!!",
                        "Inserção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        Close();

                    }
                }

                else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
                {
                    Aluno aluno         = new Aluno();

                    aluno.IdAluno      = int.Parse(txtBoxCodigo.Text);
                    aluno.Nome         = txtBoxNome.Text;
                    aluno.Apelido      = txtBoxApelido.Text;
                    aluno.Sexo         = comboSexo.Text;
                    aluno.Nascimento   = dateNascimento.Value.Date;
                    aluno.CPF          = txtBoxCPF.Text;
                    aluno.RG           = txtBoxRG.Text;
                    aluno.Cidade       = txtBoxCidade.Text;
                    aluno.Logradouro   = txtBoxEndereco.Text;
                    aluno.Numero       = txtBoxNumero.Text;
                    aluno.Bairro       = txtBoxBairro.Text;
                    aluno.UF           = comboEstado.Text;
                    aluno.CEP          = txtBoxCEP.Text;
                    aluno.Admissao     = dateAdmissao.Value.Date;
                    aluno.Telefone     = txtBoxTelefone.Text;
                    aluno.Celular      = txtBoxCelular.Text;
                    aluno.Situacao     = cbBoxSituacao.SelectedIndex;

                    AlunoControle aControle = new AlunoControle();

                    string resposta = aControle.AlterarAluno(aluno);
                    if (resposta != "")
                    {
                        MessageBox.Show(resposta,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Aluno Alterado com Sucesso!!!",
                        "Alteração",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        Close();
                    }

                }

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fecha a tela aberta
            Close();
        }

    }
}
