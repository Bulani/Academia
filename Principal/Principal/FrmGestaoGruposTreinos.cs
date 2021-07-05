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
    public partial class FrmGestaoGruposTreinos : Form
    {
        AcaoNaTela acaoNaTela_;
        GrupoTreinoControle gtControle;
        CategoriaTreino grupoTreino_;

        public FrmGestaoGruposTreinos()
        {
            InitializeComponent();
            gtControle = new GrupoTreinoControle();
            acaoNaTela_ = AcaoNaTela.Inserir;
        }

        public FrmGestaoGruposTreinos(AcaoNaTela acao, CategoriaTreino grupoTreino)
        {
            InitializeComponent();
            gtControle      = new GrupoTreinoControle();
            acaoNaTela_     = acao;
            grupoTreino_    = grupoTreino;

            txtBoxCodigo.Text   = grupoTreino_.Id.ToString();
            txtBoxNome.Text = grupoTreino_.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (acaoNaTela_ == AcaoNaTela.Inserir)
            {
                CategoriaTreino gt = new CategoriaTreino();
                gt.Nome = txtBoxNome.Text;
                
                retorno = gtControle.AdicionarGrupoTreino(gt);
            }
            else
            if (acaoNaTela_ == AcaoNaTela.Alterar)
            {
                grupoTreino_.Nome = txtBoxNome.Text;
                retorno  = gtControle.AlterarGrupoTreino(grupoTreino_);
            }

            if (retorno == "")
            {
                MessageBox.Show("Salvo com Sucesso!!!",
                "Gestão de Grupos de Treinos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show(retorno,
                "Gestão de Grupos de Treinos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);              

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
