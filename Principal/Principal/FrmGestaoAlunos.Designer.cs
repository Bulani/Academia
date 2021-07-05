namespace Principal
{
    partial class FrmGestaoAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoAlunos));
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelAlunos = new System.Windows.Forms.Panel();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtBoxApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.txtBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbBoxSituacao = new System.Windows.Forms.ComboBox();
            this.dateAdmissao = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.txtBoxCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(265, 36);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(277, 39);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastrar Aluno:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(482, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 41);
            this.btnSalvar.TabIndex = 2;
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
            this.btnCancelar.Location = new System.Drawing.Point(585, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelAlunos
            // 
            this.panelAlunos.Controls.Add(this.lblSituacao);
            this.panelAlunos.Controls.Add(this.txtBoxApelido);
            this.panelAlunos.Controls.Add(this.lblApelido);
            this.panelAlunos.Controls.Add(this.lblAdmissao);
            this.panelAlunos.Controls.Add(this.txtBoxCEP);
            this.panelAlunos.Controls.Add(this.txtBoxRG);
            this.panelAlunos.Controls.Add(this.txtBoxCPF);
            this.panelAlunos.Controls.Add(this.cbBoxSituacao);
            this.panelAlunos.Controls.Add(this.dateAdmissao);
            this.panelAlunos.Controls.Add(this.txtBoxCelular);
            this.panelAlunos.Controls.Add(this.txtBoxTelefone);
            this.panelAlunos.Controls.Add(this.dateNascimento);
            this.panelAlunos.Controls.Add(this.comboSexo);
            this.panelAlunos.Controls.Add(this.txtBoxBairro);
            this.panelAlunos.Controls.Add(this.txtBoxCidade);
            this.panelAlunos.Controls.Add(this.lblCidade);
            this.panelAlunos.Controls.Add(this.lblCPF);
            this.panelAlunos.Controls.Add(this.lblNascimento);
            this.panelAlunos.Controls.Add(this.lblSexo);
            this.panelAlunos.Controls.Add(this.lblNome);
            this.panelAlunos.Controls.Add(this.txtBoxCodigo);
            this.panelAlunos.Controls.Add(this.lblCodigo);
            this.panelAlunos.Controls.Add(this.comboEstado);
            this.panelAlunos.Controls.Add(this.lblCelular);
            this.panelAlunos.Controls.Add(this.lblTelefone);
            this.panelAlunos.Controls.Add(this.lblCEP);
            this.panelAlunos.Controls.Add(this.lblEstado);
            this.panelAlunos.Controls.Add(this.lblBairro);
            this.panelAlunos.Controls.Add(this.txtBoxNumero);
            this.panelAlunos.Controls.Add(this.lblNumero);
            this.panelAlunos.Controls.Add(this.txtBoxEndereco);
            this.panelAlunos.Controls.Add(this.lblEndereco);
            this.panelAlunos.Controls.Add(this.lblRG);
            this.panelAlunos.Controls.Add(this.txtBoxNome);
            this.panelAlunos.Location = new System.Drawing.Point(10, 105);
            this.panelAlunos.Name = "panelAlunos";
            this.panelAlunos.Size = new System.Drawing.Size(694, 268);
            this.panelAlunos.TabIndex = 1;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSituacao.Location = new System.Drawing.Point(544, 208);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(87, 24);
            this.lblSituacao.TabIndex = 32;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtBoxApelido
            // 
            this.txtBoxApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxApelido.Location = new System.Drawing.Point(15, 98);
            this.txtBoxApelido.MaxLength = 30;
            this.txtBoxApelido.Name = "txtBoxApelido";
            this.txtBoxApelido.Size = new System.Drawing.Size(170, 26);
            this.txtBoxApelido.TabIndex = 9;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(11, 71);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(80, 24);
            this.lblApelido.TabIndex = 8;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissao.Location = new System.Drawing.Point(409, 209);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(103, 24);
            this.lblAdmissao.TabIndex = 30;
            this.lblAdmissao.Text = " Admissão:";
            // 
            // txtBoxCEP
            // 
            this.txtBoxCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCEP.Location = new System.Drawing.Point(15, 236);
            this.txtBoxCEP.Mask = "00000-000";
            this.txtBoxCEP.Name = "txtBoxCEP";
            this.txtBoxCEP.Size = new System.Drawing.Size(97, 26);
            this.txtBoxCEP.TabIndex = 25;
            this.txtBoxCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxRG
            // 
            this.txtBoxRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRG.Location = new System.Drawing.Point(352, 98);
            this.txtBoxRG.Mask = "00,000,000-0";
            this.txtBoxRG.Name = "txtBoxRG";
            this.txtBoxRG.Size = new System.Drawing.Size(104, 26);
            this.txtBoxRG.TabIndex = 13;
            this.txtBoxRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPF.Location = new System.Drawing.Point(210, 98);
            this.txtBoxCPF.Mask = "000,000,000-00";
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(126, 26);
            this.txtBoxCPF.TabIndex = 11;
            this.txtBoxCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbBoxSituacao
            // 
            this.cbBoxSituacao.DisplayMember = "0";
            this.cbBoxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbBoxSituacao.FormattingEnabled = true;
            this.cbBoxSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "SUSPENSO",
            "INADIMPLENTE"});
            this.cbBoxSituacao.Location = new System.Drawing.Point(548, 236);
            this.cbBoxSituacao.MaxDropDownItems = 4;
            this.cbBoxSituacao.Name = "cbBoxSituacao";
            this.cbBoxSituacao.Size = new System.Drawing.Size(136, 26);
            this.cbBoxSituacao.TabIndex = 33;
            // 
            // dateAdmissao
            // 
            this.dateAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAdmissao.Location = new System.Drawing.Point(413, 236);
            this.dateAdmissao.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateAdmissao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateAdmissao.Name = "dateAdmissao";
            this.dateAdmissao.Size = new System.Drawing.Size(117, 26);
            this.dateAdmissao.TabIndex = 31;
            this.dateAdmissao.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // txtBoxCelular
            // 
            this.txtBoxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCelular.Location = new System.Drawing.Point(266, 236);
            this.txtBoxCelular.Mask = "(00) 00000-0000";
            this.txtBoxCelular.Name = "txtBoxCelular";
            this.txtBoxCelular.Size = new System.Drawing.Size(134, 26);
            this.txtBoxCelular.TabIndex = 29;
            this.txtBoxCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefone.Location = new System.Drawing.Point(126, 236);
            this.txtBoxTelefone.Mask = "(00) 0000-0000";
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(123, 26);
            this.txtBoxTelefone.TabIndex = 27;
            this.txtBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dateNascimento
            // 
            this.dateNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNascimento.Location = new System.Drawing.Point(567, 34);
            this.dateNascimento.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(117, 26);
            this.dateNascimento.TabIndex = 7;
            this.dateNascimento.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // comboSexo
            // 
            this.comboSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(462, 34);
            this.comboSexo.MaxDropDownItems = 2;
            this.comboSexo.MaxLength = 1;
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(89, 26);
            this.comboSexo.TabIndex = 5;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBairro.Location = new System.Drawing.Point(373, 163);
            this.txtBoxBairro.MaxLength = 30;
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(210, 26);
            this.txtBoxBairro.TabIndex = 21;
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCidade.Location = new System.Drawing.Point(474, 98);
            this.txtBoxCidade.MaxLength = 30;
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(210, 26);
            this.txtBoxCidade.TabIndex = 15;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(470, 71);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 24);
            this.lblCidade.TabIndex = 14;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(206, 71);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 24);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(563, 7);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(115, 24);
            this.lblNascimento.TabIndex = 6;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(458, 7);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 24);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(118, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Enabled = false;
            this.txtBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(15, 34);
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
            this.lblCodigo.Location = new System.Drawing.Point(11, 7);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // comboEstado
            // 
            this.comboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboEstado.Location = new System.Drawing.Point(615, 164);
            this.comboEstado.MaximumSize = new System.Drawing.Size(170, 0);
            this.comboEstado.MaxLength = 2;
            this.comboEstado.MinimumSize = new System.Drawing.Size(10, 0);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(69, 26);
            this.comboEstado.TabIndex = 23;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(262, 209);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(74, 24);
            this.lblCelular.TabIndex = 28;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(122, 209);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(90, 24);
            this.lblTelefone.TabIndex = 26;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(11, 209);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(53, 24);
            this.lblCEP.TabIndex = 24;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(611, 137);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 24);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(369, 136);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(64, 24);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero.Location = new System.Drawing.Point(256, 164);
            this.txtBoxNumero.MaxLength = 6;
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(80, 26);
            this.txtBoxNumero.TabIndex = 19;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(252, 137);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 24);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Número:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEndereco.Location = new System.Drawing.Point(15, 164);
            this.txtBoxEndereco.MaxLength = 30;
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(210, 26);
            this.txtBoxEndereco.TabIndex = 17;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(11, 137);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(99, 24);
            this.lblEndereco.TabIndex = 16;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(348, 71);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(42, 24);
            this.lblRG.TabIndex = 12;
            this.lblRG.Text = "RG:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(122, 34);
            this.txtBoxNome.MaxLength = 60;
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(324, 26);
            this.txtBoxNome.TabIndex = 3;
            // 
            // FrmAlunoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 436);
            this.Controls.Add(this.panelAlunos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 475);
            this.Name = "FrmAlunoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAlunos.ResumeLayout(false);
            this.panelAlunos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelAlunos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtBoxApelido;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.MaskedTextBox txtBoxCEP;
        private System.Windows.Forms.MaskedTextBox txtBoxRG;
        private System.Windows.Forms.MaskedTextBox txtBoxCPF;
        private System.Windows.Forms.ComboBox cbBoxSituacao;
        private System.Windows.Forms.DateTimePicker dateAdmissao;
        private System.Windows.Forms.MaskedTextBox txtBoxCelular;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefone;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.TextBox txtBoxCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtBoxNome;
    }
}