using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class DiaHoraModalidade
    {
        private int IdDiaHora;
        private int Dia;// de 0 a 6 ou seja domingo 0 ....
        private string NomeDia;
        private DateTime HoraInicio;
        private DateTime HoraFim;
        private int IDModalidade;

        public int IdDiaHoraP { get => IdDiaHora; set => IdDiaHora = value; }
        public int DiaP { get => Dia; set => set_dia(value); }        
        public int IDModalidadeP { get => IDModalidade; set => IDModalidade = value; }
        public DateTime HoraInicioP { get => HoraInicio; set => HoraInicio = value; }
        public DateTime HoraFimP { get => HoraFim; set => HoraFim = value; }
        public string NomeDiaP { get => NomeDia; set => NomeDia = value; }

        private void set_dia(int dia)
        {
            Dia = dia;

            switch (dia)
            {
                case 0:
                    NomeDia = "Domingo";
                    break;
                case 1:
                    NomeDia = "Segunda-Feira";
                    break;
                case 2:
                    NomeDia = "Terça-Feira";
                    break;
                case 3:
                    NomeDia = "Quarta-Feira";
                    break;
                case 4:
                    NomeDia = "Quinta-Feira";
                    break;
                case 5:
                    NomeDia = "Sexta-Feira";
                    break;
                case 6:
                    NomeDia = "Sábado";
                    break;
            }
        }
    }
}
