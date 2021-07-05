using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DiaHoraModalidade
    {
        private int idDiaHora;
        private int dia;// de 0 a 6 ou seja domingo 0 ....
        private string nomeDia;
        private DateTime horaInicio;
        private DateTime horaFim;
        private int iDModalidade;

        public int IdDiaHora { get => idDiaHora; set => idDiaHora = value; }
        public int Dia { get => dia; set => set_dia(value); }        
        public int IDModalidade { get => iDModalidade; set => iDModalidade = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFim { get => horaFim; set => horaFim = value; }
        public string NomeDia { get => nomeDia; set => nomeDia = value; }

        private void set_dia(int dia)
        {
            this.dia = dia;

            switch (dia)
            {
                case 0:
                    nomeDia = "Domingo";
                    break;
                case 1:
                    nomeDia = "Segunda-Feira";
                    break;
                case 2:
                    nomeDia = "Terça-Feira";
                    break;
                case 3:
                    nomeDia = "Quarta-Feira";
                    break;
                case 4:
                    nomeDia = "Quinta-Feira";
                    break;
                case 5:
                    nomeDia = "Sexta-Feira";
                    break;
                case 6:
                    nomeDia = "Sábado";
                    break;
            }
        }
    }

