﻿namespace AprendendoAUsarPanelHihi.Telas
{
    partial class frmSalvarAcessorio
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
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtPrecoA = new System.Windows.Forms.TextBox();
            this.lblPrecoA = new System.Windows.Forms.Label();
            this.txtAcessorio = new System.Windows.Forms.TextBox();
            this.lblAcessorio = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(257, 296);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(301, 21);
            this.cboCategoria.TabIndex = 25;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(121, 283);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(113, 35);
            this.lblCategoria.TabIndex = 24;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtPrecoA
            // 
            this.txtPrecoA.Location = new System.Drawing.Point(257, 237);
            this.txtPrecoA.Name = "txtPrecoA";
            this.txtPrecoA.Size = new System.Drawing.Size(301, 20);
            this.txtPrecoA.TabIndex = 23;
            // 
            // lblPrecoA
            // 
            this.lblPrecoA.AutoSize = true;
            this.lblPrecoA.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoA.Location = new System.Drawing.Point(158, 222);
            this.lblPrecoA.Name = "lblPrecoA";
            this.lblPrecoA.Size = new System.Drawing.Size(74, 35);
            this.lblPrecoA.TabIndex = 22;
            this.lblPrecoA.Text = "Preço:";
            // 
            // txtAcessorio
            // 
            this.txtAcessorio.Location = new System.Drawing.Point(257, 175);
            this.txtAcessorio.Name = "txtAcessorio";
            this.txtAcessorio.Size = new System.Drawing.Size(301, 20);
            this.txtAcessorio.TabIndex = 21;
            // 
            // lblAcessorio
            // 
            this.lblAcessorio.AutoSize = true;
            this.lblAcessorio.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcessorio.Location = new System.Drawing.Point(121, 163);
            this.lblAcessorio.Name = "lblAcessorio";
            this.lblAcessorio.Size = new System.Drawing.Size(111, 35);
            this.lblAcessorio.TabIndex = 20;
            this.lblAcessorio.Text = "Acessório:";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(263, 84);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(251, 35);
            this.lblTitulo3.TabIndex = 27;
            this.lblTitulo3.Text = "Cadastrar novo acessório:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(655, 372);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 75);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.TabStop = false;
            // 
            // frmSalvarAcessorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtPrecoA);
            this.Controls.Add(this.lblPrecoA);
            this.Controls.Add(this.txtAcessorio);
            this.Controls.Add(this.lblAcessorio);
            this.Name = "frmSalvarAcessorio";
            this.Size = new System.Drawing.Size(783, 501);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtPrecoA;
        private System.Windows.Forms.Label lblPrecoA;
        private System.Windows.Forms.TextBox txtAcessorio;
        private System.Windows.Forms.Label lblAcessorio;
        private System.Windows.Forms.Label lblTitulo3;
    }
}
