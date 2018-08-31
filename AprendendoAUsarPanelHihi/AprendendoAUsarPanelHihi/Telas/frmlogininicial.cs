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
            ClienteBusiness business = new ClienteBusiness();
            ClienteDTO cliente = business.Logar(txtUsuariolog.Text, txtSenhalog.Text);
            if(cliente != null)
            {
                UserSession.Usuariologado = cliente;
                ApoloStore frm = new ApoloStore();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas.");
            }
           




        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCliente cliente = new CadastrarCliente();
            cliente.ShowDialog();
            this.Hide();
        }
    }
}
