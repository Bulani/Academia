using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Principal.AppCode.ClassesModelo;
using Principal.AppCode.DAL;

namespace Principal.AppCode.ClassesControle
{
    public class ContratoControle
    {
        public string AdicionarContrato(Contrato contrato)
        {
            string retorno="";
            ContratoDAL cDAL = new ContratoDAL();
            retorno = cDAL.AdicionarContrato(contrato);
            return retorno;
        }
    }
}
