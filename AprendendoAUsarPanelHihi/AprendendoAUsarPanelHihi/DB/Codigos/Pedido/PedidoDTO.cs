using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
    class PedidoDTO
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public string TipoPagto { get; set; }
    }
}
