using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AprendendoAUsarPanelHihi.DB.Codigos.Cliente;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmLogin : UserControl
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            ClienteBusiness business = new ClienteBusiness();
            bool logou = business.Logar(usuario, senha);
            if(logou == true)
            {
                MessageBox.Show("login efetuado");
            }
            else
            {
                MessageBox.Show("credenciais inválidas");
            }

       

        }
    }
}
