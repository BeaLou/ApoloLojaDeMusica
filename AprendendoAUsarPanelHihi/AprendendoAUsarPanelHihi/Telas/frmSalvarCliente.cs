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

namespace AprendendoAUsarPanelHihi
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();
        }
    }
}
