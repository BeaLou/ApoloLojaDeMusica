using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Cliente
{
    class CategoriaBusiness
    {
        CategoriaDatabase db = new CategoriaDatabase();

        public List<CategoriaDTO> Listar()
        {
            return db.Listar();
        }

    }
}
