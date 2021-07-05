using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Repeticao
    {
        
        private int idRepeticao;
        private int idExercicio;
        private int qtdeRepeticoes;
        private int qtdeSeries;
        private int minutos;
        private string nomeExercicio;
        private string nomeEquipamento;
        

        public int IdRepeticao { get => idRepeticao; set => idRepeticao = value; }
        public int IdExercicio { get => idExercicio; set => idExercicio = value; }
        public int QtdeRepeticoes { get => qtdeRepeticoes; set => qtdeRepeticoes = value; }
        public int QtdeSeries { get => qtdeSeries; set => qtdeSeries = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public string NomeExercicio { get => nomeExercicio; set => nomeExercicio = value; }
        public string NomeEquipamento { get => nomeEquipamento; set => nomeEquipamento = value; }
        
    }
}
