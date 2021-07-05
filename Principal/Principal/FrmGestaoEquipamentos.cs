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
    public partial class FrmGestaoEquipamentos : Form
    {
        private AcaoNaTela acaoNaTela_;
        private Equipamento equipamento_;

        public FrmGestaoEquipamentos()
        {   
            InitializeComponent();
            acaoNaTela_ = AcaoNaTela.Inserir;
            cbBoxStatus.SelectedIndex = 1;            
        }

        public FrmGestaoEquipamentos(AcaoNaTela acaoNaTela, Equipamento equipamento)
        {
            InitializeComponent();
            acaoNaTela_     = acaoNaTela;            

            if (acaoNaTela_ == AcaoNaTela.Alterar || acaoNaTela_ == AcaoNaTela.Consultar)
            {
                equipamento_ = equipamento;
                txtBoxCodigo.Text   = equipamento_.IdEquipamento.ToString();
                txtBoxNome.Text     = equipamento_.Nome;
                cbBoxStatus.SelectedIndex = equipamento_.Situacao;
                
            }           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string resposta = "";
            if (acaoNaTela_ == AcaoNaTela.Inserir)
            {
                Equipamento equip   = new Equipamento();
                equip.Nome         = txtBoxNome.Text;
                equip.Situacao     = cbBoxStatus.SelectedIndex;
                EquipamentoControle equipControle = new EquipamentoControle();
                resposta            = equipControle.AdicionarEquipamento(equip);
            }
            else
            if (acaoNaTela_ == AcaoNaTela.Alterar)
            {
                equipamento_.Nome = txtBoxNome.Text;
                equipamento_.Situacao = cbBoxStatus.SelectedIndex;
                EquipamentoControle equipControle = new EquipamentoControle();
                resposta = equipControle.AlterarEquipamento(equipamento_);
            }


            if (resposta == "")
            {
                MessageBox.Show("Salvo com Sucesso!",
                "Gestão de Equipamentos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show(resposta,
                "Gestão de Equipamentos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }

       
    }
}
