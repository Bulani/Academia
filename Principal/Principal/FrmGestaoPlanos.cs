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
    public partial class FrmGestaoPlanos : Form
    {
        private AcaoNaTela acaoNaTela_;
        private Plano plano_;

        public FrmGestaoPlanos()
        {
            acaoNaTela_ = AcaoNaTela.Inserir;
            plano_       = new Plano();
            InitializeComponent();
        }

        public FrmGestaoPlanos(AcaoNaTela acaoNaTela, Plano plano)
        {   
            InitializeComponent();

            acaoNaTela_ = acaoNaTela;
            plano_ = plano;

            txtNome.Text = plano.Nome ;
            txtDescricao.Text = plano.Descricao;
            txtValor.Text =  plano.Valor.ToString();
            nupQtdeAlunos.Value =  plano_.Qtde_alunos ;
            nupFreq_Pagamento.Value = plano_.Freq_pagamento ;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            plano_.Nome = txtNome.Text;
            plano_.Descricao = txtDescricao.Text;
            plano_.Valor = float.Parse(txtValor.Text);
            plano_.Qtde_alunos = Decimal.ToInt32(  nupQtdeAlunos.Value);
            plano_.Freq_pagamento = Decimal.ToInt32(nupFreq_Pagamento.Value);

            PlanoControle pControle = new PlanoControle();

            if (acaoNaTela_ == AcaoNaTela.Inserir)
            {
                string resp = pControle.AdicionarPlano(plano_);

                if (resp == "")
                {
                    MessageBox.Show("Cadastro realizado", "Cadastro de Planos");
                }               
            }
            else
            if (acaoNaTela_ == AcaoNaTela.Alterar)
            {
                string resp = pControle.AlterarPlano(plano_);

                if (resp == "")
                {
                    MessageBox.Show("Cadastro atualizado", "Cadastro de Planos");
                }
                else
                {
                    MessageBox.Show(resp, "Cadastro de Planos");
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
