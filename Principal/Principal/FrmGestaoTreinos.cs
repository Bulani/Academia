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
    public partial class FrmGestaoTreinos : Form
    {
        AcaoNaTela acaoNaTela_;
        Treino treino_;
        TreinoControle treinoControle;


        public FrmGestaoTreinos()
        {
            InitializeComponent();
            treinoControle = new TreinoControle();
            acaoNaTela_ = AcaoNaTela.Inserir;
        }

        public FrmGestaoTreinos(AcaoNaTela acaoNaTela , Treino treino)
        {
            
            InitializeComponent();
            treinoControle          = new TreinoControle();
            acaoNaTela_             = acaoNaTela;
            treino_                 = treino;
            txtBoxNomeTreino.Text   = treino_.Nome;            
        }

        private void FrmGestaoTreinos_Load(object sender, EventArgs e)
        {
            GrupoTreinoControle gtControle = new GrupoTreinoControle();
            List<CategoriaTreino> Categorias = gtControle.ListarGruposDeTreino();

            CategoriaTreino catTreino = new CategoriaTreino();
            foreach (CategoriaTreino Categoria in Categorias)
            {
                if (Categoria.Id == treino_.Id_Grupo_Treino)
                { catTreino = Categoria; }
                cbBoxCategorias.Items.Add(Categoria);               
            }
            cbBoxCategorias.DisplayMember = "Nome";
            cbBoxCategorias.ValueMember = "id";

            
            if (acaoNaTela_ == AcaoNaTela.Alterar)
            {
                cbBoxCategorias.SelectedItem = catTreino;
            }            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbBoxCategorias.SelectedIndex < 0)
            {
                throw new System.ArgumentException("Selecione uma categoria, ou cadastre uma se necessário", "Categoria inválida");
            }
            if (txtBoxNomeTreino.Text.Trim() == "")
            {
                throw new System.ArgumentException("Nome do treino não pode estar em branco", "NOme inválido");
            }

            if (acaoNaTela_ == AcaoNaTela.Inserir)
            {
                Treino treino = new Treino();
                treino.Nome = txtBoxNomeTreino.Text;
                treino.Id_Grupo_Treino = (cbBoxCategorias.SelectedItem as CategoriaTreino).Id;

                string resp = treinoControle.AdicionarTreino(treino);

                if (resp == "")
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Cadastrado não foi salvo: "+resp, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acaoNaTela_ == AcaoNaTela.Alterar)
            {
                treino_.Nome            = txtBoxNomeTreino.Text.Trim();
                treino_.Id_Grupo_Treino = (cbBoxCategorias.SelectedItem as CategoriaTreino).Id;
                string resp = treinoControle.AtualizarTreino(treino_);
                if (resp == "")
                {
                    MessageBox.Show("Cadastrado atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Cadastrado não foi atualizado: "+resp, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
