using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
 public class PedidoItemDTO
    {
        public int id_pedidoitem { get; set; }
        public int id_pedido { get; set; }
        public int id_instrumento{ get; set; }
        public int id_acessorio { get; set; }
    }
}
