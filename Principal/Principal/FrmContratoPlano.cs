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
    public partial class FrmContratoPlano : Form
    {
        private Contrato contrato;
        private List<Plano> planos;
        //private List<Aluno> alunosContrato;

        public FrmContratoPlano()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 1;
            dgvAlunos.AutoGenerateColumns = false;
            dgvAlunosContrato.AutoGenerateColumns = false;
            contrato = new Contrato();            
        }

        public FrmContratoPlano(Contrato contrato_)
        {
            InitializeComponent();
            contrato = contrato_;            

            cbFiltro.SelectedIndex = 1;
            dgvAlunos.AutoGenerateColumns = false;
            dgvAlunosContrato.AutoGenerateColumns = false;
        }
        public void PesquisarAlunos(string Parametro, int filtro)
        {
            AlunoControle alControle = new AlunoControle();

            var bindingList = alControle.CarregarAlunos(filtro, Parametro);
            var source = new BindingSource(bindingList, null);

            dgvAlunos.DataSource = bindingList;
            dgvAlunos.DataSource = source;

            //Atualiza o Grid.
            dgvAlunos.Update();
            dgvAlunos.Refresh();

        }
        private void FrmContratoPlano_Load(object sender, EventArgs e)
        {
            PlanoControle pControle = new PlanoControle();

            planos = pControle.ListarPlanos();

            cbBoxPlanos.ValueMember = "Nome";
            foreach (Plano plano in planos)
            {
                cbBoxPlanos.Items.Add(plano);
            }            
        }

        private void txtBoxAluno_TextChanged(object sender, EventArgs e)
        {
            PesquisarAlunos(txtBoxAluno.Text, cbFiltro.SelectedIndex);
        }
        public void AtualizaAlunoContrato()
        {
            var bindingList = contrato.AlunosContrato;
            var source = new BindingSource(bindingList, null);

            dgvAlunosContrato.DataSource = bindingList;
            dgvAlunosContrato.DataSource = source;

            //Atualiza o Grid.
            dgvAlunosContrato.Update();
            dgvAlunosContrato.Refresh();
        }

        private void btnAdicioanrAluno_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Aluno Selecionado!",
                "Selecione um Aluno",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            // se este aluno ja foi inserido
            if (contrato.AlunosContrato.IndexOf(dgvAlunos.SelectedRows[0].DataBoundItem as Aluno) >= 0)
            {
                MessageBox.Show("Aluno ja lançado ao contrato!");
            }
            else
            {
                if (contrato.AlunosContrato.Count == (cbBoxPlanos.SelectedItem as Plano).Qtde_alunos)
                {
                    MessageBox.Show("Quantidade maxima de alunos atingida para o plano selecionado!",
                    "Limite de alunos atingido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;

                }
                contrato.AlunosContrato.Add(dgvAlunos.SelectedRows[0].DataBoundItem as Aluno);

                AtualizaAlunoContrato();
            }
        }

        private void cbBoxPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValContrato.Text = (cbBoxPlanos.SelectedItem as Plano).Valor.ToString("C");
            lblTaxaInscricao.Text = (cbBoxPlanos.SelectedItem as Plano).Taxa_inscricao.ToString("C");
            txtDescricao.Text = (cbBoxPlanos.SelectedItem as Plano).Descricao;
            txtQtdeAlunos.Text = (cbBoxPlanos.SelectedItem as Plano).Qtde_alunos.ToString();
            txtFreqPag.Text = (cbBoxPlanos.SelectedItem as Plano).Freq_pagamento.ToString();
        }

        private void btnFecharContrato_Click(object sender, EventArgs e)
        {
            if (contrato.AlunosContrato.Count > (cbBoxPlanos.SelectedItem as Plano).Qtde_alunos)
            {
                MessageBox.Show("Quantidade máxima de alunos ultrapassada para o plano selecionado!",
                "Limite de Alunos Ultrapassado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (contrato.AlunosContrato.Count ==0)
            {
                MessageBox.Show("Não Foram Adicionados Alunos ao Contrato",
                "Contrato Sem Alunos ! ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (cbBoxPlanos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Plano!");
                return;
            }
            if (cbBoxDiaVencimento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Dia de Vencimento!");
                return;
            }
            contrato.PlanoContratado = (cbBoxPlanos.SelectedItem as Plano);
            contrato.IdAlunoResponsavel = (dgvAlunosContrato.SelectedRows[0].DataBoundItem as Aluno).IdAluno;
            contrato.DataEmissao = DateTime.Now;
            contrato.Subtotal = (cbBoxPlanos.SelectedItem as Plano).Taxa_inscricao;
            contrato.Total = (cbBoxPlanos.SelectedItem as Plano).Taxa_inscricao;

            contrato.DiaVencimento = (cbBoxDiaVencimento.SelectedIndex+1);
            ContratoControle cControle = new ContratoControle();
            string resposta = cControle.AdicionarContrato(contrato);

            if (resposta == "")
            {
                MessageBox.Show("Contrato efetuado com sucesso!",
                "Contrato plano",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("Problema ao fechar contrato: "+
                    resposta,
                "Contrato plano",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        private void BtnRemoverAlunoContrato_Click(object sender, EventArgs e)
        {
            if (dgvAlunosContrato.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno selecionado!",
                "Alunos do contrato",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Você realmente deseja remover o Aluno?",
            "Remover?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                contrato.AlunosContrato.Remove(dgvAlunos.SelectedRows[0].DataBoundItem as Aluno);
                AtualizaAlunoContrato();
            }
        }


        private void cbBoxDiaVencimento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((cbBoxPlanos.SelectedIndex > -1)&&(cbBoxDiaVencimento.SelectedIndex>-1))
            {
                DateTime dataVencimento = DateTime.Today.AddDays((cbBoxPlanos.SelectedItem as Plano).Freq_pagamento);
                while (dataVencimento.Day > (cbBoxDiaVencimento.SelectedIndex+1))// se o dia da data maior que o escolhido
                {
                    dataVencimento= dataVencimento.AddDays(-1);
                }
                while (dataVencimento.Day < (cbBoxDiaVencimento.SelectedIndex + 1))// se o dia da data maior que o escolhido
                {
                    dataVencimento = dataVencimento.AddDays(+1);
                }
                contrato.PrimeiroVencimento = dataVencimento;
                lblPrimeiraMensalidade.Text = dataVencimento.ToShortDateString();

            }
        }
    }
}
