using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.AppCode.DAL;
using Principal.AppCode.ClassesModelo;

namespace Principal.AppCode.ClassesControle
{
    class RepeticaoControle
    {
        public List<Repeticao> ListarRepeticoes(string nome = "")
        {
            RepeticaoDAL repDAL = new RepeticaoDAL();
            return repDAL.ListarRepeticoes(nome);
        }
        public string AdicionarRepeticao(Repeticao repeticao)
        {
            RepeticaoDAL repDAL = new RepeticaoDAL();
            return repDAL.AdicionarRepeticao(repeticao);
        }
        public List<Repeticao> ListarRepeticoesDoTreino(int idTreino)
        {
            RepeticaoDAL repDAL = new RepeticaoDAL();
            return repDAL.ListarRepeticoesDoTreino(idTreino);
        }
    }
}
