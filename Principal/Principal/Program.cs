using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Principal
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EmpresaDAL empDal = new EmpresaDAL();
            Empresa empresa = empDal.CarregarEmpresa();

            while (empresa == null)
            {
                FrmGestaoEmpresa frmEmpresaCadastrar = new FrmGestaoEmpresa();
                frmEmpresaCadastrar.ShowDialog();
                empresa = empDal.CarregarEmpresa();
            }

            Application.Run(new FrmPrincipal());
           
        }
    }
}
