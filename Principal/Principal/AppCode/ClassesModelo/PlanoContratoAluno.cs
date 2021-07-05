using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    class ContratoAluno
    {
        private int idplano_contrato;        
        private int idContrato;
        private int idAluno;

        public int Idplano_contrato { get => idplano_contrato; set => idplano_contrato = value; }
        public int IdContrato { get => idContrato; set => idContrato = value; }
        public int IdAluno { get => idAluno; set => idAluno = value; }
    }
}
