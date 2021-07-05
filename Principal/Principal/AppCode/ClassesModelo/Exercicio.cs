using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercicio
{
    private int idExercicio;
    private int idEquipamento;
    private String nome;
    private String obs;
    private String nomeEquipamento;

    public int IdExercicio { get => idExercicio; set => idExercicio = value; }    
    public string Nome { get => nome; set => nome = value; }
    public string Obs { get => obs; set => obs = value; }
    public int IdEquipamento { get => idEquipamento; set => idEquipamento = value; }
    public string NomeEquipamento { get => nomeEquipamento; set => nomeEquipamento = value; }
}

