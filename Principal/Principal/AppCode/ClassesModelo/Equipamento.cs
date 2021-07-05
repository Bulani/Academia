using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Equipamento
{
    public Equipamento()
    {
        // construtor
    }

    private int idEquipamento;
    private string nome;
    private int situacao;
    private String nomeSituacao;

    public int IdEquipamento { get => idEquipamento; set => idEquipamento = value; }    
    public int Situacao { get => getSituacao(); set => setSituacao(value); }
    public string NomeSituacao { get => nomeSituacao; set => nomeSituacao = value; }
    public string Nome { get => nome; set => nome = value; }

    private void setSituacao(int situacao)
    {
        this.situacao = situacao;
        nomeSituacao = "";
        switch (situacao)
        {
            case 0:
                nomeSituacao = "Inativo";
                break;
            case 1:
                nomeSituacao = "Ativo";
                break;
            case 2:
                nomeSituacao = "Manutenção";
                break;            

        }       
    }
    private int getSituacao()
    {
        return situacao;
    }
}
