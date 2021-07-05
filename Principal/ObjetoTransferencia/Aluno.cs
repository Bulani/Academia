using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Aluno
    {
        public Aluno()
        {
            // construtor
        }

        private int IdAluno;
        private string Nome;
        private string Apelido;
        private string Sexo;
        private DateTime Nascimento;
        private string CPF;
        private string RG;
        private string Cidade;
        private string Logradouro;
        private string Numero;
        private string Bairro;
        private string UF;
        private string CEP;
        private DateTime Admissao;
        private string Telefone;
        private string Celular;
        private int Situacao;

        public int      IdAlunoP { get => IdAluno; set => IdAluno = value; }
        public string   NomeP { get => Nome; set => Nome = value; }
        public string   ApelidoP { get => Apelido; set => Apelido = value; }
        public string   SexoP { get => Sexo; set => Sexo = value; }
        public DateTime NascimentoP { get => Nascimento; set => Nascimento = value; }
        public string   CPFP { get => CPF; set => CPF = value; }
        public string   RGP { get => RG; set => RG = value; }
        public string   CidadeP { get => Cidade; set => Cidade = value; }
        public string   LogradouroP { get => Logradouro; set => Logradouro = value; }
        public string   NumeroP { get => Numero; set => Numero = value; }
        public string   BairroP { get => Bairro; set => Bairro = value; }
        public string   UFP { get => UF; set => UF = value; }
        public string   CEPP { get => CEP; set => CEP = value; }
        public DateTime AdmissaoP { get => Admissao; set => Admissao = value; }
        public string   TelefoneP { get => Telefone; set => Telefone = value; }
        public string   CelularP { get => Celular; set => Celular = value; }
        public int      SituacaoP { get => Situacao; set => Situacao = value; }
    }
}
