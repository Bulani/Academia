using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EquipamentoControle
{
    EquipamentoDAL equipDal;

    public EquipamentoControle()
    {
        equipDal = new EquipamentoDAL();
    }
    public string AdicionarEquipamento(Equipamento equipamento)
    {
        
        return equipDal.AdicionarEquipamento(equipamento);
    }

    public string AlterarEquipamento(Equipamento equipamento)
    {        
        return equipDal.AlterarEquipamento(equipamento);
    }
    public List<Equipamento> ListarEquipamentos(int situacao = -1, string nome = "")
    {
        return equipDal.ListarEquipamentos(situacao,nome);
    }
    public string RemoverEquipamento(int IdEquipamento)
    {
        return equipDal.RemoverEquipamento(IdEquipamento);
    }
}

