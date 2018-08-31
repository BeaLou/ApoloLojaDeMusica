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
using AprendendoAUsarPanelHihi.DB.Codigos.Acessorio;
using AprendendoAUsarPanelHihi.DB.Codigos.Cliente;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmSalvarPedido : UserControl
    {
        Validação v = new Validação();
        public frmSalvarPedido()
        {
            InitializeComponent();
            CarregarCombos();

            dgvInstrumentos.AutoGenerateColumns = false;
            dgvInstrumentos.DataSource = instrumentos;

            dgvacessorio.AutoGenerateColumns = false;
            dgvacessorio.DataSource = acessorio;
         


        }


        void CarregarCombos()
        {
            InstrumentoBusiness bus = new InstrumentoBusiness();
            List<InstrumentoDTO> lista = bus.Listar();

            cmbinstrumento.DisplayMember = nameof(InstrumentoDTO.Nome);
            cmbinstrumento.ValueMember = nameof(InstrumentoDTO.Id);
            cmbinstrumento.DataSource = lista;

            AcessorioBusiness acs = new AcessorioBusiness();
            List<AcessorioDTO> list = acs.Listar();
            cmbacessorio.DisplayMember = nameof(AcessorioDTO.Nome);
            cmbacessorio.ValueMember = nameof(AcessorioDTO.Id);
            cmbacessorio.DataSource = list;

        }
        BindingList<InstrumentoDTO> instrumentos = new BindingList<InstrumentoDTO>();
        BindingList<AcessorioDTO> acessorio = new BindingList<AcessorioDTO>();

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
            dto.TipoPagto = cboPagto.Text;

            PedidoBusiness business = new PedidoBusiness();
            business.Salvar(dto, instrumentos.ToList(), acessorio.ToList());

            MessageBox.Show("Pedido salvo com sucesso");

            

 
        }

        private void cmbinstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InstrumentoDTO instru = cmbinstrumento.SelectedItem as InstrumentoDTO;
            for (int i = 0; i < Convert.ToInt32(txtquantidade.Text); i++)
            {
                instrumentos.Add(instru);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AcessorioDTO acessp = cmbacessorio.SelectedItem as AcessorioDTO;

            for (int i = 0; i < Convert.ToInt32(txtquantidadeA.Text); i++)
            {
                acessorio.Add(acessp);
            }
        }

        private void txtnmcliente_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtquantidadeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }
    }
}
