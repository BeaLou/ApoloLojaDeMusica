using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
   public class PedidoDTO
    {
        public int Pedido { get; set; }
        public int Cliente{ get; set; }
        public DateTime DataVenda { get; set; }
        public string TipoPagto { get; set; }
    }
}
