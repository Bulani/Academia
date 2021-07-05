using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            //List<Aluno> alunos = new List<Aluno>();
            //AlunoControle aControl = new AlunoControle();
            //alunos = aControl.CarregarAlunos();











            //ReportDataSource reportDataSource = new ReportDataSource();

            //ReportDocument rd = new ReportDocument();
            //rd.Load("~/Reports/ListaDeClientes.rpt");

            //rd.SetDataSource(alunos);

            //crystalReportViewer1.ReportSource = "~/Reports/ListaDeClientes.rpt";

            //rd.;


            ////Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            ////stream.Seek(0, SeekOrigin.Begin);
            ////stream.

            ////            File relatorio = File(stream, "application/pdf", "CustomerList.pdf");
        }

        private void crvClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
