using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Principal.AppCode.ClassesModelo;
using Principal.AppCode.ClassesControle;

namespace Principal
{
    public partial class FrmPlanos : Form
    {        
        public void ListarPlanos(string parametro="")
        {
            PlanoControle pControle = new PlanoControle();

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = pControle.ListarPlanos(parametro);
            var source = new BindingSource(bindingList, null);

            dgvPlanos.DataSource = bindingList;
            dgvPlanos.DataSource = source;

            //Atualiza o Grid.
            dgvPlanos.Update();
            dgvPlanos.Refresh();
        }

        public FrmPlanos()
        {
            InitializeComponent();
           
        }

        private void FrmPlanos_Load(object sender, EventArgs e)
        {
            ListarPlanos();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmGestaoPlanos GestaoPlano = new FrmGestaoPlanos();
            GestaoPlano.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ListarPlanos(txtBoxPesquisa.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgvPlanos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Plano Selecionado!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            
            FrmGestaoPlanos GestaoPlano = new FrmGestaoPlanos(AcaoNaTela.Alterar, dgvPlanos.SelectedRows[0].DataBoundItem as Plano);
            GestaoPlano.ShowDialog();            
        }

        private void btnFecharMod_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
