using AprendendoAUsarPanelHihi.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Pedido
{
   public class PedidoItemDatabase
    {
        public int SalvarAcessorio(PedidoItemDTO pedidoitem)
        {
            string script =
            @"INSERT INTO tb_pedidoitem
                (
                    id_pedido,
                    
                    id_acessorio
                )  
                VALUES
                (
                   @id_pedido,
                   
                   @id_acessorio
                  )";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido",pedidoitem.id_pedido));
            
            parms.Add(new MySqlParameter("id_acessorio", pedidoitem.id_acessorio));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public int SalvarInstrumento(PedidoItemDTO pedidoitem)
        {
            string script =
            @"INSERT INTO tb_pedidoitem
                (
                    id_pedido,
                    id_instrumento
                    
                )  
                VALUES
                (
                   @id_pedido,
                   @id_instrumento
                   
                  )";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", pedidoitem.id_pedido));
            parms.Add(new MySqlParameter("id_instrumento", pedidoitem.id_instrumento));
          

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }


        public void Alterar(PedidoItemDTO pedidoitem)
        {
            string script =
                @"UPDATE tb_pedidoitem
                  SET id_pedido,
                      id_instrumento,
                      id_acessorio
                    WHERE id_pedidoitem = @id_pedidoitem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", pedidoitem.id_pedido));
            parms.Add(new MySqlParameter("id_instrumento", pedidoitem.id_instrumento));
            parms.Add(new MySqlParameter("id_acessorio", pedidoitem.id_acessorio));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_pedidoitem WHERE id_pedidoitem=@id_pedidoitem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedidoitem", id));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<PedidoItemDTO> Consultar(string instrumento)
        {
            string script =
                @"SELECT *
                FROM tb_pedidoitem
                WHERE id_pedido like @id_pedido
                WHERE id_instrumento like @id_instrumento
                WHERE id_acessorio like @id_acessorio";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("", "%" + instrumento  + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoItemDTO> pedidoitens= new List<PedidoItemDTO>();

            while (reader.Read())
            {
                PedidoItemDTO novoinstrumento = new PedidoItemDTO();
                novoinstrumento.id_pedido = reader.GetInt32("id_pedido");
                novoinstrumento.id_instrumento= reader.GetInt32("id_instrumento");
                novoinstrumento.id_acessorio= reader.GetInt32("id_acessorio");
                novoinstrumento.id_pedidoitem= reader.GetInt32("id_pedidoitem");

                pedidoitens.Add(novoinstrumento);

            }
            reader.Close();

            return pedidoitens;

        }
    }
}
