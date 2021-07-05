using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Caixa
    {
        private int idCaixa;
        private DateTime data_abertura;
        private DateTime? data_fechamento;

        public int IdCaixa { get => idCaixa; set => idCaixa = value; }
        public DateTime Data_abertura { get => data_abertura; set => data_abertura = value; }
        public DateTime? Data_fechamento { get => data_fechamento; set => data_fechamento = value; }
    }
}
