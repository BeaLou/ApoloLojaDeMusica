using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AprendendoAUsarPanelHihi.DB.Codigos.Acessorio;
using AprendendoAUsarPanelHihi.DB.Codigos.Instrumento;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmConsultarInstruAcessorio : UserControl
    {
        Validação v = new Validação();

        public frmConsultarInstruAcessorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cboBuscarCategoria.SelectedText == "Acessório")
            {

                AcessorioBusiness business = new AcessorioBusiness();
                List<AcessorioDTO> a = business.Consultar(txtBusca.Text);
                dgvBuscarAeI.AutoGenerateColumns = false;
                dgvBuscarAeI.DataSource = a;

            }
            else
            {
                InstrumentoBusiness ea = new InstrumentoBusiness();
                List<InstrumentoDTO> f = ea.Consultar(txtBusca.Text);
                dgvBuscarAeI.AutoGenerateColumns = false;
                dgvBuscarAeI.DataSource = f;



            }
        }

        private void dgvBuscarAeI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }
    }
}
