using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Empresa
    {

        public Empresa()
        {
            // construtor
        }

        private int IdEmpresa;
        private string NomeFantasia;
        private string Razao;
        private string CNPJ;
        private string IE;
        private DateTime Fundacao;
        private string Logradouro;
        private string Bairro;
        private string Cidade;
        private string UF;
        private string Numero;
        private string CEP;
        private string Telefone;
        private string Celular;
        private string Email;
        private string Responsavel;

        public int IdEmpresaP { get => IdEmpresa; set => IdEmpresa = value; }
        public string NomeFantasiaP { get => NomeFantasia; set => NomeFantasia = value; }
        public string RazaoP { get => Razao; set => Razao = value; }
        public string CNPJP { get => CNPJ; set => CNPJ = value; }
        public string IEP { get => IE; set => IE = value; }
        public DateTime FundacaoP { get => Fundacao; set => Fundacao = value; }
        public string LogradouroP { get => Logradouro; set => Logradouro = value; }
        public string BairroP { get => Bairro; set => Bairro = value; }
        public string CidadeP { get => Cidade; set => Cidade = value; }
        public string UFP { get => UF; set => UF = value; }
        public string NumeroP { get => Numero; set => Numero = value; }
        public string CEPP { get => CEP; set => CEP = value; }
        public string TelefoneP { get => Telefone; set => Telefone = value; }
        public string CelularP { get => Celular; set => Celular = value; }
        public string EmailP { get => Email; set => Email = value; }
        public string ResponsavelP { get => Responsavel; set => Responsavel = value; }
    }
}
