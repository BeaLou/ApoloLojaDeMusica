using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
   class PedidoBusiness
    {
        PedidoDatabase db = new PedidoDatabase();
        public int Salvar(PedidoDTO pedido)
        {
            return db.Salvar(pedido);
        }
        public void Alterar(PedidoDTO pedido)
        {
            db.Alterar(pedido);
        }

        public void Remover(int id)
        {
            db.Remover(id);

        }
        public List<PedidoConsultarView> PedidoConsultarView(string pedido)
        {
            return db.Consultar(pedido);
        }

    }
}
