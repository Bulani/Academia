using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Modalidade
    {
        public Modalidade()
        {
            // construtor
        }

        private int IdModalidade;
        private string Nome;
        private Double ValorMensal;
        private Double ValorAula;
        private int IdFuncionario;
        private List<DiaHoraModalidade> DiasEHorarios;


        public int IdModalidadeP { get => IdModalidade; set => IdModalidade = value; }
        public string NomeP { get => Nome; set => Nome = value; }
        public double ValorMensalP { get => ValorMensal; set => ValorMensal = value; }
        public double ValorAulaP { get => ValorAula; set => ValorAula = value; }
        public int IdFuncionarioP { get => IdFuncionario; set => IdFuncionario = value; }
        public List<DiaHoraModalidade> DiasEHorariosP { get => DiasEHorarios; set => DiasEHorarios = value; }
    }
}
