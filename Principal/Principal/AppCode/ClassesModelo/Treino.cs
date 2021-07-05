using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.AppCode.ClassesModelo
{
    public class Treino
    {
        private int id;
        private string nome;        
        private int id_Grupo_Treino;
        private string nome_grupo_treino;
       

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Id_Grupo_Treino { get => id_Grupo_Treino; set => id_Grupo_Treino = value; }
        public string Nome_grupo_treino { get => nome_grupo_treino; set => nome_grupo_treino = value; }
       
    }
}
