namespace Principal
{
    partial class FrmReceberPGTO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pnlItens = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.clDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTroco = new System.Windows.Forms.Panel();
            this.pnlTotalPago = new System.Windows.Forms.Panel();
            this.pnlTotalPAgar = new System.Windows.Forms.Panel();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.btnLancarPGTO = new System.Windows.Forms.Button();
            this.txtValorPGTO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTipoPGTO = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnlTroco.SuspendLayout();
            this.pnlTotalPago.SuspendLayout();
            this.pnlTotalPAgar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 61);
            this.panel1.TabIndex = 45;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitulo.Location = new System.Drawing.Point(3, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(222, 47);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Recebimento";
            // 
            // pnlItens
            // 
            this.pnlItens.BackColor = System.Drawing.Color.White;
            this.pnlItens.Controls.Add(this.pnlTotalPAgar);
            this.pnlItens.Controls.Add(this.pnlTotalPago);
            this.pnlItens.Controls.Add(this.pnlTroco);
            this.pnlItens.Controls.Add(this.dgvItens);
            this.pnlItens.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlItens.Location = new System.Drawing.Point(421, 61);
            this.pnlItens.Name = "pnlItens";
            this.pnlItens.Size = new System.Drawing.Size(443, 514);
            this.pnlItens.TabIndex = 60;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDescricao,
            this.colAcrescimo,
            this.colDesconto,
            this.colTotal});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(443, 268);
            this.dgvItens.TabIndex = 47;
            // 
            // clDescricao
            // 
            this.clDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clDescricao.DataPropertyName = "IdAluno";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clDescricao.DefaultCellStyle = dataGridViewCellStyle10;
            this.clDescricao.HeaderText = "Descricao";
            this.clDescricao.Name = "clDescricao";
            this.clDescricao.ReadOnly = true;
            this.clDescricao.Width = 80;
            // 
            // colAcrescimo
            // 
            this.colAcrescimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAcrescimo.DataPropertyName = "Nome";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAcrescimo.DefaultCellStyle = dataGridViewCellStyle11;
            this.colAcrescimo.HeaderText = "Acrescimo";
            this.colAcrescimo.Name = "colAcrescimo";
            this.colAcrescimo.ReadOnly = true;
            this.colAcrescimo.Width = 81;
            // 
            // colDesconto
            // 
            this.colDesconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDesconto.DataPropertyName = "Apelido";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDesconto.DefaultCellStyle = dataGridViewCellStyle12;
            this.colDesconto.HeaderText = "Desconto";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.ReadOnly = true;
            this.colDesconto.Width = 78;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTotal.DataPropertyName = "CPF";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle13;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 56;
            // 
            // pnlTroco
            // 
            this.pnlTroco.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTroco.Controls.Add(this.label5);
            this.pnlTroco.Controls.Add(this.label6);
            this.pnlTroco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTroco.Location = new System.Drawing.Point(0, 473);
            this.pnlTroco.Name = "pnlTroco";
            this.pnlTroco.Size = new System.Drawing.Size(443, 41);
            this.pnlTroco.TabIndex = 51;
            // 
            // pnlTotalPago
            // 
            this.pnlTotalPago.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTotalPago.Controls.Add(this.label3);
            this.pnlTotalPago.Controls.Add(this.label4);
            this.pnlTotalPago.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalPago.Location = new System.Drawing.Point(0, 432);
            this.pnlTotalPago.Name = "pnlTotalPago";
            this.pnlTotalPago.Size = new System.Drawing.Size(443, 41);
            this.pnlTotalPago.TabIndex = 52;
            // 
            // pnlTotalPAgar
            // 
            this.pnlTotalPAgar.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTotalPAgar.Controls.Add(this.lblTotalAPagar);
            this.pnlTotalPAgar.Controls.Add(this.label11);
            this.pnlTotalPAgar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalPAgar.Location = new System.Drawing.Point(0, 391);
            this.pnlTotalPAgar.Name = "pnlTotalPAgar";
            this.pnlTotalPAgar.Size = new System.Drawing.Size(443, 41);
            this.pnlTotalPAgar.TabIndex = 53;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalAPagar.Location = new System.Drawing.Point(377, 8);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(54, 30);
            this.lblTotalAPagar.TabIndex = 57;
            this.lblTotalAPagar.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(7, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 30);
            this.label11.TabIndex = 56;
            this.label11.Text = "Total a pagar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(377, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 30);
            this.label3.TabIndex = 59;
            this.label3.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(7, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 30);
            this.label4.TabIndex = 58;
            this.label4.Text = "Total pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(377, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 30);
            this.label5.TabIndex = 59;
            this.label5.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(7, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 58;
            this.label6.Text = "Troco:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnFinalizar);
            this.panel2.Controls.Add(this.dgvPagamentos);
            this.panel2.Controls.Add(this.btnLancarPGTO);
            this.panel2.Controls.Add(this.txtValorPGTO);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbTipoPGTO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 514);
            this.panel2.TabIndex = 61;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(16, 473);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(383, 35);
            this.btnFinalizar.TabIndex = 66;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            this.dgvPagamentos.AllowUserToOrderColumns = true;
            this.dgvPagamentos.AllowUserToResizeColumns = false;
            this.dgvPagamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPagamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPagamentos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colValor});
            this.dgvPagamentos.Location = new System.Drawing.Point(16, 109);
            this.dgvPagamentos.MultiSelect = false;
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.ReadOnly = true;
            this.dgvPagamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamentos.Size = new System.Drawing.Size(383, 358);
            this.dgvPagamentos.TabIndex = 65;
            // 
            // btnLancarPGTO
            // 
            this.btnLancarPGTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarPGTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancarPGTO.Location = new System.Drawing.Point(16, 68);
            this.btnLancarPGTO.Name = "btnLancarPGTO";
            this.btnLancarPGTO.Size = new System.Drawing.Size(383, 35);
            this.btnLancarPGTO.TabIndex = 64;
            this.btnLancarPGTO.Text = "Lançar";
            this.btnLancarPGTO.UseVisualStyleBackColor = true;
            // 
            // txtValorPGTO
            // 
            this.txtValorPGTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtValorPGTO.Location = new System.Drawing.Point(16, 33);
            this.txtValorPGTO.MaxLength = 60;
            this.txtValorPGTO.Name = "txtValorPGTO";
            this.txtValorPGTO.Size = new System.Drawing.Size(97, 29);
            this.txtValorPGTO.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 62;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 61;
            this.label1.Text = "Forma de PGTO:";
            // 
            // cbbTipoPGTO
            // 
            this.cbbTipoPGTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoPGTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoPGTO.FormattingEnabled = true;
            this.cbbTipoPGTO.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Apelido"});
            this.cbbTipoPGTO.Location = new System.Drawing.Point(119, 33);
            this.cbbTipoPGTO.Name = "cbbTipoPGTO";
            this.cbbTipoPGTO.Size = new System.Drawing.Size(280, 28);
            this.cbbTipoPGTO.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAluno";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn1.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // colValor
            // 
            this.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colValor.DefaultCellStyle = dataGridViewCellStyle16;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 56;
            // 
            // FrmReceberPGTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlItens);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReceberPGTO";
            this.Text = "Recebimento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnlTroco.ResumeLayout(false);
            this.pnlTroco.PerformLayout();
            this.pnlTotalPago.ResumeLayout(false);
            this.pnlTotalPago.PerformLayout();
            this.pnlTotalPAgar.ResumeLayout(false);
            this.pnlTotalPAgar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Panel pnlItens;
        private System.Windows.Forms.Panel pnlTotalPAgar;
        private System.Windows.Forms.Panel pnlTotalPago;
        private System.Windows.Forms.Panel pnlTroco;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Button btnLancarPGTO;
        private System.Windows.Forms.TextBox txtValorPGTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTipoPGTO;
    }
}