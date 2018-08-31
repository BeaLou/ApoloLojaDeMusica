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

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmConsultarPedido : UserControl
    {
        public frmConsultarPedido()
        {
            InitializeComponent();
        }

        private void frmConsultarPedido_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PedidoBusiness business = new PedidoBusiness();
            List<PedidoConsultarView> a = business.PedidoConsultarView(txtBusca.Text);
            dgvBuscarPedido.AutoGenerateColumns = false;
            dgvBuscarPedido.DataSource = a;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void dgvBuscarPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
