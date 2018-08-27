using AprendendoAUsarPanelHihi.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Instrumento
{
    class InstrumentoDatabase
    {
        public int Salvar(InstrumentoDTO instrumento)
        {
               string script =
               @"INSERT INTO tb_instrumento
                (
                    nm_instrumento,
                    vl_instrumento,
                    id_categoria
                )  
                VALUES
                (
                   @nm_instrumento,
                   @vl_instrumento,
                   @id_categoria
                  )";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_instrumento", instrumento.Nome));
            parms.Add(new MySqlParameter("vl_instrumento", instrumento.Preco));
            parms.Add(new MySqlParameter("id_categoria", instrumento.CategoriaId));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }


    public void Alterar(InstrumentoDTO instrumento)
    {
        string script =
            @"UPDATE tb_instrumento
                  SET nm_instrumento,
                      vl_instrumento,
                      id_categoria
                    WHERE id_instrumento = @id_instrumento";

        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("nm_instrumento", instrumento.Nome));
        parms.Add(new MySqlParameter("vl_instrumento", instrumento.Preco));
        parms.Add(new MySqlParameter("id_categoria", instrumento.CategoriaId));

        Database db = new Database();
        db.ExecuteInsertScript(script, parms);
    }


    public void Remover(int id)
    {
        string script = @"DELETE FROM tb_instrumento WHERE id_instrumento=@id_instrumento";

        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("id_instrumento", id));
        Database db = new Database();
        db.ExecuteInsertScript(script, parms);
    }


        public List<InstrumentoDTO> Consultar(string instrumento)
        {
            string script =
                @"SELECT *
                FROM tb_instrumento
                WHERE nm_instrumento like @nm_instrumento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_instrumento", "%" + instrumento + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<InstrumentoDTO> instrumentos = new List<InstrumentoDTO>();

            while (reader.Read())
            {
                InstrumentoDTO novoinstrumento = new InstrumentoDTO();
                novoinstrumento.Id = reader.GetInt32("id_instrumento");
                novoinstrumento.Nome = reader.GetString("nm_instrumento");
                novoinstrumento.Preco = reader.GetDecimal("vl_instrumento");
                novoinstrumento.CategoriaId = reader.GetInt32("id_categoria");

                instrumentos.Add(novoinstrumento);

            }
            reader.Close();

            return instrumentos;
    }
             public List<InstrumentoDTO> Listar()
        {
            string script =
                @"select *
                FROM tb_instrumento";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<InstrumentoDTO> lista = new List<InstrumentoDTO>();

            while (reader.Read())
            {
                InstrumentoDTO cat = new InstrumentoDTO();
                cat.Id = reader.GetInt32("id_instrumento");
                cat.Nome = reader.GetString("nm_instrumento");
                cat.CategoriaId = reader.GetInt32("id_categoria");
                cat.Preco = reader.GetDecimal("vl_instrumento");


                lista.Add(cat);

            }
            reader.Close();
            return lista;
        }
}
}
