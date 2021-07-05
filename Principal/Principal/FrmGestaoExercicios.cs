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
    public partial class FrmGestaoExercicios : Form
    {
        AcaoNaTela acaoNaTela_;
        ExercicioControle exerControl;
        Exercicio exercicio_;
        public void CarregarEquipamentos()
        {
            Equipamento equipExercicio= null;
            EquipamentoControle equipControle = new EquipamentoControle();
            List<Equipamento> equipamentos = equipControle.ListarEquipamentos();

            foreach (Equipamento equip in equipamentos)
            {
                if ((exercicio_!=null) &&(equip.IdEquipamento == exercicio_.IdEquipamento))
                {
                    equipExercicio = equip;
                }
                cbBoxEquipamento.Items.Add(equip);
                //cbBoxEquipamento.Items.Add(new KeyValuePair<String,int>( equip.Nome,equip.IdEquipamento));
            }
            cbBoxEquipamento.DisplayMember = "Nome";
            cbBoxEquipamento.ValueMember = "IdEquipamento";

            if (equipExercicio != null)
            {
                cbBoxEquipamento.SelectedItem = equipExercicio;
            }

        }
        public FrmGestaoExercicios()
        {
            InitializeComponent();
            CarregarEquipamentos();
            exerControl = new ExercicioControle();
            acaoNaTela_ = AcaoNaTela.Inserir;

        }
        public FrmGestaoExercicios(AcaoNaTela acao, Exercicio exercicio)
        {
            InitializeComponent();
            exercicio_ = exercicio;

            CarregarEquipamentos();
            exerControl = new ExercicioControle();
            acaoNaTela_ = acao;          

            txtBoxObs.Text = exercicio_.Obs;
            txtBoxNome.Text = exercicio_.Nome;

            txtBoxCodigo.Text               = exercicio_.IdEquipamento.ToString();            
        }

        private void FrmGestaoExercicios_Load(object sender, EventArgs e)
        {
           

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno ="";
            if (acaoNaTela_ == AcaoNaTela.Inserir)
            {
                Exercicio exercicio = new Exercicio();
                exercicio.Nome = txtBoxNome.Text;
                exercicio.Obs = txtBoxObs.Text;
                exercicio.IdEquipamento = (cbBoxEquipamento.SelectedItem as Equipamento).IdEquipamento;
                retorno = exerControl.AdicionarExercicio(exercicio);
            }
            else
            if (acaoNaTela_ == AcaoNaTela.Alterar)
            {
                exercicio_.Nome = txtBoxNome.Text;
                exercicio_.Obs = txtBoxObs.Text;
                exercicio_.IdEquipamento = (cbBoxEquipamento.SelectedItem as Equipamento).IdEquipamento;

            }

            if (retorno == "")
            {
                MessageBox.Show("Salvo com Sucesso!!!",
               "Gestão de Exercicios",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
