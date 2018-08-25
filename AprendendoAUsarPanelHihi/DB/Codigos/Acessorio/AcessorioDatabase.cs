using AprendendoAUsarPanelHihi.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Acessorio
{
    public class AcessorioDatabase
    {
        public int Salvar (AcessorioDTO acessorio)
        {
            string script =
                @"INSERT INTO tb_acessorio
                  ( 
                    nm_acessorio,
                    vl_acessorio
                  )

                  VALUES
                  (
                    @nm_acessorio,
                    @vl_acessorio
                   )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_acessorio", acessorio.Nome));
            parms.Add(new MySqlParameter("vl_acessorio", acessorio.Preco));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar (AcessorioDTO acessorio)
        {
            string script = @"UPDATE tb_acessorio
                           SET nm_acessorio = @nm_acessorio
                                vl_acessorio=@vl_acessorio";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_acessorio", acessorio.Nome));
            parms.Add(new MySqlParameter("vl_acessorio", acessorio.Preco));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover (int id)
        {
            string script =@"DELETE FROM tb_acessorios WHERE id_acessorios =@id_acessorios";
            
            List<MySqlParameter>parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_acessorios",id));

            Database db= new Database ();
            db.ExecuteInsertScript(script,parms);
        }

        public List<AcessorioDTO> Consultar(string acessorio)
        {
            string script =
                @"SELECT *
                  FROM tb_acessorio   
                  WHERE nm_acessorio like @nm_acessorio
                  WHERE vl_acessorio like @vl_acessorio";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_acessorio", "%" + acessorio + "%"));
            parms.Add(new MySqlParameter("vl_acessorio", "%" + acessorio + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<AcessorioDTO> acessorios = new List<AcessorioDTO>();

            while (reader.Read())
            {
                AcessorioDTO novoacessorio = new AcessorioDTO();
                novoacessorio.Id = reader.GetInt32("id_acessorio");
                novoacessorio.Nome = reader.GetString("nm_acessorio");
                novoacessorio.Preco = reader.GetDecimal("vl_acessorio");

                acessorios.Add(novoacessorio);
            }
            reader.Close();

            return acessorios;

        }

    }
}
