using AprendendoAUsarPanelHihi.DB.Codigos.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmlogininicial : Form
    {
        public frmlogininicial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuariolog.Text;
            string senha = txtSenhalog.Text;

            ClienteBusiness business = new ClienteBusiness();
            bool logou = business.Logar(usuario, senha);
            if (logou == true)
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
