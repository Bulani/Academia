using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Funcionario
    {

        public Funcionario()
        {
            // construtor
        }

        private int idFuncionario;
        private string nome;
        private string sexo;
        private DateTime nascimento;
        private string cpf;
        private string rg;
        private string cidade;
        private string logradouro;
        private string numero;
        private string bairro;
        private string uf;
        private string cep;
        private DateTime admissao;
        private DateTime demissao;
        private string telefone;
        private string celular;
        private string funcao;
        private Double salario; 
        private int situacao;

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string RG { get => rg; set => rg = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string UF { get => uf; set => uf = value; }
        public string CEP { get => cep; set => cep = value; }
        public DateTime Admissao { get => admissao; set => admissao = value; }
        public DateTime Demissao { get => demissao; set => demissao = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Funcao { get => funcao; set => funcao = value; }
        public int Situacao { get => situacao; set => situacao = value; }
        public double Salario { get => salario; set => salario = value; }
}

