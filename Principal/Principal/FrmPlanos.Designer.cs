namespace Principal
{
    partial class FrmPlanos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.dgvPlanos = new System.Windows.Forms.DataGridView();
            this.colliDplano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtde_Alunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollFreqPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.btnFecharMod = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 61);
            this.panel1.TabIndex = 44;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitulo.Location = new System.Drawing.Point(3, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(122, 47);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Planos";
            // 
            // dgvPlanos
            // 
            this.dgvPlanos.AllowUserToAddRows = false;
            this.dgvPlanos.AllowUserToDeleteRows = false;
            this.dgvPlanos.AllowUserToOrderColumns = true;
            this.dgvPlanos.AllowUserToResizeColumns = false;
            this.dgvPlanos.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPlanos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPlanos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colliDplano,
            this.CollNome,
            this.ColDescricao,
            this.ColValor,
            this.colQtde_Alunos,
            this.CollFreqPagamento});
            this.dgvPlanos.Location = new System.Drawing.Point(11, 123);
            this.dgvPlanos.MultiSelect = false;
            this.dgvPlanos.Name = "dgvPlanos";
            this.dgvPlanos.ReadOnly = true;
            this.dgvPlanos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanos.Size = new System.Drawing.Size(574, 316);
            this.dgvPlanos.TabIndex = 39;
            // 
            // colliDplano
            // 
            this.colliDplano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colliDplano.DataPropertyName = "idPlano";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colliDplano.DefaultCellStyle = dataGridViewCellStyle11;
            this.colliDplano.HeaderText = "ID";
            this.colliDplano.Name = "colliDplano";
            this.colliDplano.ReadOnly = true;
            this.colliDplano.Width = 43;
            // 
            // CollNome
            // 
            this.CollNome.DataPropertyName = "Nome";
            this.CollNome.HeaderText = "Plano";
            this.CollNome.Name = "CollNome";
            this.CollNome.ReadOnly = true;
            // 
            // ColDescricao
            // 
            this.ColDescricao.DataPropertyName = "Descricao";
            this.ColDescricao.HeaderText = "Descricao";
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.ReadOnly = true;
            this.ColDescricao.Width = 150;
            // 
            // ColValor
            // 
            this.ColValor.DataPropertyName = "Valor";
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            // 
            // colQtde_Alunos
            // 
            this.colQtde_Alunos.DataPropertyName = "Qtde_alunos";
            this.colQtde_Alunos.HeaderText = "Alunos";
            this.colQtde_Alunos.Name = "colQtde_Alunos";
            this.colQtde_Alunos.ReadOnly = true;
            // 
            // CollFreqPagamento
            // 
            this.CollFreqPagamento.DataPropertyName = "Freq_pagamento";
            this.CollFreqPagamento.HeaderText = "PGTO";
            this.CollFreqPagamento.Name = "CollFreqPagamento";
            this.CollFreqPagamento.ReadOnly = true;
            this.CollFreqPagamento.Visible = false;
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(11, 84);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(442, 29);
            this.txtBoxPesquisa.TabIndex = 37;
            // 
            // btnFecharMod
            // 
            this.btnFecharMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharMod.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharMod.Image")));
            this.btnFecharMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharMod.Location = new System.Drawing.Point(510, 446);
            this.btnFecharMod.Name = "btnFecharMod";
            this.btnFecharMod.Size = new System.Drawing.Size(75, 39);
            this.btnFecharMod.TabIndex = 43;
            this.btnFecharMod.Text = "&Fechar";
            this.btnFecharMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharMod.UseVisualStyleBackColor = true;
            this.btnFecharMod.Click += new System.EventHandler(this.btnFecharMod_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(430, 446);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 42;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(349, 446);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 39);
            this.btnAlterar.TabIndex = 41;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(268, 446);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 39);
            this.btnInserir.TabIndex = 40;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(460, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPlanos);
            this.Controls.Add(this.btnFecharMod);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBoxPesquisa);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 531);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 531);
            this.Name = "FrmPlanos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planos";
            this.Load += new System.EventHandler(this.FrmPlanos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataGridView dgvPlanos;
        private System.Windows.Forms.Button btnFecharMod;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colliDplano;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtde_Alunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollFreqPagamento;
    }
}