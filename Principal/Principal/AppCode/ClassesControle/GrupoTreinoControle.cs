using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.AppCode.DAL;
using Principal.AppCode.ClassesModelo;

namespace Principal.AppCode.ClassesControle
{
    
    class GrupoTreinoControle
    {
        protected CategoriaTreinoDAL gtDAL;

        public GrupoTreinoControle()
        {
            gtDAL = new CategoriaTreinoDAL();
        }
        public string AdicionarGrupoTreino(CategoriaTreino grupoTreino)
        {            
            return gtDAL.AdicionarGrupoTreino(grupoTreino);
        }
        public List<CategoriaTreino> ListarGruposDeTreino(string nome = "")
        {
            return gtDAL.ListarGruposDeTreino(nome);
        }
        public string AlterarGrupoTreino(CategoriaTreino grupoTreino)
        {
            return gtDAL.AlterarGrupoTreino(grupoTreino);
        }
        public string ExcluirGrupoTreino(int idGrupotreino)
        {
            return gtDAL.ExcluirGrupoTreino(idGrupotreino);
        }
    }
}
