using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Principal.AppCode.DAL;
using Principal.AppCode.ClassesModelo;

namespace Principal.AppCode.ClassesControle
{
    public class ContasAReceberControle
    {
        public List<Conta_Receber> PesquisarPendenciasAluno(int idAluno)
        {
            Contas_receberDAL ccDal = new Contas_receberDAL();
            return ccDal.PesquisarPendenciasAluno(idAluno);
        }
        public string ReceberPagamento(List<int> idConta_receber, float valor, int forma_pgto, int id_plano_de_conta = 0)
        {
            Contas_receberDAL ccDal = new Contas_receberDAL();
            return ccDal.ReceberPagamento(idConta_receber, valor, forma_pgto, id_plano_de_conta );
        }
    }
}
