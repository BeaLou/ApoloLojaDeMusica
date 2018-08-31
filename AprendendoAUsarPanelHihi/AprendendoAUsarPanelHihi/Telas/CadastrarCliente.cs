using AprendendoAUsarPanelHihi.DB.Codigos.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoAUsarPanelHihi.Telas
{
    public partial class CadastrarCliente : Form
    {
        Validação v = new Validação();
        public CadastrarCliente()
        {
            InitializeComponent();
            
                    // Abre a tela Inicial
                    frmlogininicial frm = new frmlogininicial();
                    frm.Show();
                    

        }
       

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Nome = txtNome.Text;
            dto.Sobrenome = txtSobrenome.Text;
            dto.CEP = mtbcep.Text;
            dto.CPF = mtbcpf.Text;
            dto.NumeroCasa = txtncasa.Text;
            dto.Complemento = txtComplemento.Text;
            dto.Email = txtEmail.Text;
            dto.Usuario = txtUser.Text;
            dto.Senha = txtSenha.Text;

            ClienteBusiness business = new ClienteBusiness();
            business.Salvar(dto);

            MessageBox.Show("Cadastro Feito com sucesso!");

        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soletras(e);
        }

        private void mtbcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void mtbcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void txtncasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sonumeros(e);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Nome = txtNome.Text;
            dto.Sobrenome = txtSobrenome.Text;
            dto.CEP = mtbcep.Text;
            dto.CPF = mtbcpf.Text;
            dto.NumeroCasa = txtncasa.Text;
            dto.Complemento = txtComplemento.Text;
            dto.Email = txtEmail.Text;
            dto.Usuario = txtUser.Text;
            dto.Senha = txtSenha.Text;

            ClienteBusiness business = new ClienteBusiness();
            business.Salvar(dto);

            MessageBox.Show("Cadastro Feito com sucesso!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmlogininicial l = new frmlogininicial();
            l.ShowDialog();

        }
    }
}
