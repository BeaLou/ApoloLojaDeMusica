using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AprendendoAUsarPanelHihi.DB.Codigos.Pedido;
using AprendendoAUsarPanelHihi.DB.Codigos.Instrumento;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmSalvarPedido : UserControl
    {
        public frmSalvarPedido()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PedidoDTO dto = new PedidoDTO();
            dto.DataVenda = DateTime.Now;
            

            InstrumentoDTO instru = cmbinstrumento.SelectedItem as InstrumentoDTO;

        }
    }
}
