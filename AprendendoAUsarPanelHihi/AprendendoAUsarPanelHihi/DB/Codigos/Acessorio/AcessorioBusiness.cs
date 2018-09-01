using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Acessorio
{
    class AcessorioBusiness
    {
        AcessorioDatabase db = new AcessorioDatabase();

        public int Salvar(AcessorioDTO acessorio)
        {
            if (acessorio.Preco < 1)
            {
                throw new ArgumentException("Preço não pode ser menor que zero");
            }
            return db.Salvar(acessorio);
        }

        public void Alterar (AcessorioDTO acessorio)
        {
            db.Alterar(acessorio);
        }

        public void Remover (int id)
        {
            db.Remover(id);

        }

        public List<AcessorioDTO>Consultar(string acessorio)
        {
            return db.Consultar(acessorio);
        }

        public List<AcessorioDTO> Listar()
        {
            return db.Listar();
        }
    }
}
