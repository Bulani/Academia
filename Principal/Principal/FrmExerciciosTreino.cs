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
    public partial class FrmExerciciosTreino : Form
    {
        Treino treino;
        List<Repeticao> repeticoes;
        List<Repeticao> repeticoesDoTreino;
        RepeticaoControle repControle;

        private void AdicionarTreino(Repeticao rep)
        {
            if (repeticoesDoTreino.IndexOf(rep) > -1)
            {
                MessageBox.Show("Esta repetição ja está na lista!");
                return;
            }
            {
                repeticoesDoTreino.Add(rep);
                AtualizarRepeticoesDoTreino();
            }

        }
        private void RemoverTreino(Repeticao rep)
        {
            if (repeticoesDoTreino.IndexOf(rep) > -1)
            {
                repeticoesDoTreino.Remove(rep);
                AtualizarRepeticoesDoTreino();
            }
            {
                MessageBox.Show("Esta repetição Não esta na lista está na lista!");
                return;               
            }

        }
        public void AtualizarRepeticoesDoTreino()
        {
            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = repeticoesDoTreino;
            var source = new BindingSource(bindingList, null);

            dgvRepeticoesDoTreino.DataSource = bindingList;
            dgvRepeticoesDoTreino.DataSource = source;

            //Atualiza o Grid.
            dgvRepeticoesDoTreino.Update();
            dgvRepeticoesDoTreino.Refresh();
        }

        public void CarregarRepeticoesDoTreino(int idTreino)
        {
            repeticoesDoTreino = repControle.ListarRepeticoesDoTreino(idTreino);

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = repeticoesDoTreino;
            var source = new BindingSource(bindingList, null);

            dgvRepeticoesDoTreino.DataSource = bindingList;
            dgvRepeticoesDoTreino.DataSource = source;

            //Atualiza o Grid.
            dgvRepeticoesDoTreino.Update();
            dgvRepeticoesDoTreino.Refresh();
        }
        public void PesquisarRepeticoes(string nomeExercicio)
        {
            repeticoes = repControle.ListarRepeticoes(nomeExercicio);

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = repeticoes;
            var source = new BindingSource(bindingList, null);

            dgvRepeticoesDisponiveis.DataSource = bindingList;
            dgvRepeticoesDisponiveis.DataSource = source;

            //Atualiza o Grid.
            dgvRepeticoesDisponiveis.Update();
            dgvRepeticoesDisponiveis.Refresh();
        }
        public FrmExerciciosTreino(Treino treino_)
        {
            InitializeComponent();
            treino = treino_;           

            dgvRepeticoesDisponiveis.AutoGenerateColumns = false;

            // repeticoes disponiveis ao usuárui
            repControle = new RepeticaoControle();
            PesquisarRepeticoes("");

            CarregarRepeticoesDoTreino(treino.Id);
        }

        private void btnAdicionarNovoExercicio_Click(object sender, EventArgs e)
        {
            FrmGestaoDeRepeticao frmGestaoDeRepeticao = new FrmGestaoDeRepeticao();
            frmGestaoDeRepeticao.ShowDialog();
            PesquisarRepeticoes("");
        }

        private void FrmExerciciosTreino_Load(object sender, EventArgs e)
        {
            lblNomeTreino.Text = treino.Nome;
            lblCategoria.Text = treino.Nome_grupo_treino;
        }

        private void btnAddAoTreino_Click(object sender, EventArgs e)
        {
            AdicionarTreino(dgvRepeticoesDisponiveis.SelectedRows[0].DataBoundItem as Repeticao);
        }

        private void btnRemoverDoTreino_Click(object sender, EventArgs e)
        {
            RemoverTreino(dgvRepeticoesDisponiveis.SelectedRows[0].DataBoundItem as Repeticao);
        }

        private void btnSalvarVoltar_Click(object sender, EventArgs e)
        {
            TreinoControle trecontrol = new TreinoControle();
            string resp = trecontrol.SalvarRepeticoesDoTreino(treino.Id,repeticoesDoTreino);

            if (String.IsNullOrEmpty(resp))
            {
                MessageBox.Show("Salvo com sucesso");
                Close();
            }
            {
                MessageBox.Show("Problema ao salvar as alterações: "+resp);

            }
        }
    }
}
