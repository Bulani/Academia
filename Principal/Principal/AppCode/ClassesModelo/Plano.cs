using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Plano
    {
        private int idPlano;
        private string nome;
        private string descricao;
        private float valor;
        private int qtde_alunos;
        private int freq_pagamento;
        private float taxa_inscricao;

        public int IdPlano { get => idPlano; set => idPlano = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public float Valor { get => valor; set => valor = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Freq_pagamento { get => freq_pagamento; set => freq_pagamento = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Taxa_inscricao { get => taxa_inscricao; set => taxa_inscricao = value; }
    }
}
