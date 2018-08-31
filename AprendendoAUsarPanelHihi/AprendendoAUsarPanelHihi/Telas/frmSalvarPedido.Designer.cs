namespace AprendendoAUsarPanelHihi.Telas
{
    partial class frmSalvarPedido
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
            this.cmbinstrumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbacessorio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvInstrumentos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPagto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnmcliente = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtquantidadeA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvacessorio = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvacessorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 112);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(177, 33);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Instrumento:";
            // 
            // cmbinstrumento
            // 
            this.cmbinstrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbinstrumento.FormattingEnabled = true;
            this.cmbinstrumento.Location = new System.Drawing.Point(216, 124);
            this.cmbinstrumento.Name = "cmbinstrumento";
            this.cmbinstrumento.Size = new System.Drawing.Size(272, 21);
            this.cmbinstrumento.TabIndex = 1;
            this.cmbinstrumento.SelectedIndexChanged += new System.EventHandler(this.cmbinstrumento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade:";
            // 
            // cmbacessorio
            // 
            this.cmbacessorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbacessorio.FormattingEnabled = true;
            this.cmbacessorio.Location = new System.Drawing.Point(216, 284);
            this.cmbacessorio.Name = "cmbacessorio";
            this.cmbacessorio.Size = new System.Drawing.Size(272, 21);
            this.cmbacessorio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Acessório:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cliente:";
            // 
            // dgvInstrumentos
            // 
            this.dgvInstrumentos.AllowUserToAddRows = false;
            this.dgvInstrumentos.AllowUserToDeleteRows = false;
            this.dgvInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvInstrumentos.Location = new System.Drawing.Point(494, 127);
            this.dgvInstrumentos.Name = "dgvInstrumentos";
            this.dgvInstrumentos.ReadOnly = true;
            this.dgvInstrumentos.Size = new System.Drawing.Size(286, 116);
            this.dgvInstrumentos.TabIndex = 14;
            this.dgvInstrumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Column2.HeaderText = "Preço";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cboPagto
            // 
            this.cboPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagto.FormattingEnabled = true;
            this.cboPagto.Items.AddRange(new object[] {
            "Drébito",
            "Crébito",
            "Boleto"});
            this.cboPagto.Location = new System.Drawing.Point(216, 438);
            this.cboPagto.Name = "cboPagto";
            this.cboPagto.Size = new System.Drawing.Size(272, 21);
            this.cboPagto.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 33);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pagamento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconSalvar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(702, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pedido";
            // 
            // txtnmcliente
            // 
            this.txtnmcliente.Location = new System.Drawing.Point(216, 465);
            this.txtnmcliente.Name = "txtnmcliente";
            this.txtnmcliente.Size = new System.Drawing.Size(272, 20);
            this.txtnmcliente.TabIndex = 6;
            this.txtnmcliente.TextChanged += new System.EventHandler(this.txtnmcliente_TextChanged);
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(216, 151);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(272, 20);
            this.txtquantidade.TabIndex = 2;
            this.txtquantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidade_KeyPress);
            // 
            // txtquantidadeA
            // 
            this.txtquantidadeA.Location = new System.Drawing.Point(216, 311);
            this.txtquantidadeA.Name = "txtquantidadeA";
            this.txtquantidadeA.Size = new System.Drawing.Size(272, 20);
            this.txtquantidadeA.TabIndex = 4;
            this.txtquantidadeA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidadeA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 26;
            this.label4.Text = "Instrumento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 33);
            this.label5.TabIndex = 28;
            this.label5.Text = "Acessorio";
            // 
            // dgvacessorio
            // 
            this.dgvacessorio.AllowUserToAddRows = false;
            this.dgvacessorio.AllowUserToDeleteRows = false;
            this.dgvacessorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvacessorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvacessorio.Location = new System.Drawing.Point(494, 284);
            this.dgvacessorio.Name = "dgvacessorio";
            this.dgvacessorio.ReadOnly = true;
            this.dgvacessorio.Size = new System.Drawing.Size(286, 116);
            this.dgvacessorio.TabIndex = 27;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Nome";
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Preco";
            this.Column4.HeaderText = "Preço";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconSalvar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(455, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::AprendendoAUsarPanelHihi.Properties.Resources.iconSalvar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(455, 337);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 30);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmSalvarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvacessorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquantidadeA);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtnmcliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboPagto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvInstrumentos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbacessorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbinstrumento);
            this.Controls.Add(this.lblNome);
            this.Name = "frmSalvarPedido";
            this.Size = new System.Drawing.Size(783, 501);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvacessorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbinstrumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbacessorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvInstrumentos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboPagto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnmcliente;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtquantidadeA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvacessorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
