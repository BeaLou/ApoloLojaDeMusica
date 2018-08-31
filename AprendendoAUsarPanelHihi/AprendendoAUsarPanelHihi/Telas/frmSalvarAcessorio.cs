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
        Validação v = new Validação();

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
            try
            {
                CategoriaDTO cat = cboCategoria.SelectedItem as CategoriaDTO;
                AcessorioDTO acess = new AcessorioDTO();
                acess.Nome = txtAcessorio.Text;
                acess.Preco = nudPrecoI.Value;
                acess.CategoriaId = cat.Id;

                AcessorioBusiness business = new AcessorioBusiness();
                business.Salvar(acess);
                MessageBox.Show("Acessório salvo com sucesso");
            }
            catch(Exception ex)
            {
                if(txtAcessorio.Text == "")
                {
                    MessageBox.Show("Nome Obrigatório");
                }
               
                else if(nudPrecoI.Value <1)
                {
                    MessageBox.Show("Valor não pode ser menor que zero");
                }

            }
            

        }

        private void txtAcessorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAcessorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void txtPrecoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }
    }
}
