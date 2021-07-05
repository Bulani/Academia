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
    public partial class FrmGestaoFuncionarios : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;

        public FrmGestaoFuncionarios(AcaoNaTela acaoNaTela, Funcionario funcionarios)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //Altera o texto do formulario
                this.Text = "Cadastrar Funcionário";
                dateAdmissao.Value = DateTime.Now.Date;
                dateNascimento.Value = DateTime.Now.Date;
            }

            else if (acaoNaTela == AcaoNaTela.Alterar)
            {

                Image imgAlterar = Properties.Resources.funcionario_edit;

                //Altera os texto do formulario
                this.Text = "Alterar Funcionário";
                this.lblCadastro.Text = "Alterar Funcionário:";
                this.picBoxFuncionario.Image = imgAlterar;


                //Joga os dados do aluno do formulario Alterar
                txtBoxCodigo.Text = funcionarios.IdFuncionario.ToString();
                txtBoxNome.Text = funcionarios.Nome;
                comboSexo.Text = funcionarios.Sexo;
                dateNascimento.Value = funcionarios.Nascimento;
                txtBoxCPF.Text = funcionarios.CPF;
                txtBoxRG.Text = funcionarios.RG;
                txtBoxCidade.Text = funcionarios.Cidade;
                txtBoxEndereco.Text = funcionarios.Logradouro;
                txtBoxNumero.Text = funcionarios.Numero.ToString();
                txtBoxBairro.Text = funcionarios.Bairro;
                comboEstado.Text = funcionarios.UF;
                txtBoxCEP.Text = funcionarios.CEP.ToString();
                dateAdmissao.Value = funcionarios.Admissao;
                dateDemissao.Value = funcionarios.Demissao;
                txtBoxTelefone.Text = funcionarios.Telefone;
                txtBoxCelular.Text = funcionarios.Celular;
                cbBoxFuncao.Text = funcionarios.Funcao;
                txtBoxSalario.Text = funcionarios.Salario.ToString();
                cbBoxSituacao.SelectedIndex = funcionarios.Situacao;

            }

            else if (acaoNaTela == AcaoNaTela.Consultar)
            {

                Image imgConsultar = Properties.Resources.funcionario_consultar;

                //Altera o nome dos componentes formulario
                this.Text = "Consultar Funcionário";
                this.lblCadastro.Text = "Consultar Funcionário:";
                this.btnCancelar.Focus();
                this.picBoxFuncionario.Image = imgConsultar;

                //Desabilita os campos.
                btnSalvar.Enabled = false;
                cbBoxSituacao.Enabled = false;
                panelFuncionarios.Enabled = false;


                //Joga os dados do aluno do formulario Consultar
                txtBoxCodigo.Text = funcionarios.IdFuncionario.ToString();
                txtBoxNome.Text = funcionarios.Nome;
                comboSexo.Text = funcionarios.Sexo;
                dateNascimento.Value = funcionarios.Nascimento;
                txtBoxCPF.Text = funcionarios.CPF;
                txtBoxRG.Text = funcionarios.RG;
                txtBoxCidade.Text = funcionarios.Cidade;
                txtBoxEndereco.Text = funcionarios.Logradouro;
                txtBoxNumero.Text = funcionarios.Numero.ToString();
                txtBoxBairro.Text = funcionarios.Bairro;
                comboEstado.Text = funcionarios.UF;
                txtBoxCEP.Text = funcionarios.CEP.ToString();
                dateAdmissao.Value = funcionarios.Admissao;
                dateDemissao.Value = funcionarios.Demissao;
                txtBoxTelefone.Text = funcionarios.Telefone;
                txtBoxCelular.Text = funcionarios.Celular;
                cbBoxFuncao.Text = funcionarios.Funcao;
                txtBoxSalario.Text = funcionarios.Salario.ToString();
                cbBoxSituacao.SelectedIndex = funcionarios.Situacao;

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
                    Funcionario funcionario = new Funcionario();
                    funcionario.Nome = txtBoxNome.Text;
                    funcionario.Sexo = comboSexo.Text;
                    funcionario.Nascimento = dateNascimento.Value.Date;
                    funcionario.CPF = txtBoxCPF.Text;
                    funcionario.RG = txtBoxRG.Text;
                    funcionario.Cidade = txtBoxCidade.Text;
                    funcionario.Logradouro = txtBoxEndereco.Text;
                    funcionario.Numero = txtBoxNumero.Text;
                    funcionario.Bairro = txtBoxBairro.Text;
                    funcionario.UF = comboEstado.Text;
                    funcionario.CEP = txtBoxCEP.Text;
                    funcionario.Admissao = dateAdmissao.Value.Date;
                    funcionario.Demissao = dateDemissao.Value.Date;
                    funcionario.Telefone = txtBoxTelefone.Text;
                    funcionario.Celular = txtBoxCelular.Text;
                    funcionario.Funcao = cbBoxFuncao.Text;
                    funcionario.Salario = Double.Parse(txtBoxSalario.Text);
                    funcionario.Situacao = cbBoxSituacao.SelectedIndex;

                    FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

                    string resposta = funcionarioDAL.AdicionarFuncionario(funcionario);
                    if (resposta != "")
                    {
                        MessageBox.Show(resposta,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Funcionário Inserido com Sucesso!!!",
                        "Inserção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        Close();

                    }
                }

                else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.IdFuncionario = int.Parse(txtBoxCodigo.Text);
                    funcionario.Nome = txtBoxNome.Text;
                    funcionario.Sexo = comboSexo.Text;
                    funcionario.Nascimento = dateNascimento.Value.Date;
                    funcionario.CPF = txtBoxCPF.Text;
                    funcionario.RG = txtBoxRG.Text;
                    funcionario.Cidade = txtBoxCidade.Text;
                    funcionario.Logradouro = txtBoxEndereco.Text;
                    funcionario.Numero = txtBoxNumero.Text;
                    funcionario.Bairro = txtBoxBairro.Text;
                    funcionario.UF = comboEstado.Text;
                    funcionario.CEP = txtBoxCEP.Text;
                    funcionario.Admissao = dateAdmissao.Value.Date;
                    funcionario.Demissao = dateDemissao.Value.Date;
                    funcionario.Telefone = txtBoxTelefone.Text;
                    funcionario.Celular = txtBoxCelular.Text;
                    funcionario.Funcao = cbBoxFuncao.Text;
                    funcionario.Salario = Double.Parse(txtBoxSalario.Text);
                    funcionario.Situacao = cbBoxSituacao.SelectedIndex;

                    FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

                    string resposta = funcionarioDAL.AlterarFuncionario(funcionario);
                    if (resposta != "")
                    {
                        MessageBox.Show(resposta,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Funcionário Alterado com Sucesso!!!",
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
            this.DialogResult = DialogResult.No;
        }
    }
}
