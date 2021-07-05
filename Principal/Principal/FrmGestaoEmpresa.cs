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
    public partial class FrmGestaoEmpresa : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;

        public FrmGestaoEmpresa(AcaoNaTela acaoNaTela, Empresa empresa)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //Altera o texto do formulario
                this.lblCadastro.Text = "Cadastrar Empresa";
                dateFundacao.Value = DateTime.Now.Date;
                btnAlterar.Enabled = false;
            }

            else if (acaoNaTela == AcaoNaTela.Alterar)
            {

                Image imgAlterar = Properties.Resources.empresa_edit;

                //Altera os texto do formulario
                this.lblCadastro.Text = "Alterar Empresa:";
                this.picBoxEmpresa.Image = imgAlterar;
                btnAlterar.Enabled = false;


                //Joga os dados da empresa do formulario Alterar
                txtBoxCodigo.Text = empresa.IdEmpresa.ToString();
                txtBoxNome.Text = empresa.NomeFantasia;
                txtBoxRazao.Text = empresa.Razao;
                txtBoxCNPJ.Text = empresa.CNPJ;
                txtBoxIE.Text = empresa.IE;
                dateFundacao.Value = empresa.Fundacao;
                txtBoxEndereco.Text = empresa.Logradouro;
                txtBoxBairro.Text = empresa.Bairro;
                txtBoxCidade.Text = empresa.Cidade;
                comboEstado.Text = empresa.UF;
                txtBoxNumero.Text = empresa.Numero;
                txtBoxCEP.Text = empresa.CEP;
                txtBoxTelefone.Text = empresa.Telefone;
                txtBoxCelular.Text = empresa.Celular;
                txtBoxEmail.Text = empresa.Email;
                txtBoxResponsavel.Text = empresa.Responsavel;

            }

            else if (acaoNaTela == AcaoNaTela.Consultar)
            {

                Image imgConsultar = Properties.Resources.empresa_consultar;

                //Altera o nome dos componentes formulario
                this.lblCadastro.Text = "Dados da Empresa:";
                this.btnCancelar.Focus();
                this.picBoxEmpresa.Image = imgConsultar;

                //Desabilita os campos.
                btnSalvar.Enabled = false;
                txtBoxResponsavel.Enabled = false;
                panelEmpresa.Enabled = false;


                //Joga os dados do aluno do formulario Consultar
                txtBoxCodigo.Text = empresa.IdEmpresa.ToString();
                txtBoxNome.Text = empresa.NomeFantasia;
                txtBoxRazao.Text = empresa.Razao;
                txtBoxCNPJ.Text = empresa.CNPJ;
                txtBoxIE.Text = empresa.IE;
                dateFundacao.Value = empresa.Fundacao;
                txtBoxEndereco.Text = empresa.Logradouro;
                txtBoxBairro.Text = empresa.Bairro;
                txtBoxCidade.Text = empresa.Cidade;
                comboEstado.Text = empresa.UF;
                txtBoxNumero.Text = empresa.Numero;
                txtBoxCEP.Text = empresa.CEP;
                txtBoxTelefone.Text = empresa.Telefone;
                txtBoxCelular.Text = empresa.Celular;
                txtBoxEmail.Text = empresa.Email;
                txtBoxResponsavel.Text = empresa.Responsavel;

            }

        }
        public FrmGestaoEmpresa()
        {

            InitializeComponent();

            EmpresaDAL empDal = new EmpresaDAL();
            Empresa empresa =  empDal.CarregarEmpresa();

            if (empresa != null)
            {
                this.acaoNaTelaSelecionada = AcaoNaTela.Consultar;
            }
            else
            {
                this.acaoNaTelaSelecionada = AcaoNaTela.Inserir;
            }


            if (this.acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                //Altera o texto do formulario
                this.lblCadastro.Text = "Cadastrar Empresa";
                dateFundacao.Value = DateTime.Now.Date;
                btnAlterar.Enabled = false;
            }

            else if (this.acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {

                Image imgAlterar = Properties.Resources.empresa_edit;

                //Altera os texto do formulario
                this.lblCadastro.Text = "Alterar Empresa:";
                this.picBoxEmpresa.Image = imgAlterar;
                btnAlterar.Enabled = false;


                //Joga os dados da empresa do formulario Alterar
                txtBoxCodigo.Text = empresa.IdEmpresa.ToString();
                txtBoxNome.Text = empresa.NomeFantasia;
                txtBoxRazao.Text = empresa.Razao;
                txtBoxCNPJ.Text = empresa.CNPJ;
                txtBoxIE.Text = empresa.IE;
                dateFundacao.Value = empresa.Fundacao;
                txtBoxEndereco.Text = empresa.Logradouro;
                txtBoxBairro.Text = empresa.Bairro;
                txtBoxCidade.Text = empresa.Cidade;
                comboEstado.Text = empresa.UF;
                txtBoxNumero.Text = empresa.Numero;
                txtBoxCEP.Text = empresa.CEP;
                txtBoxTelefone.Text = empresa.Telefone;
                txtBoxCelular.Text = empresa.Celular;
                txtBoxEmail.Text = empresa.Email;
                txtBoxResponsavel.Text = empresa.Responsavel;

            }

            else if (this.acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {

                Image imgConsultar = Properties.Resources.empresa_consultar;

                //Altera o nome dos componentes formulario
                this.lblCadastro.Text = "Consultar Empresa:";
                this.btnCancelar.Focus();
                this.picBoxEmpresa.Image = imgConsultar;

                //Desabilita os campos.
                btnSalvar.Enabled = false;
                txtBoxResponsavel.Enabled = false;
                panelEmpresa.Enabled = false;


                //Joga os dados do aluno do formulario Consultar
                txtBoxCodigo.Text = empresa.IdEmpresa.ToString();
                txtBoxNome.Text = empresa.NomeFantasia;
                txtBoxRazao.Text = empresa.Razao;
                txtBoxCNPJ.Text = empresa.CNPJ;
                txtBoxIE.Text = empresa.IE;
                dateFundacao.Value = empresa.Fundacao;
                txtBoxEndereco.Text = empresa.Logradouro;
                txtBoxBairro.Text = empresa.Bairro;
                txtBoxCidade.Text = empresa.Cidade;
                comboEstado.Text = empresa.UF;
                txtBoxNumero.Text = empresa.Numero;
                txtBoxCEP.Text = empresa.CEP;
                txtBoxTelefone.Text = empresa.Telefone;
                txtBoxCelular.Text = empresa.Celular;
                txtBoxEmail.Text = empresa.Email;
                txtBoxResponsavel.Text = empresa.Responsavel;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //if (!ValidaCNPJ.ValidarCNPJ(txtBoxCNPJ.Text))
            //{

            //    MessageBox.Show("CNPJ INVÁLIDO!",
            //    "CNPJ INVÁLIDO",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);

            //    txtBoxCNPJ.Text = "";
            //    txtBoxCNPJ.Focus();
            //    txtBoxCNPJ.Select();
            //}

            //Verifica se há algum campo sem preencher
            if (txtBoxNome.Text == "")
            {
                txtBoxNome.Text = "";

                MessageBox.Show("Preencha o campo Nome Fantasia!",
                "Campo não preenchido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                txtBoxNome.Focus();
                txtBoxNome.Select();

            }

            else if (txtBoxCidade.Text == "")
            {
                txtBoxCidade.Text = "";

                MessageBox.Show("Preencha o campo Cidade!",
                "Campo não preenchido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                txtBoxCidade.Focus();
                txtBoxCidade.Select();

            }

            else
            {

                //Verificar se é  inserção ou alteração
                if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
                {
                    Empresa empresa = new Empresa();
                    empresa.NomeFantasia = txtBoxNome.Text;
                    empresa.Razao = txtBoxRazao.Text;
                    empresa.CNPJ = txtBoxCNPJ.Text;
                    empresa.IE = txtBoxIE.Text;
                    empresa.Fundacao = dateFundacao.Value.Date;
                    empresa.Logradouro = txtBoxEndereco.Text;
                    empresa.Bairro = txtBoxBairro.Text;
                    empresa.Cidade = txtBoxCidade.Text;
                    empresa.UF = comboEstado.Text;
                    empresa.Numero = txtBoxNumero.Text;
                    empresa.CEP = txtBoxCEP.Text;
                    empresa.Telefone = txtBoxTelefone.Text;
                    empresa.Celular = txtBoxCelular.Text;
                    empresa.Email = txtBoxEmail.Text;
                    empresa.Responsavel = txtBoxResponsavel.Text;

                    EmpresaDAL empresaDAL = new EmpresaDAL();

                    string resposta = empresaDAL.AdicionarEmpresa(empresa);
                    if (resposta != "")
                    {
                        MessageBox.Show(resposta,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Empresa Cadastrada com Sucesso!!!",
                        "Cadastro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        Close();

                    }
                }

                else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
                {
                    Empresa empresa = new Empresa();

                    empresa.IdEmpresa = int.Parse(txtBoxCodigo.Text);
                    empresa.NomeFantasia = txtBoxNome.Text;
                    empresa.Razao = txtBoxRazao.Text;
                    empresa.CNPJ = txtBoxCNPJ.Text;
                    empresa.IE = txtBoxIE.Text;
                    empresa.Fundacao = dateFundacao.Value.Date;
                    empresa.Logradouro = txtBoxEndereco.Text;
                    empresa.Bairro = txtBoxBairro.Text;
                    empresa.Cidade = txtBoxCidade.Text;
                    empresa.UF = comboEstado.Text;
                    empresa.Numero = txtBoxNumero.Text;
                    empresa.CEP = txtBoxCEP.Text;
                    empresa.Telefone = txtBoxTelefone.Text;
                    empresa.Celular = txtBoxCelular.Text;
                    empresa.Email = txtBoxEmail.Text;
                    empresa.Responsavel = txtBoxResponsavel.Text;

                    EmpresaDAL empresaDAL = new EmpresaDAL();

                    string resposta = empresaDAL.AlterarEmpresa(empresa);
                    if (resposta != "")
                    {
                        MessageBox.Show(resposta,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Empresa Alterada com Sucesso!!!",
                        "Alteração",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        Close();
                    }

                }

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.acaoNaTelaSelecionada != AcaoNaTela.Consultar)
            {
                MessageBox.Show("Ação não pode ser Selecionada",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            this.acaoNaTelaSelecionada  = AcaoNaTela.Alterar;
            btnAlterar.Enabled          = false;
            btnSalvar.Enabled           = true;
            panelEmpresa.Enabled = true;
            txtBoxResponsavel.Enabled = true;

        }
    }
}
