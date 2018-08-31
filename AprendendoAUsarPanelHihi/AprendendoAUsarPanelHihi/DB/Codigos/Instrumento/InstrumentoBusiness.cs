using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Instrumento
{
    class InstrumentoBusiness
    {
        InstrumentoDatabase db = new InstrumentoDatabase();
        public int Salvar(InstrumentoDTO instrumento)
        {
            if (instrumento.Preco < 1)
            {
                throw new ArgumentException("Preço não pode ser menor que zero");
            }

            return db.Salvar(instrumento);
        }
        public void Alterar(InstrumentoDTO instrumento)
        {
            db.Alterar(instrumento);
        }

        public void Remover(int id)
        {
            db.Remover(id);

        }
        public List<InstrumentoDTO> Consultar(string instrumento)
        {
            return db.Consultar(instrumento);
        }
        public List<InstrumentoDTO> Listar()
        {
            return db.Listar();
        }

    }
}
