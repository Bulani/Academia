using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Formas_pgto
    {
        private int idformas_pgto;
        private string nome;
        private string descricao;
        private bool contas_receber;
        private bool cadastra_cheque;

        public int Idformas_pgto { get => idformas_pgto; set => idformas_pgto = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool Contas_receber { get => contas_receber; set => contas_receber = value; }
        public bool Cadastra_cheque { get => cadastra_cheque; set => cadastra_cheque = value; }
    }
}
