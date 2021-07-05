using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.AppCode.ClassesModelo;
using Principal.AppCode.DAL;



namespace Principal.AppCode.ClassesControle
{
    public class TreinoControle
    {
        public List<Treino> ListarTreinos(string nome = "")
        {
            TreinoDAL tDal = new TreinoDAL();
            return tDal.ListarTreinos(nome);
        }
        public string AdicionarTreino(Treino treino)
        {
            TreinoDAL tDal = new TreinoDAL();
            return tDal.AdicionarTreino(treino);
        }
        public string AtualizarTreino(Treino treino)
        {
            TreinoDAL tDal = new TreinoDAL();
            return tDal.AtualizarTreino(treino);
        }
        public string ExcluirTreino(int idTreino)
        {
            TreinoDAL tDal = new TreinoDAL();
            return tDal.ExcluirTreino(idTreino);
        }
        public string SalvarRepeticoesDoTreino(int idTreino, List<Repeticao> repeticoes)
        {
            TreinoDAL tDal = new TreinoDAL();
            return tDal.SalvarRepeticoesDoTreino(idTreino, repeticoes);
        }
    }
}
