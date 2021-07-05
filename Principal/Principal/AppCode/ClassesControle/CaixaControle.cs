using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.AppCode.ClassesModelo;
using Principal.AppCode.DAL;

namespace Principal.AppCode.ClassesControle
{
    public class CaixaControle
    {
        public bool ExisteCaixaAberto()
        {
            CaixaDAL cdal = new CaixaDAL();
            return cdal.ExisteCaixaAberto();
        }
        public int NumeroAbertoCaixaAtual()
        {
            CaixaDAL cdal = new CaixaDAL();
            return cdal.NumeroAbertoCaixaAtual();
        }

        public string AbreNovoCaixa()
        {
            CaixaDAL cdal = new CaixaDAL();
            return cdal.AbreNovoCaixa();
        }
        public string FechaCaixaAtual()
        {
            CaixaDAL cdal = new CaixaDAL();
            return cdal.FechaCaixaAtual();
        }
        public List<Caixa> SelecionarCaixas()
        {
            CaixaDAL cdal = new CaixaDAL();
            return cdal.SelecionarCaixas();
        }
        public string ReabrirUltimoCaixa()
        {
            CaixaDAL cdal = new CaixaDAL();
            return cdal.ReabrirUltimoCaixa();
        }
    }
}
