using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Modalidade
{
    public Modalidade()
    {
        diasEHorarios = new List<DiaHoraModalidade>();
    }

    private int idModalidade;
    private string nome;
    private Double valorMensal;
    private Double valorAula;        
    private List<DiaHoraModalidade> diasEHorarios;

    public int IdModalidade { get => idModalidade; set => idModalidade = value; }
    public string Nome { get => nome; set => nome = value; }
    public double ValorMensal { get => valorMensal; set => valorMensal = value; }
    public double ValorAula { get => valorAula; set => valorAula = value; }        
    public List<DiaHoraModalidade> DiasEHorarios { get => diasEHorarios; set => diasEHorarios = value; }
}

