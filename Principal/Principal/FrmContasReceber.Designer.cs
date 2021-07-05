namespace Principal
{
    partial class FrmContasReceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasReceber));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dgvPendencias = new System.Windows.Forms.DataGridView();
            this.colIDContas_Receber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendencias)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisar por:";
            // 
            // cbBoxTipoPesquisa
            // 
            this.cbBoxTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxTipoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTipoPesquisa.FormattingEnabled = true;
            this.cbBoxTipoPesquisa.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Apelido"});
            this.cbBoxTipoPesquisa.Location = new System.Drawing.Point(14, 37);
            this.cbBoxTipoPesquisa.Name = "cbBoxTipoPesquisa";
            this.cbBoxTipoPesquisa.Size = new System.Drawing.Size(141, 28);
            this.cbBoxTipoPesquisa.TabIndex = 7;
            // 
            // dataGridViewAluno
            // 
            this.dataGridViewAluno.AllowUserToAddRows = false;
            this.dataGridViewAluno.AllowUserToDeleteRows = false;
            this.dataGridViewAluno.AllowUserToOrderColumns = true;
            this.dataGridViewAluno.AllowUserToResizeColumns = false;
            this.dataGridViewAluno.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAluno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAluno.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNomeP,
            this.colApelido,
            this.colCPF,
            this.colTelefone,
            this.colCelular});
            this.dataGridViewAluno.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewAluno.MultiSelect = false;
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ReadOnly = true;
            this.dataGridViewAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAluno.Size = new System.Drawing.Size(858, 193);
            this.dataGridViewAluno.TabIndex = 11;
            this.dataGridViewAluno.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAluno_CellMouseClick);
            // 
            // colCodigo
            // 
            this.colCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCodigo.DataPropertyName = "IdAluno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 65;
            // 
            // colNomeP
            // 
            this.colNomeP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNomeP.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNomeP.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNomeP.HeaderText = "Nome";
            this.colNomeP.Name = "colNomeP";
            this.colNomeP.ReadOnly = true;
            this.colNomeP.Width = 60;
            // 
            // colApelido
            // 
            this.colApelido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colApelido.DataPropertyName = "Apelido";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colApelido.DefaultCellStyle = dataGridViewCellStyle4;
            this.colApelido.HeaderText = "Apelido";
            this.colApelido.Name = "colApelido";
            this.colApelido.ReadOnly = true;
            this.colApelido.Width = 67;
            // 
            // colCPF
            // 
            this.colCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCPF.DataPropertyName = "CPF";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCPF.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            this.colCPF.Width = 52;
            // 
            // colTelefone
            // 
            this.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTelefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTelefone.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 74;
            // 
            // colCelular
            // 
            this.colCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCelular.DataPropertyName = "Celular";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCelular.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            this.colCelular.Width = 64;
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarAluno.Image")));
            this.btnPesquisarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(744, 34);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisarAluno.TabIndex = 10;
            this.btnPesquisarAluno.Text = "&Pesquisar";
            this.btnPesquisarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarAluno.UseVisualStyleBackColor = true;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(175, 37);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(553, 29);
            this.txtBoxPesquisa.TabIndex = 9;
            this.txtBoxPesquisa.TextChanged += new System.EventHandler(this.txtBoxPesquisa_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(171, 8);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(74, 27);
            this.lblPesquisa.TabIndex = 8;
            this.lblPesquisa.Text = "Aluno:";
            // 
            // dgvPendencias
            // 
            this.dgvPendencias.AllowUserToAddRows = false;
            this.dgvPendencias.AllowUserToDeleteRows = false;
            this.dgvPendencias.AllowUserToOrderColumns = true;
            this.dgvPendencias.AllowUserToResizeColumns = false;
            this.dgvPendencias.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPendencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPendencias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPendencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDContas_Receber,
            this.colIDContrato,
            this.ColValor,
            this.ColDataEmissao,
            this.colData_Vencimento,
            this.colValorPago,
            this.ColRestante});
            this.dgvPendencias.Location = new System.Drawing.Point(12, 326);
            this.dgvPendencias.Name = "dgvPendencias";
            this.dgvPendencias.ReadOnly = true;
            this.dgvPendencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPendencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendencias.Size = new System.Drawing.Size(858, 193);
            this.dgvPendencias.TabIndex = 13;
            this.dgvPendencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendencias_CellContentClick);
            // 
            // colIDContas_Receber
            // 
            this.colIDContas_Receber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIDContas_Receber.DataPropertyName = "Idcontas_receber";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colIDContas_Receber.DefaultCellStyle = dataGridViewCellStyle9;
            this.colIDContas_Receber.HeaderText = "Cod. Par";
            this.colIDContas_Receber.Name = "colIDContas_Receber";
            this.colIDContas_Receber.ReadOnly = true;
            this.colIDContas_Receber.Width = 73;
            // 
            // colIDContrato
            // 
            this.colIDContrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIDContrato.DataPropertyName = "idContrato";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colIDContrato.DefaultCellStyle = dataGridViewCellStyle10;
            this.colIDContrato.HeaderText = "N° Contrato";
            this.colIDContrato.Name = "colIDContrato";
            this.colIDContrato.ReadOnly = true;
            this.colIDContrato.Width = 87;
            // 
            // ColValor
            // 
            this.ColValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColValor.DataPropertyName = "Valor";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColValor.HeaderText = "Valor Ori.";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            this.ColValor.Width = 75;
            // 
            // ColDataEmissao
            // 
            this.ColDataEmissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDataEmissao.DataPropertyName = "Data_emissao";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDataEmissao.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColDataEmissao.HeaderText = "Emissão";
            this.ColDataEmissao.Name = "ColDataEmissao";
            this.ColDataEmissao.ReadOnly = true;
            this.ColDataEmissao.Width = 71;
            // 
            // colData_Vencimento
            // 
            this.colData_Vencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colData_Vencimento.DataPropertyName = "Data_Vencimento";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colData_Vencimento.DefaultCellStyle = dataGridViewCellStyle13;
            this.colData_Vencimento.HeaderText = "Vencimento";
            this.colData_Vencimento.Name = "colData_Vencimento";
            this.colData_Vencimento.ReadOnly = true;
            this.colData_Vencimento.Width = 88;
            // 
            // colValorPago
            // 
            this.colValorPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValorPago.DataPropertyName = "ValorPago";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.colValorPago.DefaultCellStyle = dataGridViewCellStyle14;
            this.colValorPago.HeaderText = "Val. Pago";
            this.colValorPago.Name = "colValorPago";
            this.colValorPago.ReadOnly = true;
            this.colValorPago.Width = 78;
            // 
            // ColRestante
            // 
            this.ColRestante.DataPropertyName = "Restante";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.ColRestante.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColRestante.HeaderText = "Restante";
            this.ColRestante.Name = "ColRestante";
            this.ColRestante.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pendencias";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblTotalAPagar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 50);
            this.panel2.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(758, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 56;
            this.button1.Text = "&Receber";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalAPagar.Location = new System.Drawing.Point(164, 7);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(54, 30);
            this.lblTotalAPagar.TabIndex = 55;
            this.lblTotalAPagar.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(9, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 30);
            this.label11.TabIndex = 54;
            this.label11.Text = "Total a pagar:";
            // 
            // FrmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPendencias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxTipoPesquisa);
            this.Controls.Add(this.dataGridViewAluno);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a receber";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendencias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxTipoPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dgvPendencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDContas_Receber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData_Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRestante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label11;
    }
}