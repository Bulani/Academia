namespace Principal
{
    partial class FrmExerciciosTreino
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQtdeExercicios = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeTreino = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRepeticoesDisponiveis = new System.Windows.Forms.DataGridView();
            this.ColExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRepeticoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAoTreino = new System.Windows.Forms.Button();
            this.btnAdicionarNovo = new System.Windows.Forms.Button();
            this.btnRemoverDoTreino = new System.Windows.Forms.Button();
            this.dgvRepeticoesDoTreino = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvarVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticoesDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticoesDoTreino)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 55);
            this.panel1.TabIndex = 37;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCadastro.Location = new System.Drawing.Point(7, 5);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(321, 47);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "Exercicios do treino";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblQtdeExercicios);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNomeTreino);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 59);
            this.panel2.TabIndex = 50;
            // 
            // lblQtdeExercicios
            // 
            this.lblQtdeExercicios.AutoSize = true;
            this.lblQtdeExercicios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblQtdeExercicios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeExercicios.Location = new System.Drawing.Point(502, 28);
            this.lblQtdeExercicios.Name = "lblQtdeExercicios";
            this.lblQtdeExercicios.Size = new System.Drawing.Size(20, 18);
            this.lblQtdeExercicios.TabIndex = 53;
            this.lblQtdeExercicios.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Qtde exercicios";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(274, 28);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(20, 18);
            this.lblCategoria.TabIndex = 51;
            this.lblCategoria.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Categoria";
            // 
            // lblNomeTreino
            // 
            this.lblNomeTreino.AutoSize = true;
            this.lblNomeTreino.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNomeTreino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTreino.Location = new System.Drawing.Point(3, 28);
            this.lblNomeTreino.Name = "lblNomeTreino";
            this.lblNomeTreino.Size = new System.Drawing.Size(20, 18);
            this.lblNomeTreino.TabIndex = 49;
            this.lblNomeTreino.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Treino Selecionado";
            // 
            // dgvRepeticoesDisponiveis
            // 
            this.dgvRepeticoesDisponiveis.AllowUserToAddRows = false;
            this.dgvRepeticoesDisponiveis.AllowUserToDeleteRows = false;
            this.dgvRepeticoesDisponiveis.BackgroundColor = System.Drawing.Color.White;
            this.dgvRepeticoesDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepeticoesDisponiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColExercicio,
            this.ColRepeticoes,
            this.ColSeries,
            this.ColEquipamento,
            this.ColMinutos});
            this.dgvRepeticoesDisponiveis.Location = new System.Drawing.Point(517, 154);
            this.dgvRepeticoesDisponiveis.MultiSelect = false;
            this.dgvRepeticoesDisponiveis.Name = "dgvRepeticoesDisponiveis";
            this.dgvRepeticoesDisponiveis.ReadOnly = true;
            this.dgvRepeticoesDisponiveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepeticoesDisponiveis.Size = new System.Drawing.Size(465, 360);
            this.dgvRepeticoesDisponiveis.TabIndex = 52;
            // 
            // ColExercicio
            // 
            this.ColExercicio.DataPropertyName = "NomeExercicio";
            this.ColExercicio.HeaderText = "Exercicio";
            this.ColExercicio.Name = "ColExercicio";
            this.ColExercicio.ReadOnly = true;
            // 
            // ColRepeticoes
            // 
            this.ColRepeticoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColRepeticoes.DataPropertyName = "QtdeRepeticoes";
            this.ColRepeticoes.HeaderText = "Repeticoes";
            this.ColRepeticoes.Name = "ColRepeticoes";
            this.ColRepeticoes.ReadOnly = true;
            this.ColRepeticoes.Width = 86;
            // 
            // ColSeries
            // 
            this.ColSeries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColSeries.DataPropertyName = "QtdeSeries";
            this.ColSeries.HeaderText = "Series";
            this.ColSeries.Name = "ColSeries";
            this.ColSeries.ReadOnly = true;
            this.ColSeries.Width = 61;
            // 
            // ColEquipamento
            // 
            this.ColEquipamento.DataPropertyName = "NomeEquipamento";
            this.ColEquipamento.HeaderText = "Equipamento";
            this.ColEquipamento.Name = "ColEquipamento";
            this.ColEquipamento.ReadOnly = true;
            // 
            // ColMinutos
            // 
            this.ColMinutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColMinutos.DataPropertyName = "Minutos";
            this.ColMinutos.HeaderText = "MInutos";
            this.ColMinutos.Name = "ColMinutos";
            this.ColMinutos.ReadOnly = true;
            this.ColMinutos.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Repetições do treino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Repetições disponiveis";
            // 
            // btnAddAoTreino
            // 
            this.btnAddAoTreino.Location = new System.Drawing.Point(706, 520);
            this.btnAddAoTreino.Name = "btnAddAoTreino";
            this.btnAddAoTreino.Size = new System.Drawing.Size(125, 23);
            this.btnAddAoTreino.TabIndex = 55;
            this.btnAddAoTreino.Text = "Adicionar ao treino";
            this.btnAddAoTreino.UseVisualStyleBackColor = true;
            this.btnAddAoTreino.Click += new System.EventHandler(this.btnAddAoTreino_Click);
            // 
            // btnAdicionarNovo
            // 
            this.btnAdicionarNovo.Location = new System.Drawing.Point(837, 520);
            this.btnAdicionarNovo.Name = "btnAdicionarNovo";
            this.btnAdicionarNovo.Size = new System.Drawing.Size(145, 23);
            this.btnAdicionarNovo.TabIndex = 56;
            this.btnAdicionarNovo.Text = "Adicionar nova repetição";
            this.btnAdicionarNovo.UseVisualStyleBackColor = true;
            this.btnAdicionarNovo.Click += new System.EventHandler(this.btnAdicionarNovoExercicio_Click);
            // 
            // btnRemoverDoTreino
            // 
            this.btnRemoverDoTreino.Location = new System.Drawing.Point(221, 520);
            this.btnRemoverDoTreino.Name = "btnRemoverDoTreino";
            this.btnRemoverDoTreino.Size = new System.Drawing.Size(125, 23);
            this.btnRemoverDoTreino.TabIndex = 57;
            this.btnRemoverDoTreino.Text = "Remover do repetição";
            this.btnRemoverDoTreino.UseVisualStyleBackColor = true;
            this.btnRemoverDoTreino.Click += new System.EventHandler(this.btnRemoverDoTreino_Click);
            // 
            // dgvRepeticoesDoTreino
            // 
            this.dgvRepeticoesDoTreino.AllowUserToAddRows = false;
            this.dgvRepeticoesDoTreino.AllowUserToDeleteRows = false;
            this.dgvRepeticoesDoTreino.BackgroundColor = System.Drawing.Color.White;
            this.dgvRepeticoesDoTreino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepeticoesDoTreino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvRepeticoesDoTreino.Location = new System.Drawing.Point(12, 154);
            this.dgvRepeticoesDoTreino.MultiSelect = false;
            this.dgvRepeticoesDoTreino.Name = "dgvRepeticoesDoTreino";
            this.dgvRepeticoesDoTreino.ReadOnly = true;
            this.dgvRepeticoesDoTreino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepeticoesDoTreino.Size = new System.Drawing.Size(465, 360);
            this.dgvRepeticoesDoTreino.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeExercicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Exercicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QtdeRepeticoes";
            this.dataGridViewTextBoxColumn2.HeaderText = "Repeticoes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 86;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QtdeSeries";
            this.dataGridViewTextBoxColumn3.HeaderText = "Series";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NomeEquipamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Equipamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Minutos";
            this.dataGridViewTextBoxColumn5.HeaderText = "MInutos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // btnSalvarVoltar
            // 
            this.btnSalvarVoltar.Location = new System.Drawing.Point(352, 520);
            this.btnSalvarVoltar.Name = "btnSalvarVoltar";
            this.btnSalvarVoltar.Size = new System.Drawing.Size(125, 23);
            this.btnSalvarVoltar.TabIndex = 59;
            this.btnSalvarVoltar.Text = "Salvar e voltar";
            this.btnSalvarVoltar.UseVisualStyleBackColor = true;
            this.btnSalvarVoltar.Click += new System.EventHandler(this.btnSalvarVoltar_Click);
            // 
            // FrmExerciciosTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 563);
            this.Controls.Add(this.btnSalvarVoltar);
            this.Controls.Add(this.dgvRepeticoesDoTreino);
            this.Controls.Add(this.btnRemoverDoTreino);
            this.Controls.Add(this.btnAdicionarNovo);
            this.Controls.Add(this.btnAddAoTreino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRepeticoesDisponiveis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmExerciciosTreino";
            this.Text = "FrmExerciciosTreino";
            this.Load += new System.EventHandler(this.FrmExerciciosTreino_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticoesDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticoesDoTreino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQtdeExercicios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeTreino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRepeticoesDisponiveis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddAoTreino;
        private System.Windows.Forms.Button btnAdicionarNovo;
        private System.Windows.Forms.Button btnRemoverDoTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRepeticoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMinutos;
        private System.Windows.Forms.DataGridView dgvRepeticoesDoTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSalvarVoltar;
    }
}