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
    public partial class FrmContasReceber : Form
    {
        public FrmContasReceber()
        {
            InitializeComponent();
            dataGridViewAluno.AutoGenerateColumns = false;
            dgvPendencias.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            //Procura no banco os registro digitado na caixa de pesquisa.
            AlunoControle aControle = new AlunoControle();

            //Exibi no Grid os nomes pesquisados no banco de dados.
            var bindingList = aControle.CarregarAlunos(cbBoxTipoPesquisa.SelectedIndex, txtBoxPesquisa.Text);
            var source = new BindingSource(bindingList, null);

            dataGridViewAluno.DataSource = bindingList;
            dataGridViewAluno.DataSource = source;

            //Atualiza o Grid.
            dataGridViewAluno.Update();
            dataGridViewAluno.Refresh();

        }
        private void AtualizarGridContasAReceber(int idCliente)
        {
            ////Procura pendencias do aluino
            ContasAReceberControle ccControle = new ContasAReceberControle();
            //dgvPendencias
            //Exibi no Grid os Resultados (dataGridViewAluno.SelectedRows[0].DataBoundItem as Aluno);
            var bindingList = ccControle.PesquisarPendenciasAluno(idCliente);
            var source = new BindingSource(bindingList, null);

            dgvPendencias.DataSource = bindingList;
            dgvPendencias.DataSource = source;

            ////Atualiza o Grid.
            dgvPendencias.Update();
            dgvPendencias.Refresh();

        }

        private void txtBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPesquisa.Text != "")
            {
                var intAux = 0;
                if (int.TryParse(txtBoxPesquisa.Text, out intAux))
                {
                    // se eh numerico muda pra código
                    cbBoxTipoPesquisa.SelectedIndex = 0;
                }
                else
                if (cbBoxTipoPesquisa.SelectedIndex == 0)
                {
                    cbBoxTipoPesquisa.SelectedIndex = 1;
                }
            }
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewAluno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AtualizarGridContasAReceber((dataGridViewAluno.SelectedRows[0].DataBoundItem as Aluno).IdAluno);           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lançar no pagamento faze

        }

        private void dgvPendencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //calcular as parcelas selecionadas e ver quanto da
            float totalPagar = 0;            

            for (int i = 0; i < dgvPendencias.RowCount; i++)
            {
                if (dgvPendencias.Rows[i].Selected)
                {
                    totalPagar += (dgvPendencias.SelectedRows[0].DataBoundItem as Conta_Receber).Restante;
                }                
            }
            lblTotalAPagar.Text = totalPagar.ToString("C");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContasAReceberControle crc = new ContasAReceberControle();
            List<int> idsContas = new List<int>();

            for (int i = 0; i < dgvPendencias.RowCount; i++)
            {
                if (dgvPendencias.Rows[i].Selected)
                {
                    idsContas.Add((dgvPendencias.SelectedRows[0].DataBoundItem as Conta_Receber).Idcontas_receber);
                }
            }
            string resp = crc.ReceberPagamento(idsContas, 50, 1);

            if (resp == "")
            {
                MessageBox.Show("Pagamento lançado com sucesso");
            }
            else
                MessageBox.Show(resp);




        }
    }
}
