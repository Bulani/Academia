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
    public partial class FrmRepeticoes : Form
    {
        List<Repeticao> repeticoes;
        RepeticaoControle repControle;

        public void PesquisarRepeticoes(string nomeExercicio)
        {
            repeticoes = repControle.ListarRepeticoes(nomeExercicio);

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = repeticoes;
            var source = new BindingSource(bindingList, null);

            dgvRepeticoes.DataSource = bindingList;
            dgvRepeticoes.DataSource = source;

            //Atualiza o Grid.
            dgvRepeticoes.Update();
            dgvRepeticoes.Refresh();
        }

        public FrmRepeticoes()
        {
            InitializeComponent();

            repControle = new RepeticaoControle();
            PesquisarRepeticoes(txtBoxPesquisa.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharMod_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
