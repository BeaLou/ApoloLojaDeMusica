using AprendendoAUsarPanelHihi.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Cliente
{
    class ClienteDatabase
    {
        public int Salvar(ClienteDTO cliente)
        {
            string script =
            @"INSERT INTO tb_cliente
            (
                nm_cliente,
                nm_sobrenome,
                ds_CPF,
                ds_CEP,
                nm_usuario,
                ds_senha,
                nr_casa,
                ds_complemento,
                ds_email
            )
             VALUES
            (
               @nm_cliente,
               @nm_sobrenome,
               @ds_CPF,
               @ds_CEP,
               @nm_usuario,
               @ds_senha,
               @nr_casa,
               @ds_complemento,
               @ds_email)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", cliente.Nome));
            parms.Add(new MySqlParameter("nm_sobrenome", cliente.Sobrenome));
            parms.Add(new MySqlParameter("ds_CPF", cliente.CPF));
            parms.Add(new MySqlParameter("ds_CEP", cliente.CEP));
            parms.Add(new MySqlParameter("nm_usuario", cliente.Usuario));
            parms.Add(new MySqlParameter("ds_senha", cliente.Senha));
            parms.Add(new MySqlParameter("nr_casa", cliente.Casa));
            parms.Add(new MySqlParameter("ds_complemento", cliente.Complemento));
            parms.Add(new MySqlParameter("ds_email", cliente.Email));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public List<ClienteDTO> Consultar(string cliente)
        {
            string script =
                @"select *
                FROM tb_cliente
                WHERE nm_cliente like @nm_cliente
                WHERE nm_sobrenome like @nm_sobrenome
                WHERE ds_CPF like @ds_CPF
                WHERE ds_CEP like @ds_CEP
                WHERE nm_usuario like @nm_usuario
                WHERE ds_senha like @ds_senha
                WHERE nr_casa like @nr_casa
                WHERE ds_complemento like @ds_complemento
                WHERE ds_email like @ds_email";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", "%" + cliente + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> novocliente = new List<ClienteDTO>();

            while (reader.Read())
            {
                ClienteDTO novo = new ClienteDTO();
                novo.Id = reader.GetInt32("id_cliente");
                novo.Nome = reader.GetString("nm_cliente");
                novo.Sobrenome = reader.GetString("nm_sobrenome");
                novo.CPF = reader.GetString("ds_CPF");
                novo.CEP = reader.GetString("ds_CEP");
                novo.Usuario = reader.GetString("nm_usuario");
                novo.Senha = reader.GetString("ds_senha");
                novo.Casa = reader.GetString("nr_casa");
                novo.Complemento = reader.GetString("ds_complemento");
                novo.Email = reader.GetString("ds_email");
                novocliente.Add(novo);

            }
            reader.Close();
            return novocliente;
        }

        public void Alterar(ClienteDTO cliente)
        {
            string script =
                @"UPDATE tb_cliente
                SET nm_cliente = @nm_cliente,
                    nm_sobrenome=@nm_sobrenome,
                    ds_CPF=@ds_CPF,
                    ds_CEP=@ds_CEP,
                    nm_usuario=@nm_usuario,
                    ds_senha=@ds_senha,
                    nr_casa=@nr_casa,
                    ds_complemento=@ds_complemento,
                    ds_email=@ds_email,
               WHERE id_cliente = @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", cliente.Id));
            parms.Add(new MySqlParameter("nm_cliente", cliente.Nome));
            parms.Add(new MySqlParameter("nm_sobrenome", cliente.Sobrenome));
            parms.Add(new MySqlParameter("ds_CPF", cliente.CPF));
            parms.Add(new MySqlParameter("nm_usuario", cliente.Usuario));
            parms.Add(new MySqlParameter("ds_senha", cliente.Senha));
            parms.Add(new MySqlParameter("nr_casa", cliente.Casa));
            parms.Add(new MySqlParameter("ds_complemento", cliente.Complemento));
            parms.Add(new MySqlParameter("ds_email", cliente.Email));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_cliente WHERE id_cliente=@id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
