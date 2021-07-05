using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Principal.AppCode.ClassesModelo
{
    public class Contrato
    {
        private int id;
        private DateTime dataEmissao;
        private DateTime primeiroVencimento;
        private int diaVencimento;
        private int idAlunoResponsavel;
        private bool ativo;
        private List<Aluno> alunosContrato;
        private Plano planoContratado;
        private float desconto;
        private float acrescimo;
        private float subtotal;
        private float total;


        public Contrato()
        {
            alunosContrato = new List<Aluno>();
            ativo = true;
        }      

        public int Id { get => id; set => id = value; }
        public DateTime DataEmissao { get => dataEmissao; set => dataEmissao = value; }        
        public int DiaVencimento { get => diaVencimento; set => diaVencimento = value; }
        public int IdAlunoResponsavel { get => idAlunoResponsavel; set => idAlunoResponsavel = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public List<Aluno> AlunosContrato { get => alunosContrato; set => alunosContrato = value; }
        public float Desconto { get => desconto; set => desconto = value; }
        public float Acrescimo { get => acrescimo; set => acrescimo = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }
        public float Total { get => total; set => total = value; }
        public DateTime PrimeiroVencimento { get => primeiroVencimento; set => primeiroVencimento = value; }
        internal Plano PlanoContratado { get => planoContratado; set => planoContratado = value; }
    }
}
