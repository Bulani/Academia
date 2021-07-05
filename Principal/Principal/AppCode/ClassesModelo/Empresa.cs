using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Empresa
    {

        public Empresa()
        {
            // construtor
        }

        private int idEmpresa;
        private string nomeFantasia;
        private string razao;
        private string cnpj;
        private string ie;
        private DateTime fundacao;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string uf;
        private string numero;
        private string cep;
        private string telefone;
        private string celular;
        private string email;
        private string responsavel;

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string Razao { get => razao; set => razao = value; }
        public string CNPJ { get => cnpj; set => cnpj = value; }
        public string IE { get => ie; set => ie = value; }
        public DateTime Fundacao { get => fundacao; set => fundacao = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string UF { get => uf; set => uf = value; }
        public string Numero { get => numero; set => numero = value; }
        public string CEP { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
    
}
