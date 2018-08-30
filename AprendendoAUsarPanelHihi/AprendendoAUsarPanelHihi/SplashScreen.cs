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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            Task.Factory.StartNew(() =>
            {
                // Espera 2 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(6000);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    frmlogininicial frm = new frmlogininicial();
                    frm.Show();
                    Hide();
                }));
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
