namespace AprendendoAUsarPanelHihi.Telas
{
    partial class frmlogininicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtSenhalog = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuariolog = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(282, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(73, 35);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Login";
            // 
            // txtSenhalog
            // 
            this.txtSenhalog.Location = new System.Drawing.Point(196, 235);
            this.txtSenhalog.Name = "txtSenhalog";
            this.txtSenhalog.Size = new System.Drawing.Size(243, 20);
            this.txtSenhalog.TabIndex = 28;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(-125, 122);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(82, 35);
            this.lblSenha.TabIndex = 27;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuariolog
            // 
            this.txtUsuariolog.Location = new System.Drawing.Point(196, 164);
            this.txtUsuariolog.Name = "txtUsuariolog";
            this.txtUsuariolog.Size = new System.Drawing.Size(243, 20);
            this.txtUsuariolog.TabIndex = 26;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(-143, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 35);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Usuario:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(529, 302);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 75);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 35);
            this.label2.TabIndex = 31;
            this.label2.Text = "Usuario:";
            // 
            // frmlogininicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSenhalog);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuariolog);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogininicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogininicial";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuariolog;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSenhalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}