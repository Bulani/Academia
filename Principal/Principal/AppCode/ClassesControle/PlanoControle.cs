using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Principal.AppCode.ClassesModelo;
using Principal.AppCode.DAL;

namespace Principal.AppCode.ClassesControle
{
    public class PlanoControle
    {
        private PlanoDAL planoDAL;

        public PlanoControle()
        {
            planoDAL = new PlanoDAL();
        }
        public string AdicionarPlano(Plano plano)
        {
            return planoDAL.AdicionarPlano(plano);
        }

        public string AlterarPlano(Plano plano)
        {
            return planoDAL.AlterarPlano(plano);
        }
        public string ExcluirPlano(int idPlano)
        {
            return planoDAL.ExcluirPlano(idPlano);
        }

        public List<Plano> ListarPlanos(string nome = "")
        {
            return planoDAL.ListarPlanos(nome);
        }
    }   
}
