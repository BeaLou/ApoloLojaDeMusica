namespace AprendendoAUsarPanelHihi.Telas
{
    partial class frmConsultarInstruAcessorio
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblBuscaCategoria = new System.Windows.Forms.Label();
            this.cboBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.dgvBuscarAeI = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarAeI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(151, 110);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(480, 20);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(41, 97);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(104, 33);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Busca:";
            // 
            // lblBuscaCategoria
            // 
            this.lblBuscaCategoria.AutoSize = true;
            this.lblBuscaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCategoria.Location = new System.Drawing.Point(77, 141);
            this.lblBuscaCategoria.Name = "lblBuscaCategoria";
            this.lblBuscaCategoria.Size = new System.Drawing.Size(68, 33);
            this.lblBuscaCategoria.TabIndex = 4;
            this.lblBuscaCategoria.Text = "Por:";
            // 
            // cboBuscarCategoria
            // 
            this.cboBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarCategoria.FormattingEnabled = true;
            this.cboBuscarCategoria.Items.AddRange(new object[] {
            "Instrumento",
            "Acessório"});
            this.cboBuscarCategoria.Location = new System.Drawing.Point(151, 153);
            this.cboBuscarCategoria.Name = "cboBuscarCategoria";
            this.cboBuscarCategoria.Size = new System.Drawing.Size(480, 21);
            this.cboBuscarCategoria.TabIndex = 2;
            // 
            // dgvBuscarAeI
            // 
            this.dgvBuscarAeI.AllowUserToAddRows = false;
            this.dgvBuscarAeI.AllowUserToDeleteRows = false;
            this.dgvBuscarAeI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarAeI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvBuscarAeI.Location = new System.Drawing.Point(32, 201);
            this.dgvBuscarAeI.Name = "dgvBuscarAeI";
            this.dgvBuscarAeI.ReadOnly = true;
            this.dgvBuscarAeI.Size = new System.Drawing.Size(599, 239);
            this.dgvBuscarAeI.TabIndex = 6;
            this.dgvBuscarAeI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarAeI_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Preco";
            this.Column2.HeaderText = "Preco";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(226, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(459, 33);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Buscar Acessórios e Instrumentos";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconBusca;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(676, 365);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 75);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsultarInstruAcessorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvBuscarAeI);
            this.Controls.Add(this.cboBuscarCategoria);
            this.Controls.Add(this.lblBuscaCategoria);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblBuscar);
            this.Name = "frmConsultarInstruAcessorio";
            this.Size = new System.Drawing.Size(783, 501);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarAeI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblBuscaCategoria;
        private System.Windows.Forms.ComboBox cboBuscarCategoria;
        private System.Windows.Forms.DataGridView dgvBuscarAeI;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
