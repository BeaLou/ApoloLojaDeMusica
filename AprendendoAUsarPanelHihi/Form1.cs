using AprendendoAUsarPanelHihi.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoAUsarPanelHihi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (panelInicio.Controls.Count == 1)
            {
                panelInicio.Controls.RemoveAt(0);
            }


            frmSalvarAcessorio tela = new frmSalvarAcessorio();
            panelInicio.Controls.Add(tela);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panelInicio.Controls.Count == 1)
                {
                panelInicio.Controls.RemoveAt(0);
            }


            frmCadastrar tela = new frmCadastrar();
            panelInicio.Controls.Add(tela);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
             
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (panelInicio.Controls.Count == 1)
            {
                panelInicio.Controls.RemoveAt(0);
            }


            frmSalvarPedido tela = new frmSalvarPedido();
            panelInicio.Controls.Add(tela);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (panelInicio.Controls.Count == 1)
            {
                panelInicio.Controls.RemoveAt(0);
            }


            frmConsultarPedido tela = new frmConsultarPedido();
            panelInicio.Controls.Add(tela);
        }

        private void btnCordas_Click(object sender, EventArgs e)
        {
            if (panelInicio.Controls.Count == 1)
            {
                panelInicio.Controls.RemoveAt(0);
            }


            frmSalvarInstrumento tela = new frmSalvarInstrumento();
            panelInicio.Controls.Add(tela);
        }

        private void btnPercussao_Click(object sender, EventArgs e)
        {
            if (panelInicio.Controls.Count == 1)
            {
                panelInicio.Controls.RemoveAt(0);
            }
            frmConsultarInstruAcessorio tela = new frmConsultarInstruAcessorio();
            panelInicio.Controls.Add(tela);



        }

        private void btnSopro_Click(object sender, EventArgs e)
        {
            if (panelInicio.Controls.Count == 1)
            {
                panelInicio.Controls.RemoveAt(0);
            }
            frmLogin tela = new frmLogin();
            panelInicio.Controls.Add(tela);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
