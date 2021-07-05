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
    public partial class FrmGestaoModalidades : Form
    {
        
        private AcaoNaTela acaoNaTela_ ;
        private Modalidade modalidade_ ;
        

        public void AtualizarGrid()
        {
            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = modalidade_.DiasEHorarios;
            var source = new BindingSource(bindingList, null);

            dataGridViewDiaHora.DataSource = bindingList;
            dataGridViewDiaHora.DataSource = source;

            //Atualiza o Grid.
            dataGridViewDiaHora.Update();
            dataGridViewDiaHora.Refresh();

        }
        public void LimparDiaHora()
        {
            cbBoxDia.SelectedIndex  = 0;
            txtBoxHoraInicio.Text   = "";
            txtBoxHoraFim.Text      = "";
        }

        public bool DiahoraJaLancado(DiaHoraModalidade novoDiaHora)
        {
            bool flag = false;

            if(modalidade_.DiasEHorarios.Count >0)
            { 
                foreach (DiaHoraModalidade diaHora in modalidade_.DiasEHorarios)
                {
                    if ((diaHora.Dia== novoDiaHora.Dia) &&
                        (diaHora.HoraFim == novoDiaHora.HoraFim) &&
                        (diaHora.HoraInicio == novoDiaHora.HoraInicio))
                    {
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }


        public FrmGestaoModalidades()
        {
            InitializeComponent();
            acaoNaTela_ = AcaoNaTela.Inserir;
            modalidade_ = new Modalidade();            
            
        }
        public FrmGestaoModalidades(AcaoNaTela acao, Modalidade modalidade)
        {
            InitializeComponent();
            acaoNaTela_ = acao;
            modalidade_ = modalidade;

            if (modalidade.IdModalidade < 1)
            {
                MessageBox.Show("Atenção Modalidade Selecionada é Inválida",
                    "Modalidade Inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();                
            }            
            
        }

        private void FrmModalidadeCadastrar_Load(object sender, EventArgs e)
        {            
            dataGridViewDiaHora.AutoGenerateColumns = false;

            if (acaoNaTela_ == AcaoNaTela.Consultar || acaoNaTela_ == AcaoNaTela.Alterar && modalidade_.IdModalidade>0) {
                txtBoxCodigo.Text   =  modalidade_.IdModalidade.ToString();
                txtBoxNome.Text     = modalidade_.Nome;
                txtBoxMensal.Text   = modalidade_.ValorMensal.ToString();
                txtBoxAula.Text     = modalidade_.ValorAula.ToString();

                //Exibi no Grid os nomes pesquisados no banco de dados.
                var bindingList = modalidade_.DiasEHorarios;
                var source = new BindingSource(bindingList, null);

                dataGridViewDiaHora.DataSource = bindingList;
                dataGridViewDiaHora.DataSource = source;

                //Atualiza o Grid.
                dataGridViewDiaHora.Update();
                dataGridViewDiaHora.Refresh();
            }

            if((acaoNaTela_ == AcaoNaTela.Consultar))
            {

                Image imgAlterar = Properties.Resources.modalidade_consultar;

                //Altera os texto do formulario
                this.Text = "Consultar Modalidade";
                this.lblCadastro.Text = "Consultar Modalidade:";
                this.imgModalidade.Image = imgAlterar;

                gpBoxModalidade.Enabled = false;
                gpBoxHorarios.Enabled = false;
                btnSalvar.Enabled = false;
            } 
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text == "")
            {
                MessageBox.Show("Nome não pode ser vazio",
                "Nome vazio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txtBoxMensal.Text== "") 
            {
                MessageBox.Show("Valor mensal não pode ser vazio",
                "Valor vazio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            modalidade_.Nome = txtBoxNome.Text;
            modalidade_.ValorMensal = Double.Parse( txtBoxMensal.Text);
            modalidade_.ValorAula = Double.Parse(txtBoxAula.Text);

            ModalidadeControle mcontrole = new ModalidadeControle();
            string resposta="";

             
            if (acaoNaTela_ == AcaoNaTela.Inserir)
            {

                Image imgAlterar = Properties.Resources.modalidade_add;

                //Altera os texto do formulario
                this.Text = "Cadastrar Modalidade";
                this.lblCadastro.Text = "Cadastrar Modalidade:";
                this.imgModalidade.Image = imgAlterar;

                resposta = mcontrole.AdicionarModalidade(modalidade_);
            }

            else
            if (acaoNaTela_ == AcaoNaTela.Alterar)
            {

                Image imgAlterar = Properties.Resources.modalidade_edit;

                //Altera os texto do formulario
                this.Text = "Alterar Modalidade";
                this.lblCadastro.Text = "Alterar Modalidade:";
                this.imgModalidade.Image = imgAlterar;

                resposta = mcontrole.AlterarModalidade (modalidade_);
            }

            if (resposta == "")
            {
                MessageBox.Show("Salvo com sucesso!",
                "Cadastro Salvo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Problema ao cadastrar: "+ resposta,
                "Modalidade não cadastrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnAdicionarDiaHora_Click(object sender, EventArgs e)
        {
            DateTime dtAuxIni = new DateTime();
            DateTime dtAuxFim = new DateTime();

            DateTime.TryParse(txtBoxHoraInicio.Text ,out dtAuxIni);
            DateTime.TryParse(txtBoxHoraFim.Text    , out dtAuxFim);

            if (dtAuxIni > dtAuxFim)
            {
                MessageBox.Show("Horário final não pode ser maior que o inicial",
                "Horário inconsistente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }


            if ((cbBoxDia.SelectedIndex < 0 )||(!DateTime.TryParse(txtBoxHoraInicio.Text, out dtAuxIni) )||
                (!DateTime.TryParse(txtBoxHoraFim.Text, out dtAuxFim)))
            {
                MessageBox.Show("Atenção Todos os Campos São Obrigatórios",
                "Campos Obrigatórios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DiaHoraModalidade dhm = new DiaHoraModalidade();
            dhm.Dia = cbBoxDia.SelectedIndex;
            dhm.HoraInicio = DateTime.Parse( txtBoxHoraInicio.Text);
            dhm.HoraFim = DateTime.Parse(txtBoxHoraFim.Text);

            if (DiahoraJaLancado(dhm))
            {
                MessageBox.Show("Dia Hora Já Lançado Para Esta Modalidade",
                "Ítem Repetido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;

            }
            else
            {
                modalidade_.DiasEHorarios.Add(dhm);
                AtualizarGrid();
                LimparDiaHora();
            }
        }

        private void btnRemoverDiaHora_Click(object sender, EventArgs e)
        {
            if (modalidade_.DiasEHorarios.Count > 0)
            {
                modalidade_.DiasEHorarios.Remove(dataGridViewDiaHora.SelectedRows[0].DataBoundItem as DiaHoraModalidade);
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Não Há Dias e Horas Lançadas",
                "Lista Vazia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fecha a tela aberta
            Close();
        }
    }
}
