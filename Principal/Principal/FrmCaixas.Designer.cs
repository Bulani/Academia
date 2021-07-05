namespace Principal
{
    partial class FrmCaixas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatusCaixa = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.dgvCaixas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData_Abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldata_Fechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnReabrirCaixa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblStatusCaixa);
            this.panel1.Controls.Add(this.lblCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 61);
            this.panel1.TabIndex = 31;
            // 
            // lblStatusCaixa
            // 
            this.lblStatusCaixa.AutoSize = true;
            this.lblStatusCaixa.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCaixa.ForeColor = System.Drawing.Color.Blue;
            this.lblStatusCaixa.Location = new System.Drawing.Point(226, 9);
            this.lblStatusCaixa.Name = "lblStatusCaixa";
            this.lblStatusCaixa.Size = new System.Drawing.Size(44, 47);
            this.lblStatusCaixa.TabIndex = 2;
            this.lblStatusCaixa.Text = "...";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCadastro.Location = new System.Drawing.Point(3, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(217, 47);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "Status Caixa ";
            // 
            // dgvCaixas
            // 
            this.dgvCaixas.AllowUserToAddRows = false;
            this.dgvCaixas.AllowUserToDeleteRows = false;
            this.dgvCaixas.AllowUserToOrderColumns = true;
            this.dgvCaixas.AllowUserToResizeColumns = false;
            this.dgvCaixas.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCaixas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCaixas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colData_Abertura,
            this.Coldata_Fechamento});
            this.dgvCaixas.Location = new System.Drawing.Point(11, 81);
            this.dgvCaixas.MultiSelect = false;
            this.dgvCaixas.Name = "dgvCaixas";
            this.dgvCaixas.ReadOnly = true;
            this.dgvCaixas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCaixas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixas.Size = new System.Drawing.Size(503, 301);
            this.dgvCaixas.TabIndex = 28;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "IdCaixa";
            this.colID.HeaderText = "Número";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colData_Abertura
            // 
            this.colData_Abertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colData_Abertura.DataPropertyName = "data_abertura";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colData_Abertura.DefaultCellStyle = dataGridViewCellStyle4;
            this.colData_Abertura.HeaderText = "Abertura";
            this.colData_Abertura.Name = "colData_Abertura";
            this.colData_Abertura.ReadOnly = true;
            this.colData_Abertura.Width = 72;
            // 
            // Coldata_Fechamento
            // 
            this.Coldata_Fechamento.DataPropertyName = "Data_fechamento";
            this.Coldata_Fechamento.HeaderText = "Fechamento";
            this.Coldata_Fechamento.Name = "Coldata_Fechamento";
            this.Coldata_Fechamento.ReadOnly = true;
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharCaixa.Location = new System.Drawing.Point(133, 388);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(137, 39);
            this.btnFecharCaixa.TabIndex = 30;
            this.btnFecharCaixa.Text = "&Fechar Caixa Atual";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.Location = new System.Drawing.Point(11, 388);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(116, 39);
            this.btnAbrirCaixa.TabIndex = 29;
            this.btnAbrirCaixa.Text = "&Abrir Novo Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(440, 388);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 39);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReabrirCaixa
            // 
            this.btnReabrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReabrirCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReabrirCaixa.Location = new System.Drawing.Point(276, 388);
            this.btnReabrirCaixa.Name = "btnReabrirCaixa";
            this.btnReabrirCaixa.Size = new System.Drawing.Size(137, 39);
            this.btnReabrirCaixa.TabIndex = 33;
            this.btnReabrirCaixa.Text = "&Reabrir ultimo caixa";
            this.btnReabrirCaixa.UseVisualStyleBackColor = true;
            this.btnReabrirCaixa.Click += new System.EventHandler(this.btnReabrirCaixa_Click);
            // 
            // FrmCaixas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 447);
            this.Controls.Add(this.btnReabrirCaixa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCaixas);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.btnAbrirCaixa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaixas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixas";
            this.Load += new System.EventHandler(this.FrmCaixas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatusCaixa;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.DataGridView dgvCaixas;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData_Abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldata_Fechamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnReabrirCaixa;
    }
}