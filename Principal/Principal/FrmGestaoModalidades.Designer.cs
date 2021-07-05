namespace Principal
{
    partial class FrmGestaoModalidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoModalidades));
            this.gpBoxHorarios = new System.Windows.Forms.GroupBox();
            this.dataGridViewDiaHora = new System.Windows.Forms.DataGridView();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxDia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpBoxModalidade = new System.Windows.Forms.GroupBox();
            this.txtBoxAula = new System.Windows.Forms.TextBox();
            this.txtBoxMensal = new System.Windows.Forms.TextBox();
            this.lblValorDia = new System.Windows.Forms.Label();
            this.lblValorMensal = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.imgModalidade = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionarDiaHora = new System.Windows.Forms.Button();
            this.btnRemoverDiaHora = new System.Windows.Forms.Button();
            this.gpBoxHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaHora)).BeginInit();
            this.gpBoxModalidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgModalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxHorarios
            // 
            this.gpBoxHorarios.BackColor = System.Drawing.SystemColors.Control;
            this.gpBoxHorarios.Controls.Add(this.dataGridViewDiaHora);
            this.gpBoxHorarios.Controls.Add(this.btnAdicionarDiaHora);
            this.gpBoxHorarios.Controls.Add(this.btnRemoverDiaHora);
            this.gpBoxHorarios.Controls.Add(this.txtBoxHoraFim);
            this.gpBoxHorarios.Controls.Add(this.label1);
            this.gpBoxHorarios.Controls.Add(this.txtBoxHoraInicio);
            this.gpBoxHorarios.Controls.Add(this.label2);
            this.gpBoxHorarios.Controls.Add(this.cbBoxDia);
            this.gpBoxHorarios.Controls.Add(this.label3);
            this.gpBoxHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxHorarios.Location = new System.Drawing.Point(7, 228);
            this.gpBoxHorarios.Name = "gpBoxHorarios";
            this.gpBoxHorarios.Size = new System.Drawing.Size(651, 220);
            this.gpBoxHorarios.TabIndex = 2;
            this.gpBoxHorarios.TabStop = false;
            this.gpBoxHorarios.Text = "Horários:";
            // 
            // dataGridViewDiaHora
            // 
            this.dataGridViewDiaHora.AllowUserToAddRows = false;
            this.dataGridViewDiaHora.AllowUserToDeleteRows = false;
            this.dataGridViewDiaHora.AllowUserToResizeColumns = false;
            this.dataGridViewDiaHora.AllowUserToResizeRows = false;
            this.dataGridViewDiaHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiaHora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDia,
            this.colNomeDia,
            this.colHoraInicio,
            this.colHoraFim});
            this.dataGridViewDiaHora.Location = new System.Drawing.Point(311, 28);
            this.dataGridViewDiaHora.MultiSelect = false;
            this.dataGridViewDiaHora.Name = "dataGridViewDiaHora";
            this.dataGridViewDiaHora.ReadOnly = true;
            this.dataGridViewDiaHora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDiaHora.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewDiaHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiaHora.Size = new System.Drawing.Size(319, 177);
            this.dataGridViewDiaHora.TabIndex = 8;
            // 
            // colDia
            // 
            this.colDia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDia.DataPropertyName = "Dia";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDia.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDia.HeaderText = "Dia";
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            this.colDia.Visible = false;
            this.colDia.Width = 48;
            // 
            // colNomeDia
            // 
            this.colNomeDia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNomeDia.DataPropertyName = "NomeDia";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomeDia.DefaultCellStyle = dataGridViewCellStyle7;
            this.colNomeDia.HeaderText = "Dia";
            this.colNomeDia.Name = "colNomeDia";
            this.colNomeDia.ReadOnly = true;
            this.colNomeDia.Width = 58;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHoraInicio.DataPropertyName = "HoraInicio";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            this.colHoraInicio.DefaultCellStyle = dataGridViewCellStyle8;
            this.colHoraInicio.HeaderText = "Hora Inicio";
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            this.colHoraInicio.Width = 110;
            // 
            // colHoraFim
            // 
            this.colHoraFim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHoraFim.DataPropertyName = "HoraFim";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.colHoraFim.DefaultCellStyle = dataGridViewCellStyle9;
            this.colHoraFim.HeaderText = "Hora Fim";
            this.colHoraFim.Name = "colHoraFim";
            this.colHoraFim.ReadOnly = true;
            this.colHoraFim.Width = 99;
            // 
            // txtBoxHoraFim
            // 
            this.txtBoxHoraFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxHoraFim.Location = new System.Drawing.Point(148, 122);
            this.txtBoxHoraFim.Mask = "00:00";
            this.txtBoxHoraFim.Name = "txtBoxHoraFim";
            this.txtBoxHoraFim.Size = new System.Drawing.Size(111, 26);
            this.txtBoxHoraFim.TabIndex = 5;
            this.txtBoxHoraFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora Fim:";
            // 
            // txtBoxHoraInicio
            // 
            this.txtBoxHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxHoraInicio.Location = new System.Drawing.Point(11, 120);
            this.txtBoxHoraInicio.Mask = "00:00";
            this.txtBoxHoraInicio.Name = "txtBoxHoraInicio";
            this.txtBoxHoraInicio.Size = new System.Drawing.Size(114, 26);
            this.txtBoxHoraInicio.TabIndex = 3;
            this.txtBoxHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora Inicio:";
            // 
            // cbBoxDia
            // 
            this.cbBoxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbBoxDia.FormattingEnabled = true;
            this.cbBoxDia.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.cbBoxDia.Location = new System.Drawing.Point(11, 55);
            this.cbBoxDia.Name = "cbBoxDia";
            this.cbBoxDia.Size = new System.Drawing.Size(248, 28);
            this.cbBoxDia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dia:";
            // 
            // gpBoxModalidade
            // 
            this.gpBoxModalidade.Controls.Add(this.txtBoxAula);
            this.gpBoxModalidade.Controls.Add(this.txtBoxMensal);
            this.gpBoxModalidade.Controls.Add(this.lblValorDia);
            this.gpBoxModalidade.Controls.Add(this.lblValorMensal);
            this.gpBoxModalidade.Controls.Add(this.lblNome);
            this.gpBoxModalidade.Controls.Add(this.txtBoxCodigo);
            this.gpBoxModalidade.Controls.Add(this.lblCodigo);
            this.gpBoxModalidade.Controls.Add(this.txtBoxNome);
            this.gpBoxModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxModalidade.Location = new System.Drawing.Point(7, 107);
            this.gpBoxModalidade.Name = "gpBoxModalidade";
            this.gpBoxModalidade.Size = new System.Drawing.Size(651, 115);
            this.gpBoxModalidade.TabIndex = 1;
            this.gpBoxModalidade.TabStop = false;
            this.gpBoxModalidade.Text = "Modalidade:";
            // 
            // txtBoxAula
            // 
            this.txtBoxAula.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxAula.Location = new System.Drawing.Point(528, 61);
            this.txtBoxAula.Name = "txtBoxAula";
            this.txtBoxAula.Size = new System.Drawing.Size(110, 26);
            this.txtBoxAula.TabIndex = 7;
            // 
            // txtBoxMensal
            // 
            this.txtBoxMensal.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMensal.Location = new System.Drawing.Point(393, 61);
            this.txtBoxMensal.Name = "txtBoxMensal";
            this.txtBoxMensal.Size = new System.Drawing.Size(121, 26);
            this.txtBoxMensal.TabIndex = 5;
            // 
            // lblValorDia
            // 
            this.lblValorDia.AutoSize = true;
            this.lblValorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDia.Location = new System.Drawing.Point(524, 34);
            this.lblValorDia.Name = "lblValorDia";
            this.lblValorDia.Size = new System.Drawing.Size(102, 24);
            this.lblValorDia.TabIndex = 6;
            this.lblValorDia.Text = "Valor Aula:";
            // 
            // lblValorMensal
            // 
            this.lblValorMensal.AutoSize = true;
            this.lblValorMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMensal.Location = new System.Drawing.Point(389, 34);
            this.lblValorMensal.Name = "lblValorMensal";
            this.lblValorMensal.Size = new System.Drawing.Size(125, 24);
            this.lblValorMensal.TabIndex = 4;
            this.lblValorMensal.Text = "Valor Mensal:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(107, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCodigo.Enabled = false;
            this.txtBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(11, 61);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.ReadOnly = true;
            this.txtBoxCodigo.Size = new System.Drawing.Size(88, 26);
            this.txtBoxCodigo.TabIndex = 1;
            this.txtBoxCodigo.TabStop = false;
            this.txtBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(111, 61);
            this.txtBoxNome.MaxLength = 70;
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(268, 26);
            this.txtBoxNome.TabIndex = 3;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(195, 36);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(367, 39);
            this.lblCadastro.TabIndex = 63;
            this.lblCadastro.Text = "Cadastrar Modalidade:";
            // 
            // imgModalidade
            // 
            this.imgModalidade.Image = global::Principal.Properties.Resources.modalidade_add;
            this.imgModalidade.Location = new System.Drawing.Point(103, 12);
            this.imgModalidade.Name = "imgModalidade";
            this.imgModalidade.Size = new System.Drawing.Size(86, 86);
            this.imgModalidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgModalidade.TabIndex = 64;
            this.imgModalidade.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(441, 456);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 41);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(543, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionarDiaHora
            // 
            this.btnAdicionarDiaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarDiaHora.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDiaHora.Image")));
            this.btnAdicionarDiaHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarDiaHora.Location = new System.Drawing.Point(11, 164);
            this.btnAdicionarDiaHora.Name = "btnAdicionarDiaHora";
            this.btnAdicionarDiaHora.Size = new System.Drawing.Size(114, 41);
            this.btnAdicionarDiaHora.TabIndex = 6;
            this.btnAdicionarDiaHora.Text = "&Adicionar";
            this.btnAdicionarDiaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarDiaHora.UseVisualStyleBackColor = true;
            this.btnAdicionarDiaHora.Click += new System.EventHandler(this.btnAdicionarDiaHora_Click);
            // 
            // btnRemoverDiaHora
            // 
            this.btnRemoverDiaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverDiaHora.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverDiaHora.Image")));
            this.btnRemoverDiaHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverDiaHora.Location = new System.Drawing.Point(148, 164);
            this.btnRemoverDiaHora.Name = "btnRemoverDiaHora";
            this.btnRemoverDiaHora.Size = new System.Drawing.Size(111, 41);
            this.btnRemoverDiaHora.TabIndex = 7;
            this.btnRemoverDiaHora.Text = "&Remover";
            this.btnRemoverDiaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverDiaHora.UseVisualStyleBackColor = true;
            this.btnRemoverDiaHora.Click += new System.EventHandler(this.btnRemoverDiaHora_Click);
            // 
            // FrmGestaoModalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.imgModalidade);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.gpBoxModalidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpBoxHorarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestaoModalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Modalidade";
            this.Load += new System.EventHandler(this.FrmModalidadeCadastrar_Load);
            this.gpBoxHorarios.ResumeLayout(false);
            this.gpBoxHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaHora)).EndInit();
            this.gpBoxModalidade.ResumeLayout(false);
            this.gpBoxModalidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgModalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpBoxHorarios;
        private System.Windows.Forms.MaskedTextBox txtBoxHoraFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxHoraInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoxDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpBoxModalidade;
        private System.Windows.Forms.Label lblValorDia;
        private System.Windows.Forms.Label lblValorMensal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.DataGridView dataGridViewDiaHora;
        private System.Windows.Forms.Button btnAdicionarDiaHora;
        private System.Windows.Forms.Button btnRemoverDiaHora;
        private System.Windows.Forms.TextBox txtBoxAula;
        private System.Windows.Forms.TextBox txtBoxMensal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFim;
        private System.Windows.Forms.PictureBox imgModalidade;
        private System.Windows.Forms.Label lblCadastro;
    }
}