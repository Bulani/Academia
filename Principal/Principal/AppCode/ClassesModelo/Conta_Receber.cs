using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Conta_Receber
    {
        private int idcontas_receber;
        private int idContrato;
        private float valor;
        private float valorPago;
        private float valorDesconto;
        private float restante;
        private DateTime data_emissao;
        private DateTime data_vencimento;
        private float valor_juros;
        private bool pendente;
        private int idaluno;

        public Conta_Receber(int idContrato_, float valor_,  DateTime vencimento_)
        {
            idContrato = idContrato_;
            data_emissao = DateTime.Now;
            data_vencimento = vencimento_;
            valor = valor_;
            Pendente = true;
        }
        public Conta_Receber()
        {
          // ---- default ---- // 
        }

        public int Idcontas_receber { get => idcontas_receber; set => idcontas_receber = value; }
        public int IdContrato { get => idContrato; set => idContrato = value; }
        public float Valor { get => valor; set => valor = value; }
        public DateTime Data_emissao { get => data_emissao; set => data_emissao = value; }
        public DateTime Data_vencimento { get => data_vencimento; set => data_vencimento = value; }
        public float Valor_juros { get => valor_juros; set => valor_juros = value; }
        public bool Pendente { get => pendente; set => pendente = value; }
        public int Idaluno { get => idaluno; set => idaluno = value; }
        public float ValorPago { get => valorPago; set => valorPago = value; }
        public float Restante { get => restante; set => restante = value; }
        public float ValorDesconto { get => valorDesconto; set => valorDesconto = value; }
    }
}
