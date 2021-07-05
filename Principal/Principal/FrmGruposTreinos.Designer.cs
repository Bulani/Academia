namespace Principal
{
    partial class FrmGruposTreinos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGruposTreinos));
            this.dataGridViewGrupoTreino = new System.Windows.Forms.DataGridView();
            this.colNomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnFecharMod = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoTreino)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrupoTreino
            // 
            this.dataGridViewGrupoTreino.AllowUserToAddRows = false;
            this.dataGridViewGrupoTreino.AllowUserToDeleteRows = false;
            this.dataGridViewGrupoTreino.AllowUserToOrderColumns = true;
            this.dataGridViewGrupoTreino.AllowUserToResizeColumns = false;
            this.dataGridViewGrupoTreino.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewGrupoTreino.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewGrupoTreino.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewGrupoTreino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupoTreino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeP});
            this.dataGridViewGrupoTreino.Location = new System.Drawing.Point(16, 73);
            this.dataGridViewGrupoTreino.MultiSelect = false;
            this.dataGridViewGrupoTreino.Name = "dataGridViewGrupoTreino";
            this.dataGridViewGrupoTreino.ReadOnly = true;
            this.dataGridViewGrupoTreino.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewGrupoTreino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrupoTreino.Size = new System.Drawing.Size(503, 312);
            this.dataGridViewGrupoTreino.TabIndex = 11;
            // 
            // colNomeP
            // 
            this.colNomeP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNomeP.DataPropertyName = "Nome";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNomeP.DefaultCellStyle = dataGridViewCellStyle8;
            this.colNomeP.HeaderText = "Nome";
            this.colNomeP.Name = "colNomeP";
            this.colNomeP.ReadOnly = true;
            this.colNomeP.Width = 60;
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(16, 35);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(357, 29);
            this.txtBoxPesquisa.TabIndex = 9;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(12, 9);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(87, 27);
            this.lblPesquisa.TabIndex = 8;
            this.lblPesquisa.Text = "Nome:";
            // 
            // btnFecharMod
            // 
            this.btnFecharMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharMod.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharMod.Image")));
            this.btnFecharMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharMod.Location = new System.Drawing.Point(444, 398);
            this.btnFecharMod.Name = "btnFecharMod";
            this.btnFecharMod.Size = new System.Drawing.Size(75, 39);
            this.btnFecharMod.TabIndex = 15;
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
            this.btnExcluir.Location = new System.Drawing.Point(363, 398);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(282, 398);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 39);
            this.btnAlterar.TabIndex = 13;
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
            this.btnInserir.Location = new System.Drawing.Point(201, 398);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 39);
            this.btnInserir.TabIndex = 12;
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
            this.btnPesquisar.Location = new System.Drawing.Point(393, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmGruposTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 449);
            this.Controls.Add(this.dataGridViewGrupoTreino);
            this.Controls.Add(this.btnFecharMod);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 488);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(556, 488);
            this.Name = "FrmGruposTreinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos de treinos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoTreino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGrupoTreino;
        private System.Windows.Forms.Button btnFecharMod;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeP;
    }
}