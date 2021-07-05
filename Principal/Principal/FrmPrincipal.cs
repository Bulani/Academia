using Principal.AppCode.ClassesControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Principal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirtelaEquipamento()
        {
            FrmEquipamentos frmEquipamentos = new FrmEquipamentos();
            //frmEquipamentos.MdiParent = this;
            frmEquipamentos.ShowDialog();
        }
        public void AbrirTelaExercicios()
        {
            FrmExercicios frmExercicios = new FrmExercicios();
            //frmExercicios.MdiParent = this;
            frmExercicios.ShowDialog();

        }

        private void AbrirTelaAluno()
        {
            if (Application.OpenForms.OfType<FrmAlunoSelecionar>().Count()>0)
            {
                MessageBox.Show("Formulário Gerenciar Alunos já esta Aberto!",
                "Formulario Aberto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }

            else
            {
                FrmAlunoSelecionar frmAlunoSelecionar = new FrmAlunoSelecionar();
                //frmAlunoSelecionar.MdiParent = this;
                frmAlunoSelecionar.ShowDialog();
            }
            
        }

        private void AbrirTelaFuncionario()
        {
            if (Application.OpenForms.OfType<FrmFuncionarioSelecionar>().Count() > 0)
            {
                MessageBox.Show("Formulário Gerenciar Funcionários já esta Aberto!",
                "Formulario Aberto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }

            else
            {
                FrmFuncionarioSelecionar frmFuncionarioSelecionar = new FrmFuncionarioSelecionar();
                //frmFuncionarioSelecionar.MdiParent = this;
                frmFuncionarioSelecionar.ShowDialog();
            }
        }

        private void AbrirTelaModalidade()
        {
            if (Application.OpenForms.OfType<FrmModalidadeSelecionar>().Count() > 0)
            {
                MessageBox.Show("Formulário Gerenciar Modalidades já esta Aberto!",
                "Formulario Aberto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }

            else
            {
                FrmModalidadeSelecionar frmModalidadeSelecionar = new FrmModalidadeSelecionar();
                //frmModalidadeSelecionar.MdiParent = this;
                frmModalidadeSelecionar.ShowDialog();
            }
        }

        private void AbrirTelaEmpresa()
        {
            if (Application.OpenForms.OfType<FrmGestaoEmpresa>().Count() > 0)
            {
                MessageBox.Show("Formulário Gerenciar Empresa já esta Aberto!",
                "Formulario Aberto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }

            else
            {
                FrmGestaoEmpresa frmEmpresaCadastrar = new FrmGestaoEmpresa();
                frmEmpresaCadastrar.ShowDialog();
            }

        }

        //Fecha o sistema ao clicar no botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Instancia o Formulario, e Abre ele na tela ----INICIO----
        private void btnAlunos_Click(object sender, EventArgs e)
        {
            AbrirTelaAluno();
        }

        private void btnStripAlunos_Click(object sender, EventArgs e)
        {
            AbrirTelaAluno();
        }

        private void btnStripEmpresa_Click(object sender, EventArgs e)
        {
            AbrirTelaEmpresa();
        }

        private void btnStripFuncionario_Click(object sender, EventArgs e)
        {
            AbrirTelaFuncionario();
        }

        private void btnModalidades_Click(object sender, EventArgs e)
        {
            AbrirTelaModalidade();
        }

        private void btnStripModalidade_Click(object sender, EventArgs e)
        {
            AbrirTelaModalidade();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirtelaEquipamento();
        }

        private void exerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTelaExercicios();
        }

        private void gruposDeTreinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGruposTreinos frmGruposTreinos = new FrmGruposTreinos();
            //frmGruposTreinos.MdiParent = this;
            frmGruposTreinos.ShowDialog();
        }

        private void gestãoDeTreinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTreinos frmTreinos = new FrmTreinos();
            //frmTreinos. = this;
            frmTreinos.ShowDialog();

        }

        private void testeRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Aluno> alunos = new List<Aluno>();
            AlunoControle aControl = new AlunoControle();
            alunos = aControl.CarregarAlunos();
            alunos.ToList();

            FrmRelatorio relatorio = new FrmRelatorio();
            relatorio.ShowDialog();

            //ReportDocument rd = new ReportDocument();
            ////rd.Load(Path.Combine(Server.MapPath("~/CrystalReports"), "ReportCustomer.rpt"));

            //rd.SetDataSource(alunos);
            //rd.;
           

            ////Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            ////stream.Seek(0, SeekOrigin.Begin);
            ////stream.

            ////            File relatorio = File(stream, "application/pdf", "CustomerList.pdf");


        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContratoPlano contratoplano = new FrmContratoPlano();
            contratoplano.ShowDialog();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanos frmPlano = new FrmPlanos();
            frmPlano.ShowDialog();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracoes frmConfig = new FrmConfiguracoes();
            frmConfig.ShowDialog();
        }

        private void btnMenuBackup_Click(object sender, EventArgs e)
        {
            BackupControle bckControl = new BackupControle();

            FuncoesINI fini = new FuncoesINI("Configs.ini");
            //C:\Temp\backup.sql
            //string retorno = bckControl.ExecutarBakcup(fini.IniReadString("Backup", "Diretorio",
            //    @"C:\Temp\backup.sql"));

            string retorno = bckControl.ExecutarBakcup(fini.IniReadString("Backup", "Diretorio", 
              Application.ExecutablePath)+ @"\" + DateTime.Now.ToString("ddMMyyyyHmmss") +@".sql");

            if (retorno == "")
            {
                MessageBox.Show("Backup Realizado com Sucesso!!!");
            }
            else
            {
                MessageBox.Show(retorno);
            }

        }

        private void btnStripRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasReceber frmcr = new FrmContasReceber();
            frmcr.ShowDialog();

        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCaixas frmCX = new FrmCaixas();
            frmCX.ShowDialog();
        }

        private void contratoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //Instancia o Formulario, e Abre ele na tela -----FIM-----
    }
}
