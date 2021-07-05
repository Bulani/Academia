namespace Principal
{
    partial class FrmTreinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreinos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.dataGridViewTreinos = new System.Windows.Forms.DataGridView();
            this.colNomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNOmeGrupoTreino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnExerciciosDoTreino = new System.Windows.Forms.Button();
            this.btnFecharMod = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreinos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 55);
            this.panel1.TabIndex = 36;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCadastro.Location = new System.Drawing.Point(7, 5);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(129, 47);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "Treinos";
            // 
            // dataGridViewTreinos
            // 
            this.dataGridViewTreinos.AllowUserToAddRows = false;
            this.dataGridViewTreinos.AllowUserToDeleteRows = false;
            this.dataGridViewTreinos.AllowUserToOrderColumns = true;
            this.dataGridViewTreinos.AllowUserToResizeColumns = false;
            this.dataGridViewTreinos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTreinos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTreinos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewTreinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeP,
            this.ColNOmeGrupoTreino});
            this.dataGridViewTreinos.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewTreinos.MultiSelect = false;
            this.dataGridViewTreinos.Name = "dataGridViewTreinos";
            this.dataGridViewTreinos.ReadOnly = true;
            this.dataGridViewTreinos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTreinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTreinos.Size = new System.Drawing.Size(489, 312);
            this.dataGridViewTreinos.TabIndex = 31;
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
            // ColNOmeGrupoTreino
            // 
            this.ColNOmeGrupoTreino.DataPropertyName = "Nome_grupo_treino";
            this.ColNOmeGrupoTreino.HeaderText = "Categoria";
            this.ColNOmeGrupoTreino.Name = "ColNOmeGrupoTreino";
            this.ColNOmeGrupoTreino.ReadOnly = true;
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(12, 91);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(348, 29);
            this.txtBoxPesquisa.TabIndex = 29;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(11, 61);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(126, 27);
            this.lblPesquisa.TabIndex = 28;
            this.lblPesquisa.Text = "Treino";
            // 
            // btnExerciciosDoTreino
            // 
            this.btnExerciciosDoTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExerciciosDoTreino.Image = ((System.Drawing.Image)(resources.GetObject("btnExerciciosDoTreino.Image")));
            this.btnExerciciosDoTreino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExerciciosDoTreino.Location = new System.Drawing.Point(255, 444);
            this.btnExerciciosDoTreino.Name = "btnExerciciosDoTreino";
            this.btnExerciciosDoTreino.Size = new System.Drawing.Size(149, 39);
            this.btnExerciciosDoTreino.TabIndex = 37;
            this.btnExerciciosDoTreino.Text = "&Exercicios do treino";
            this.btnExerciciosDoTreino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExerciciosDoTreino.UseVisualStyleBackColor = true;
            this.btnExerciciosDoTreino.Click += new System.EventHandler(this.btnExerciciosDoTreino_Click);
            // 
            // btnFecharMod
            // 
            this.btnFecharMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharMod.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharMod.Image")));
            this.btnFecharMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharMod.Location = new System.Drawing.Point(426, 444);
            this.btnFecharMod.Name = "btnFecharMod";
            this.btnFecharMod.Size = new System.Drawing.Size(75, 39);
            this.btnFecharMod.TabIndex = 35;
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
            this.btnExcluir.Location = new System.Drawing.Point(174, 444);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 34;
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
            this.btnAlterar.Location = new System.Drawing.Point(12, 444);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 39);
            this.btnAlterar.TabIndex = 33;
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
            this.btnInserir.Location = new System.Drawing.Point(93, 444);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 39);
            this.btnInserir.TabIndex = 32;
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
            this.btnPesquisar.Location = new System.Drawing.Point(375, 85);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 498);
            this.Controls.Add(this.btnExerciciosDoTreino);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTreinos);
            this.Controls.Add(this.btnFecharMod);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTreinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treinos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.DataGridView dataGridViewTreinos;
        private System.Windows.Forms.Button btnFecharMod;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNOmeGrupoTreino;
        private System.Windows.Forms.Button btnExerciciosDoTreino;
    }
}