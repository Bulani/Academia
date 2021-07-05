namespace Principal
{
    partial class FrmAlunoSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunoSelecionar));
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharAluno = new System.Windows.Forms.Button();
            this.btnConsultarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnInserirAluno = new System.Windows.Forms.Button();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(176, 40);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(553, 29);
            this.txtBoxPesquisa.TabIndex = 3;
            this.txtBoxPesquisa.TextChanged += new System.EventHandler(this.txtBoxPesquisa_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(172, 11);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(74, 27);
            this.lblPesquisa.TabIndex = 2;
            this.lblPesquisa.Text = "Aluno:";
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
            this.colSexo,
            this.colNascimento,
            this.colCPF,
            this.colRG,
            this.colCidade,
            this.colLogradouro,
            this.colNumero,
            this.colBairro,
            this.colUF,
            this.colCEP,
            this.colAdmissao,
            this.colTelefone,
            this.colCelular,
            this.colSituacao});
            this.dataGridViewAluno.Location = new System.Drawing.Point(13, 83);
            this.dataGridViewAluno.MultiSelect = false;
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ReadOnly = true;
            this.dataGridViewAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAluno.Size = new System.Drawing.Size(858, 319);
            this.dataGridViewAluno.TabIndex = 5;
            this.dataGridViewAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAluno_CellContentClick);
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
            // colSexo
            // 
            this.colSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSexo.DataPropertyName = "Sexo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSexo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Width = 56;
            // 
            // colNascimento
            // 
            this.colNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNascimento.DataPropertyName = "Nascimento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.colNascimento.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNascimento.HeaderText = "Nascimento";
            this.colNascimento.Name = "colNascimento";
            this.colNascimento.ReadOnly = true;
            this.colNascimento.Width = 88;
            // 
            // colCPF
            // 
            this.colCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCPF.DataPropertyName = "CPF";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCPF.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            this.colCPF.Width = 52;
            // 
            // colRG
            // 
            this.colRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRG.DataPropertyName = "RG";
            this.colRG.HeaderText = "RG";
            this.colRG.Name = "colRG";
            this.colRG.ReadOnly = true;
            this.colRG.Width = 48;
            // 
            // colCidade
            // 
            this.colCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCidade.DataPropertyName = "Cidade";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCidade.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Width = 65;
            // 
            // colLogradouro
            // 
            this.colLogradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLogradouro.DataPropertyName = "Logradouro";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLogradouro.DefaultCellStyle = dataGridViewCellStyle9;
            this.colLogradouro.HeaderText = "Endereço";
            this.colLogradouro.Name = "colLogradouro";
            this.colLogradouro.ReadOnly = true;
            this.colLogradouro.Width = 78;
            // 
            // colNumero
            // 
            this.colNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNumero.DataPropertyName = "Numero";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumero.DefaultCellStyle = dataGridViewCellStyle10;
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 69;
            // 
            // colBairro
            // 
            this.colBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBairro.DataPropertyName = "Bairro";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colBairro.DefaultCellStyle = dataGridViewCellStyle11;
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Width = 59;
            // 
            // colUF
            // 
            this.colUF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUF.DataPropertyName = "UF";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUF.DefaultCellStyle = dataGridViewCellStyle12;
            this.colUF.HeaderText = "Estado";
            this.colUF.Name = "colUF";
            this.colUF.ReadOnly = true;
            this.colUF.Width = 65;
            // 
            // colCEP
            // 
            this.colCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCEP.DataPropertyName = "CEP";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCEP.DefaultCellStyle = dataGridViewCellStyle13;
            this.colCEP.HeaderText = "CEP";
            this.colCEP.Name = "colCEP";
            this.colCEP.ReadOnly = true;
            this.colCEP.Width = 53;
            // 
            // colAdmissao
            // 
            this.colAdmissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdmissao.DataPropertyName = "Admissao";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.colAdmissao.DefaultCellStyle = dataGridViewCellStyle14;
            this.colAdmissao.HeaderText = "Admissão";
            this.colAdmissao.Name = "colAdmissao";
            this.colAdmissao.ReadOnly = true;
            this.colAdmissao.Width = 77;
            // 
            // colTelefone
            // 
            this.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTelefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTelefone.DefaultCellStyle = dataGridViewCellStyle15;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 74;
            // 
            // colCelular
            // 
            this.colCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCelular.DataPropertyName = "Celular";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCelular.DefaultCellStyle = dataGridViewCellStyle16;
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            this.colCelular.Width = 64;
            // 
            // colSituacao
            // 
            this.colSituacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSituacao.DataPropertyName = "Situacao";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSituacao.DefaultCellStyle = dataGridViewCellStyle17;
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Visible = false;
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
            this.cbBoxTipoPesquisa.Location = new System.Drawing.Point(15, 40);
            this.cbBoxTipoPesquisa.Name = "cbBoxTipoPesquisa";
            this.cbBoxTipoPesquisa.Size = new System.Drawing.Size(141, 28);
            this.cbBoxTipoPesquisa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por:";
            // 
            // btnFecharAluno
            // 
            this.btnFecharAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharAluno.Image")));
            this.btnFecharAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharAluno.Location = new System.Drawing.Point(796, 412);
            this.btnFecharAluno.Name = "btnFecharAluno";
            this.btnFecharAluno.Size = new System.Drawing.Size(75, 39);
            this.btnFecharAluno.TabIndex = 10;
            this.btnFecharAluno.Text = "&Fechar";
            this.btnFecharAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharAluno.UseVisualStyleBackColor = true;
            this.btnFecharAluno.Click += new System.EventHandler(this.btnFecharAluno_Click);
            // 
            // btnConsultarAluno
            // 
            this.btnConsultarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarAluno.Image")));
            this.btnConsultarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAluno.Location = new System.Drawing.Point(619, 412);
            this.btnConsultarAluno.Name = "btnConsultarAluno";
            this.btnConsultarAluno.Size = new System.Drawing.Size(90, 39);
            this.btnConsultarAluno.TabIndex = 8;
            this.btnConsultarAluno.Text = "&Consultar";
            this.btnConsultarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarAluno.UseVisualStyleBackColor = true;
            this.btnConsultarAluno.Click += new System.EventHandler(this.btnConsultarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirAluno.Image")));
            this.btnExcluirAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirAluno.Location = new System.Drawing.Point(715, 412);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 39);
            this.btnExcluirAluno.TabIndex = 9;
            this.btnExcluirAluno.Text = "&Excluir";
            this.btnExcluirAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarAluno.Image")));
            this.btnAlterarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarAluno.Location = new System.Drawing.Point(538, 412);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 39);
            this.btnAlterarAluno.TabIndex = 7;
            this.btnAlterarAluno.Text = "&Alterar";
            this.btnAlterarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarAluno.UseVisualStyleBackColor = true;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnAlterarAluno_Click);
            // 
            // btnInserirAluno
            // 
            this.btnInserirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirAluno.Image")));
            this.btnInserirAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirAluno.Location = new System.Drawing.Point(457, 412);
            this.btnInserirAluno.Name = "btnInserirAluno";
            this.btnInserirAluno.Size = new System.Drawing.Size(75, 39);
            this.btnInserirAluno.TabIndex = 6;
            this.btnInserirAluno.Text = "&Inserir";
            this.btnInserirAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirAluno.UseVisualStyleBackColor = true;
            this.btnInserirAluno.Click += new System.EventHandler(this.btnInserirAluno_Click);
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarAluno.Image")));
            this.btnPesquisarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(745, 37);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisarAluno.TabIndex = 4;
            this.btnPesquisarAluno.Text = "&Pesquisar";
            this.btnPesquisarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarAluno.UseVisualStyleBackColor = true;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            this.btnPesquisarAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPesquisarAluno_KeyPress);
            // 
            // FrmAlunoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxTipoPesquisa);
            this.Controls.Add(this.dataGridViewAluno);
            this.Controls.Add(this.btnFecharAluno);
            this.Controls.Add(this.btnConsultarAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.btnInserirAluno);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FrmAlunoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.FrmAlunoSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFecharAluno;
        private System.Windows.Forms.Button btnConsultarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnInserirAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.ComboBox cbBoxTipoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
    }
}