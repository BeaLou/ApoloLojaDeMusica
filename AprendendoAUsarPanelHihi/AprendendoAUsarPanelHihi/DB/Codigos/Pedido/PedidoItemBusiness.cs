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
        public int Salvar(PedidoItemDTO pedidoitem)
        {
            return db.Salvar(pedidoitem);
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
