using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Mov_Caixa
    {
        private int idmov_caixa;
        private DateTime data;
        private int numero_caixa;
        private float valor;
        private int tipo_pgto;
        private int id_plano_de_conta;

        public int Idmov_caixa { get => idmov_caixa; set => idmov_caixa = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Numero_caixa { get => numero_caixa; set => numero_caixa = value; }
        public float Valor { get => valor; set => valor = value; }
        public int Tipo_pgto { get => tipo_pgto; set => tipo_pgto = value; }
        public int Id_plano_de_conta { get => id_plano_de_conta; set => id_plano_de_conta = value; }
    }
}
