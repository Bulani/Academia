using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AlunoControle
    {
        AlunoDAL adal;
        public AlunoControle()
        {
            adal = new AlunoDAL();
        }

        public string AdicionarAluno(Aluno aluno)
        {            
            string resposta = "";
            resposta = adal.AdicionarAluno(aluno);
            return resposta;
        }
        public List<Aluno> CarregarAlunos(int ordernarPor = 0, string parametro = "")
        {            
            List<Aluno> lista = new List<Aluno>();
            lista = adal.CarregarAlunos(ordernarPor, parametro);
            return lista;
        }
        public string AlterarAluno(Aluno aluno)
        {            
            string resposta = "";
            resposta = adal.AlterarAluno(aluno);
            return resposta;
        }
        public string ExcluirAluno(int idAlunoP)
        {            
            string resposta = "";
            resposta = adal.ExcluirAluno(idAlunoP);
            return resposta;
        }
    }

