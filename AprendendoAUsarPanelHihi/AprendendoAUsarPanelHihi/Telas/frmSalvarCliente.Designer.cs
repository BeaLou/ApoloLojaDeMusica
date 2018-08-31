namespace AprendendoAUsarPanelHihi
{
    partial class frmCadastrar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtncasa = new System.Windows.Forms.TextBox();
            this.lblNmrCasa = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtbcep = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(98, 130);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(101, 33);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(204, 143);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(204, 189);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(184, 20);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSobrenome_KeyPress);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(26, 175);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(173, 33);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(116, 224);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(81, 33);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(116, 274);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(82, 33);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(204, 375);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(184, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(-6, 362);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(205, 33);
            this.lblComp.TabIndex = 8;
            this.lblComp.Text = "Complemento:";
            // 
            // txtncasa
            // 
            this.txtncasa.Location = new System.Drawing.Point(204, 331);
            this.txtncasa.Name = "txtncasa";
            this.txtncasa.Size = new System.Drawing.Size(184, 20);
            this.txtncasa.TabIndex = 5;
            this.txtncasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtncasa_KeyPress);
            // 
            // lblNmrCasa
            // 
            this.lblNmrCasa.AutoSize = true;
            this.lblNmrCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrCasa.Location = new System.Drawing.Point(32, 318);
            this.lblNmrCasa.Name = "lblNmrCasa";
            this.lblNmrCasa.Size = new System.Drawing.Size(165, 33);
            this.lblNmrCasa.TabIndex = 10;
            this.lblNmrCasa.Text = "Nº da casa:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(533, 237);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(184, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(421, 224);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(106, 33);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(533, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(430, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 33);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(533, 143);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(184, 20);
            this.txtUser.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(403, 130);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(124, 33);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconSalvar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(673, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo4.Location = new System.Drawing.Point(258, 53);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(315, 33);
            this.lblTitulo4.TabIndex = 21;
            this.lblTitulo4.Text = "Cadastrar novo cliente:";
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(204, 237);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(184, 20);
            this.mtbcpf.TabIndex = 3;
            this.mtbcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbcpf_KeyPress);
            // 
            // txtcpf
            // 
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(61, 4);
            // 
            // mtbcep
            // 
            this.mtbcep.Location = new System.Drawing.Point(204, 286);
            this.mtbcep.Mask = "0000000-000";
            this.mtbcep.Name = "mtbcep";
            this.mtbcep.Size = new System.Drawing.Size(184, 20);
            this.mtbcep.TabIndex = 4;
            this.mtbcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbcep_KeyPress);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mtbcep);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.lblTitulo4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtncasa);
            this.Controls.Add(this.lblNmrCasa);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastrar";
            this.Size = new System.Drawing.Size(783, 501);
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.TextBox txtncasa;
        private System.Windows.Forms.Label lblNmrCasa;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo4;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.ContextMenuStrip txtcpf;
        private System.Windows.Forms.MaskedTextBox mtbcep;
    }
}
