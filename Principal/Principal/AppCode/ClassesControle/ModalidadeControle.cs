using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ModalidadeControle
{
    ModalidadeDAL mdal;
    public ModalidadeControle()
    {
        mdal = new ModalidadeDAL();
    }
    public string AdicionarModalidade(Modalidade modalidade)
    {
        string resposta = "";        
        resposta = mdal.AdicionarModalidade(modalidade);
        return resposta;
    }
    public List<Modalidade> CarregarModalidades(string parametro = "")
    {
        List<Modalidade> lista = new List<Modalidade>();
        lista = mdal.CarregarModalidades(parametro);
        return lista;
    }
    public Modalidade CarregarModalidade(int idModalidade)
    {
        Modalidade modalidade = new Modalidade();
        modalidade = mdal.CarregarModalidade(idModalidade);
        return modalidade;
    }
    public string AlterarModalidade(Modalidade modalidade)
    {
        string resposta = "";
        resposta = mdal.AlterarModalidade(modalidade);
        return resposta;
    }
    public string ExcluirMOdalidade(int idModalidade)
    {
        ModalidadeDAL  modDAL = new ModalidadeDAL();
        return modDAL.ExcluirMOdalidade(idModalidade);
    }

}
