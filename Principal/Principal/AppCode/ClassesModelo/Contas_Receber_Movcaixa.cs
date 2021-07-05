using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Contas_Receber_Movcaixa
    {
        private int id;
        private int id_contas_receber;
        private int id_mov_caixa;

        public int Id { get => id; set => id = value; }
        public int Id_contas_receber { get => id_contas_receber; set => id_contas_receber = value; }
        public int Id_mov_caixa { get => id_mov_caixa; set => id_mov_caixa = value; }
    }
}
