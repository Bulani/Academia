using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ExercicioControle
{
    ExercicioDAL exerDAL;
    public ExercicioControle()
    {
        exerDAL = new ExercicioDAL();
    }
    public string AdicionarExercicio(Exercicio exercicio)
    {
        return exerDAL.AdicionarExercicio(exercicio);
    }
    public string AlterarExercicio(Exercicio exercicio)
    {
        return exerDAL.AlterarExercicio(exercicio);
    }
    public string ExcluirExercicio(int Idexercicio)
    {
        return exerDAL.ExcluirExercicio(Idexercicio);
    }
    public List<Exercicio> ListarExercicios(string nome = "")
    {
        return exerDAL.ListarExercicios(nome);
    }
}

