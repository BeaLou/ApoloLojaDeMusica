using AprendendoAUsarPanelHihi.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
    public class PedidoDatabase
    {
        public int Salvar(PedidoDTO pedido)
        {
            string script =
                @"INSERT INTO tb_pedido
                (
                    id_cliente,
                    dt_venda,
                    ds_formapagamento
                )  
                VALUES
                (
                   @id_cliente,
                   @dt_venda,
                   @ds_formapamento
                  )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", pedido.Cliente));
            parms.Add(new MySqlParameter("dt_venda", pedido.DataVenda));
            parms.Add(new MySqlParameter("ds_formapagamento", pedido.TipoPagto));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }


        public void Alterar(PedidoDTO pedido)
        {
            string script =
                @"UPDATE tb_pedido
                  SET id_cliente,
                      dt_venda,
                      ds_formapagamento
                    WHERE id_pedido = @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", pedido.Cliente));
            parms.Add(new MySqlParameter("dt_venda", pedido.DataVenda));
            parms.Add(new MySqlParameter("ds_formapagamento", pedido.TipoPagto));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_pedido WHERE id_pedido=@id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", id));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<PedidoConsultarView> Consultar(string pedido)
        {
            string script =
                @"SELECT * FROM vw_pedido_consultar WHERE nm_pedido like @nm_pedido";
              
                
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_pedido", "%" + pedido + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoConsultarView> pedidos = new List<PedidoConsultarView>();
            while (reader.Read())
            {
                PedidoConsultarView novopedido = new PedidoConsultarView();
                novopedido.Id = reader.GetInt32("id_pedido");
                novopedido.Instrumento = reader.GetString("nm_instrumento");
                novopedido.Acessório = reader.GetString("nm_acessorio");
                novopedido.Clientes = reader.GetString("nm_cliente");
               pedidos.Add(novopedido);
            }
            reader.Close();

            return pedidos;

        }

    }
}
