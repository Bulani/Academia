namespace Principal
{
    partial class FrmModalidadeSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModalidadeSelecionar));
            this.dataGridViewModalidade = new System.Windows.Forms.DataGridView();
            this.colNomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorMensal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFecharMod = new System.Windows.Forms.Button();
            this.btnConsultarMod = new System.Windows.Forms.Button();
            this.btnExcluirMod = new System.Windows.Forms.Button();
            this.btnAlterarMod = new System.Windows.Forms.Button();
            this.btnInserirMod = new System.Windows.Forms.Button();
            this.btnPesquisarMod = new System.Windows.Forms.Button();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewModalidade
            // 
            this.dataGridViewModalidade.AllowUserToAddRows = false;
            this.dataGridViewModalidade.AllowUserToDeleteRows = false;
            this.dataGridViewModalidade.AllowUserToOrderColumns = true;
            this.dataGridViewModalidade.AllowUserToResizeColumns = false;
            this.dataGridViewModalidade.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewModalidade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewModalidade.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeP,
            this.colValorMensal,
            this.colValorDia});
            this.dataGridViewModalidade.Location = new System.Drawing.Point(26, 83);
            this.dataGridViewModalidade.MultiSelect = false;
            this.dataGridViewModalidade.Name = "dataGridViewModalidade";
            this.dataGridViewModalidade.ReadOnly = true;
            this.dataGridViewModalidade.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewModalidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModalidade.Size = new System.Drawing.Size(503, 319);
            this.dataGridViewModalidade.TabIndex = 12;
            // 
            // colNomeP
            // 
            this.colNomeP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNomeP.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNomeP.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNomeP.HeaderText = "Nome";
            this.colNomeP.Name = "colNomeP";
            this.colNomeP.ReadOnly = true;
            this.colNomeP.Width = 60;
            // 
            // colValorMensal
            // 
            this.colValorMensal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValorMensal.DataPropertyName = "ValorMensal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colValorMensal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValorMensal.HeaderText = "Valor Mensal";
            this.colValorMensal.Name = "colValorMensal";
            this.colValorMensal.ReadOnly = true;
            this.colValorMensal.Width = 93;
            // 
            // colValorDia
            // 
            this.colValorDia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValorDia.DataPropertyName = "ValorAula";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colValorDia.DefaultCellStyle = dataGridViewCellStyle4;
            this.colValorDia.HeaderText = "Valor Aula";
            this.colValorDia.Name = "colValorDia";
            this.colValorDia.ReadOnly = true;
            this.colValorDia.Width = 80;
            // 
            // btnFecharMod
            // 
            this.btnFecharMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharMod.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharMod.Image")));
            this.btnFecharMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharMod.Location = new System.Drawing.Point(454, 413);
            this.btnFecharMod.Name = "btnFecharMod";
            this.btnFecharMod.Size = new System.Drawing.Size(75, 39);
            this.btnFecharMod.TabIndex = 17;
            this.btnFecharMod.Text = "&Fechar";
            this.btnFecharMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharMod.UseVisualStyleBackColor = true;
            this.btnFecharMod.Click += new System.EventHandler(this.btnFecharMod_Click);
            // 
            // btnConsultarMod
            // 
            this.btnConsultarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMod.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarMod.Image")));
            this.btnConsultarMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMod.Location = new System.Drawing.Point(277, 413);
            this.btnConsultarMod.Name = "btnConsultarMod";
            this.btnConsultarMod.Size = new System.Drawing.Size(90, 39);
            this.btnConsultarMod.TabIndex = 15;
            this.btnConsultarMod.Text = "&Consultar";
            this.btnConsultarMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarMod.UseVisualStyleBackColor = true;
            this.btnConsultarMod.Click += new System.EventHandler(this.btnConsultarMod_Click);
            // 
            // btnExcluirMod
            // 
            this.btnExcluirMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirMod.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirMod.Image")));
            this.btnExcluirMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirMod.Location = new System.Drawing.Point(373, 413);
            this.btnExcluirMod.Name = "btnExcluirMod";
            this.btnExcluirMod.Size = new System.Drawing.Size(75, 39);
            this.btnExcluirMod.TabIndex = 16;
            this.btnExcluirMod.Text = "&Excluir";
            this.btnExcluirMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirMod.UseVisualStyleBackColor = true;
            this.btnExcluirMod.Click += new System.EventHandler(this.btnExcluirMod_Click);
            // 
            // btnAlterarMod
            // 
            this.btnAlterarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarMod.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarMod.Image")));
            this.btnAlterarMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarMod.Location = new System.Drawing.Point(196, 413);
            this.btnAlterarMod.Name = "btnAlterarMod";
            this.btnAlterarMod.Size = new System.Drawing.Size(75, 39);
            this.btnAlterarMod.TabIndex = 14;
            this.btnAlterarMod.Text = "&Alterar";
            this.btnAlterarMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarMod.UseVisualStyleBackColor = true;
            this.btnAlterarMod.Click += new System.EventHandler(this.btnAlterarMod_Click);
            // 
            // btnInserirMod
            // 
            this.btnInserirMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirMod.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirMod.Image")));
            this.btnInserirMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirMod.Location = new System.Drawing.Point(115, 413);
            this.btnInserirMod.Name = "btnInserirMod";
            this.btnInserirMod.Size = new System.Drawing.Size(75, 39);
            this.btnInserirMod.TabIndex = 13;
            this.btnInserirMod.Text = "&Inserir";
            this.btnInserirMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirMod.UseVisualStyleBackColor = true;
            this.btnInserirMod.Click += new System.EventHandler(this.btnInserirMod_Click);
            // 
            // btnPesquisarMod
            // 
            this.btnPesquisarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarMod.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarMod.Image")));
            this.btnPesquisarMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarMod.Location = new System.Drawing.Point(398, 39);
            this.btnPesquisarMod.Name = "btnPesquisarMod";
            this.btnPesquisarMod.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisarMod.TabIndex = 11;
            this.btnPesquisarMod.Text = "&Pesquisar";
            this.btnPesquisarMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarMod.UseVisualStyleBackColor = true;
            this.btnPesquisarMod.Click += new System.EventHandler(this.btnPesquisarMod_Click);
            this.btnPesquisarMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPesquisarMod_KeyPress);
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(35, 42);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(357, 29);
            this.txtBoxPesquisa.TabIndex = 10;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(31, 12);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(126, 27);
            this.lblPesquisa.TabIndex = 9;
            this.lblPesquisa.Text = "Modalidade:";
            // 
            // FrmModalidadeSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 462);
            this.Controls.Add(this.dataGridViewModalidade);
            this.Controls.Add(this.btnFecharMod);
            this.Controls.Add(this.btnConsultarMod);
            this.Controls.Add(this.btnExcluirMod);
            this.Controls.Add(this.btnAlterarMod);
            this.Controls.Add(this.btnInserirMod);
            this.Controls.Add(this.btnPesquisarMod);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 501);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 501);
            this.Name = "FrmModalidadeSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Modalidade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModalidade;
        private System.Windows.Forms.Button btnFecharMod;
        private System.Windows.Forms.Button btnConsultarMod;
        private System.Windows.Forms.Button btnExcluirMod;
        private System.Windows.Forms.Button btnAlterarMod;
        private System.Windows.Forms.Button btnInserirMod;
        private System.Windows.Forms.Button btnPesquisarMod;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorMensal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDia;
    }
}