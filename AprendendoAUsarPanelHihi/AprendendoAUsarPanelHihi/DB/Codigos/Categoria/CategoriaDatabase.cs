using AprendendoAUsarPanelHihi.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Cliente
{
    class CategoriaDatabase
    {

        public List<CategoriaDTO> Listar()
        {
            string script =
                @"select *
                FROM tb_categoria";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CategoriaDTO> lista = new List<CategoriaDTO>();

            while (reader.Read())
            {
                CategoriaDTO cat = new CategoriaDTO();
                cat.Id = reader.GetInt32("id_categoria");
                cat.Nome = reader.GetString("nm_categoria");

                lista.Add(cat);

            }
            reader.Close();
            return lista;
        }

    }
}
