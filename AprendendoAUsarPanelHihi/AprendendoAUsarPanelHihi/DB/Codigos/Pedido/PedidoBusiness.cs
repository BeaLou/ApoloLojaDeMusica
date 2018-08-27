using AprendendoAUsarPanelHihi.DB.Codigos.Acessorio;
using AprendendoAUsarPanelHihi.DB.Codigos.Instrumento;
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
        public int Salvar(PedidoDTO pedido, List <InstrumentoDTO> instrumento, List<AcessorioDTO> acessorio)
        {
            int idpedido = db.Salvar(pedido);

            PedidoItemBusiness itembusiness = new PedidoItemBusiness();
            foreach (InstrumentoDTO item in instrumento)
            {
                PedidoItemDTO itemdto = new PedidoItemDTO();
                itemdto.id_pedido = idpedido;
                itemdto.id_instrumento = item.Id;

                itembusiness.SalvarInstrumento(itemdto);
            }
            foreach (AcessorioDTO item in acessorio)
            {
                PedidoItemDTO itemdto2 = new PedidoItemDTO();
                itemdto2.id_pedido = idpedido;
                itemdto2.id_acessorio = item.Id;

                itembusiness.SalvarAcessorio(itemdto2);
            }


            return idpedido;

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
