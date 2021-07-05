namespace Principal
{
    partial class FrmGestaoDeRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoDeRepeticao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.txtQtdeSeries = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdeRepeticoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.dgvExercicios = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnFecharMod = new System.Windows.Forms.Button();
            this.ColExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 55);
            this.panel1.TabIndex = 38;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCadastro.Location = new System.Drawing.Point(7, 5);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(187, 47);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "Repetições";
            // 
            // txtQtdeSeries
            // 
            this.txtQtdeSeries.Location = new System.Drawing.Point(15, 90);
            this.txtQtdeSeries.Name = "txtQtdeSeries";
            this.txtQtdeSeries.Size = new System.Drawing.Size(118, 20);
            this.txtQtdeSeries.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Qtde de séries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Qtde de repetições";
            // 
            // txtQtdeRepeticoes
            // 
            this.txtQtdeRepeticoes.Location = new System.Drawing.Point(139, 90);
            this.txtQtdeRepeticoes.Name = "txtQtdeRepeticoes";
            this.txtQtdeRepeticoes.Size = new System.Drawing.Size(140, 20);
            this.txtQtdeRepeticoes.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Minutos";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(285, 90);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(140, 20);
            this.txtMinutos.TabIndex = 52;
            // 
            // dgvExercicios
            // 
            this.dgvExercicios.AllowUserToAddRows = false;
            this.dgvExercicios.AllowUserToDeleteRows = false;
            this.dgvExercicios.BackgroundColor = System.Drawing.Color.White;
            this.dgvExercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColExercicio,
            this.colIDExercicio,
            this.colEquipamento});
            this.dgvExercicios.Location = new System.Drawing.Point(16, 144);
            this.dgvExercicios.MultiSelect = false;
            this.dgvExercicios.Name = "dgvExercicios";
            this.dgvExercicios.ReadOnly = true;
            this.dgvExercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExercicios.Size = new System.Drawing.Size(410, 232);
            this.dgvExercicios.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Exercicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "(Selecione o exercício)";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(255, 382);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 40);
            this.btnInserir.TabIndex = 57;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFecharMod
            // 
            this.btnFecharMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharMod.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharMod.Image")));
            this.btnFecharMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharMod.Location = new System.Drawing.Point(336, 382);
            this.btnFecharMod.Name = "btnFecharMod";
            this.btnFecharMod.Size = new System.Drawing.Size(90, 40);
            this.btnFecharMod.TabIndex = 58;
            this.btnFecharMod.Text = "&Cancelar";
            this.btnFecharMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharMod.UseVisualStyleBackColor = true;
            // 
            // ColExercicio
            // 
            this.ColExercicio.DataPropertyName = "Nome";
            this.ColExercicio.HeaderText = "Exercicio";
            this.ColExercicio.Name = "ColExercicio";
            this.ColExercicio.ReadOnly = true;
            // 
            // colIDExercicio
            // 
            this.colIDExercicio.DataPropertyName = "idExercicio";
            this.colIDExercicio.HeaderText = "IDExercicio";
            this.colIDExercicio.Name = "colIDExercicio";
            this.colIDExercicio.ReadOnly = true;
            this.colIDExercicio.Visible = false;
            // 
            // colEquipamento
            // 
            this.colEquipamento.DataPropertyName = "NomeEquipamento";
            this.colEquipamento.HeaderText = "Equipamento";
            this.colEquipamento.Name = "colEquipamento";
            this.colEquipamento.ReadOnly = true;
            // 
            // FrmGestaoDeRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 430);
            this.Controls.Add(this.btnFecharMod);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvExercicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtdeRepeticoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdeSeries);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestaoDeRepeticao";
            this.Text = "Gestão de repetições";
            this.Load += new System.EventHandler(this.FrmGestaoDeRepeticao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtQtdeSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdeRepeticoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.DataGridView dgvExercicios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnFecharMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipamento;
    }
}