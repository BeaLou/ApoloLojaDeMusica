namespace AprendendoAUsarPanelHihi.Telas
{
    partial class frmSalvarInstrumento
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
            this.txtInstrumento = new System.Windows.Forms.TextBox();
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.txtprecoI = new System.Windows.Forms.TextBox();
            this.lblPrecoI = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.lblTitulo5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInstrumento
            // 
            this.txtInstrumento.Location = new System.Drawing.Point(289, 186);
            this.txtInstrumento.Name = "txtInstrumento";
            this.txtInstrumento.Size = new System.Drawing.Size(301, 20);
            this.txtInstrumento.TabIndex = 3;
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento.Location = new System.Drawing.Point(106, 173);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(140, 35);
            this.lblInstrumento.TabIndex = 2;
            this.lblInstrumento.Text = "Instrumento:";
            this.lblInstrumento.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtprecoI
            // 
            this.txtprecoI.Location = new System.Drawing.Point(289, 245);
            this.txtprecoI.Name = "txtprecoI";
            this.txtprecoI.Size = new System.Drawing.Size(301, 20);
            this.txtprecoI.TabIndex = 5;
            // 
            // lblPrecoI
            // 
            this.lblPrecoI.AutoSize = true;
            this.lblPrecoI.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoI.Location = new System.Drawing.Point(184, 232);
            this.lblPrecoI.Name = "lblPrecoI";
            this.lblPrecoI.Size = new System.Drawing.Size(74, 35);
            this.lblPrecoI.TabIndex = 4;
            this.lblPrecoI.Text = "Preço:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(134, 294);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(113, 35);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(289, 306);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(301, 21);
            this.cboCategoria.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(635, 368);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 75);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTitulo5
            // 
            this.lblTitulo5.AutoSize = true;
            this.lblTitulo5.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo5.Location = new System.Drawing.Point(255, 52);
            this.lblTitulo5.Name = "lblTitulo5";
            this.lblTitulo5.Size = new System.Drawing.Size(254, 35);
            this.lblTitulo5.TabIndex = 20;
            this.lblTitulo5.Text = "Cadastro de Instrumento";
            // 
            // frmSalvarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitulo5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtprecoI);
            this.Controls.Add(this.lblPrecoI);
            this.Controls.Add(this.txtInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Name = "frmSalvarInstrumento";
            this.Size = new System.Drawing.Size(783, 501);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstrumento;
        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.TextBox txtprecoI;
        private System.Windows.Forms.Label lblPrecoI;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.Label lblTitulo5;
    }
}
