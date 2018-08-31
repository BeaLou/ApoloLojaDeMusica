using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Codigos.Cliente
{
    class ClienteBusiness
    {
        ClienteDatabase db = new ClienteDatabase();

        public int Salvar(ClienteDTO cliente)
        {
            

            return db.Salvar(cliente);

        }
        public void Alterar(ClienteDTO cliente)
        {
            db.Alterar(cliente);
        }

        public void Remover(int id)
        {
            db.Remover(id);

        }
        public List<ClienteDTO> Consultar(string cliente)
        {
            return db.Consultar(cliente);
        }
        public ClienteDTO Logar(string usuario, string senha)
        {
            if (usuario == string.Empty)
            {
                throw new ArgumentException("Usuário é obrigatório");
            }
            if (senha == string.Empty)
            {
                throw new ArgumentException("Senha é obrigatória");
            }
            return db.Logar(usuario, senha);
        }


    }
}
