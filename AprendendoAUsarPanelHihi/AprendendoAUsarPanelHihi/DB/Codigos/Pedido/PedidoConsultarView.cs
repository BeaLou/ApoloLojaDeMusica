using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
    class PedidoConsultarView
    {
        public int Id { get; set; }

        public string Cliente { get; set; }
        public DateTime Venda { get; set; }
        public string formapagamento { get; set; }
        public int qtd_itens { get; set; }
        public decimal vl_total { get; set; }

    }
}
