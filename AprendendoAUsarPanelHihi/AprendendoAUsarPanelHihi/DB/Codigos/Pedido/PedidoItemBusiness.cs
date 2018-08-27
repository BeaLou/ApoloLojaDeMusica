using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
    class PedidoItemBusiness
    {
        PedidoItemDatabase db = new PedidoItemDatabase();
      public int SalvarInstrumento(PedidoItemDTO pedidoitem)
        {
            return db.SalvarInstrumento(pedidoitem);
        }
        public int SalvarAcessorio(PedidoItemDTO pedidoitem)
        {
            return db.SalvarAcessorio(pedidoitem);
        }


        public void Alterar(PedidoItemDTO pedidoitem)
        {
            db.Alterar(pedidoitem);
        }

        public void Remover(int id)
        {
            db.Remover(id);

        }
        public List<PedidoItemDTO> Consultar(string pedidoteim)
        {
            return db.Consultar(pedidoteim);
        }
    }
}
