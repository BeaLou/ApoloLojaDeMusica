using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Instrumento
{
    class InstrumentoDTO
    {
        public int Id { get; set; }
        public int CategoriaId{ get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
