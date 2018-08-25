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
using AprendendoAUsarPanelHihi.DB.Codigos.Acessorio;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmSalvarAcessorio : UserControl
    {
        public frmSalvarAcessorio()
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CategoriaDTO cat = cboCategoria.SelectedItem as CategoriaDTO;
            AcessorioDTO acess = new AcessorioDTO();
            acess.Nome = txtAcessorio.Text;
            acess.Preco = Convert.ToDecimal(txtPrecoA.Text);
            acess.CategoriaId = cat.Id;

            AcessorioBusiness business = new AcessorioBusiness();
            business.Salvar(acess);
            MessageBox.Show("Acessório salvo com sucesso");

        }
    }
}
