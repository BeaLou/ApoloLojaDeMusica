﻿using System;
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
using AprendendoAUsarPanelHihi.DB.Codigos.Pedido;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class frmSalvarInstrumento : UserControl
    {
        Validação v = new Validação();

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
            try
            {
                CategoriaDTO cat = cboCategoria.SelectedItem as CategoriaDTO;

                InstrumentoDTO inst = new InstrumentoDTO();
                inst.Nome = txtInstrumento.Text;
                inst.Preco = nudPrecoA.Value;
                inst.CategoriaId = cat.Id;

                InstrumentoBusiness business = new InstrumentoBusiness();
                business.Salvar(inst);
                MessageBox.Show("Instrumento salvo com sucesso");
            }
            catch (Exception ex)
            {
                if (txtInstrumento.Text == "")
                {
                    MessageBox.Show("Nome Obrigatório");
                }
                if (nudPrecoA.Value <1 )
                {
                    MessageBox.Show("Valor não pode ser menor que zero");
                }

            }
        }
        private void txtInstrumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void txtprecoI_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void nudPrecoA_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
