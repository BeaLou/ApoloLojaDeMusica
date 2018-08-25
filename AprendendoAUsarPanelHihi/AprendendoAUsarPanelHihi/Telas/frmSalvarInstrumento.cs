using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AprendendoAUsarPanelHihi.DB.Codigos.Instrumento;
using AprendendoAUsarPanelHihi.DB.Codigos.Cliente;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmSalvarInstrumento : UserControl
    {
        public frmSalvarInstrumento()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            CategoriaBusiness bus = new CategoriaBusiness();
            List<CategoriaDTO> lista = bus.Listar();

            cboCategoria.DisplayMember = nameof(CategoriaDTO.Nome);
            cboCategoria.ValueMember = nameof(CategoriaDTO.Id);
            cboCategoria.DataSource = lista;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CategoriaDTO cat = cboCategoria.SelectedItem as CategoriaDTO;

            InstrumentoDTO inst = new InstrumentoDTO();
            inst.Nome = "";
            inst.Preco = 0;
            inst.CategoriaId = cat.Id;

            
        }
    }
}
