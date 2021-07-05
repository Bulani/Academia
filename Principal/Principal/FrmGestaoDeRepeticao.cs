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
    public partial class FrmGestaoDeRepeticao : Form
    {        
        public FrmGestaoDeRepeticao()
        {
            InitializeComponent();
        }

        private void FrmGestaoDeRepeticao_Load(object sender, EventArgs e)
        {
            dgvExercicios.AutoGenerateColumns = false;

            ExercicioControle exerControle = new ExercicioControle();
            List<Exercicio> exercicios = exerControle.ListarExercicios();

            var bindingList = exercicios;
            var source = new BindingSource(bindingList, null);

            dgvExercicios.DataSource = bindingList;
            dgvExercicios.DataSource = source;

            //Atualiza o Grid.
            dgvExercicios.Update();
            dgvExercicios.Refresh();
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            RepeticaoControle repControle = new RepeticaoControle();
            Repeticao repeticao = new Repeticao();

            repeticao.QtdeSeries = int.Parse(txtQtdeSeries.Text);
            repeticao.QtdeRepeticoes = int.Parse(txtQtdeRepeticoes.Text);
            if (!String.IsNullOrEmpty(txtMinutos.Text))
            { 
                repeticao.Minutos = int.Parse(txtMinutos.Text);
            }
            repeticao.IdExercicio = (dgvExercicios.SelectedRows[0].DataBoundItem as Exercicio).IdExercicio;

            string resp = repControle.AdicionarRepeticao(repeticao);

            if (resp == "")
            {
                MessageBox.Show("Adicionado com Sucesso!!!",
                "Adicionar repetição",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                MessageBox.Show(resp,
                "Erro ao adicionar repetição",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
    //implementar esta tela

}
