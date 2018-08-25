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

namespace AprendendoAUsarPanelHihi
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Nome = txtNome.Text;
            dto.Sobrenome = txtSobrenome.Text;
            dto.CEP = txtCep.Text;
            dto.CPF = txtCpf.Text;
            dto.NumeroCasa = txtncasa.Text;
            dto.Complemento = txtComplemento.Text;
            dto.Email = txtEmail.Text;
            dto.Usuario = txtUser.Text;
            dto.Senha = txtSenha.Text;

            ClienteBusiness business = new ClienteBusiness();
            business.Salvar(dto);

            MessageBox.Show("Cadastro Feito com sucesso!");






        }
    }
}
