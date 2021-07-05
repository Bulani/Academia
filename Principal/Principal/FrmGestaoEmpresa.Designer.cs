namespace Principal
{
    partial class FrmGestaoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoEmpresa));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.picBoxEmpresa = new System.Windows.Forms.PictureBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.panelEmpresa = new System.Windows.Forms.Panel();
            this.txtBoxCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxRazao = new System.Windows.Forms.TextBox();
            this.lblFundacao = new System.Windows.Forms.Label();
            this.txtBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.dateFundacao = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.txtBoxIE = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazao = new System.Windows.Forms.Label();
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
            this.lblIE = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxResponsavel = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblResponsavel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmpresa)).BeginInit();
            this.panelEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(393, 399);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 41);
            this.btnSalvar.TabIndex = 4;
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
            this.btnCancelar.Location = new System.Drawing.Point(597, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 41);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // picBoxEmpresa
            // 
            this.picBoxEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEmpresa.Image")));
            this.picBoxEmpresa.Location = new System.Drawing.Point(148, 12);
            this.picBoxEmpresa.Name = "picBoxEmpresa";
            this.picBoxEmpresa.Size = new System.Drawing.Size(86, 86);
            this.picBoxEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEmpresa.TabIndex = 102;
            this.picBoxEmpresa.TabStop = false;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(247, 36);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(329, 39);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastrar Empresa:";
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.Controls.Add(this.lblResponsavel);
            this.panelEmpresa.Controls.Add(this.txtBoxCidade);
            this.panelEmpresa.Controls.Add(this.lblCidade);
            this.panelEmpresa.Controls.Add(this.txtBoxEmail);
            this.panelEmpresa.Controls.Add(this.lblEmail);
            this.panelEmpresa.Controls.Add(this.txtBoxRazao);
            this.panelEmpresa.Controls.Add(this.lblFundacao);
            this.panelEmpresa.Controls.Add(this.txtBoxCEP);
            this.panelEmpresa.Controls.Add(this.txtBoxCNPJ);
            this.panelEmpresa.Controls.Add(this.dateFundacao);
            this.panelEmpresa.Controls.Add(this.txtBoxCelular);
            this.panelEmpresa.Controls.Add(this.txtBoxTelefone);
            this.panelEmpresa.Controls.Add(this.txtBoxBairro);
            this.panelEmpresa.Controls.Add(this.txtBoxIE);
            this.panelEmpresa.Controls.Add(this.lblCNPJ);
            this.panelEmpresa.Controls.Add(this.lblRazao);
            this.panelEmpresa.Controls.Add(this.lblNome);
            this.panelEmpresa.Controls.Add(this.txtBoxCodigo);
            this.panelEmpresa.Controls.Add(this.lblCodigo);
            this.panelEmpresa.Controls.Add(this.comboEstado);
            this.panelEmpresa.Controls.Add(this.lblCelular);
            this.panelEmpresa.Controls.Add(this.lblTelefone);
            this.panelEmpresa.Controls.Add(this.lblCEP);
            this.panelEmpresa.Controls.Add(this.lblEstado);
            this.panelEmpresa.Controls.Add(this.lblBairro);
            this.panelEmpresa.Controls.Add(this.txtBoxNumero);
            this.panelEmpresa.Controls.Add(this.lblNumero);
            this.panelEmpresa.Controls.Add(this.txtBoxEndereco);
            this.panelEmpresa.Controls.Add(this.lblEndereco);
            this.panelEmpresa.Controls.Add(this.lblIE);
            this.panelEmpresa.Controls.Add(this.txtBoxNome);
            this.panelEmpresa.Location = new System.Drawing.Point(12, 104);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(700, 306);
            this.panelEmpresa.TabIndex = 1;
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCidade.Location = new System.Drawing.Point(457, 106);
            this.txtBoxCidade.MaxLength = 30;
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(237, 26);
            this.txtBoxCidade.TabIndex = 13;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(453, 81);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 24);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(435, 238);
            this.txtBoxEmail.MaxLength = 40;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(259, 26);
            this.txtBoxEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(431, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 24);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtBoxRazao
            // 
            this.txtBoxRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRazao.Location = new System.Drawing.Point(412, 40);
            this.txtBoxRazao.MaxLength = 70;
            this.txtBoxRazao.Name = "txtBoxRazao";
            this.txtBoxRazao.Size = new System.Drawing.Size(282, 26);
            this.txtBoxRazao.TabIndex = 5;
            // 
            // lblFundacao
            // 
            this.lblFundacao.AutoSize = true;
            this.lblFundacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundacao.Location = new System.Drawing.Point(323, 79);
            this.lblFundacao.Name = "lblFundacao";
            this.lblFundacao.Size = new System.Drawing.Size(101, 24);
            this.lblFundacao.TabIndex = 10;
            this.lblFundacao.Text = "Fundação:";
            // 
            // txtBoxCEP
            // 
            this.txtBoxCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCEP.Location = new System.Drawing.Point(597, 174);
            this.txtBoxCEP.Mask = "00000-000";
            this.txtBoxCEP.Name = "txtBoxCEP";
            this.txtBoxCEP.Size = new System.Drawing.Size(97, 26);
            this.txtBoxCEP.TabIndex = 21;
            this.txtBoxCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxCNPJ
            // 
            this.txtBoxCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCNPJ.Location = new System.Drawing.Point(10, 106);
            this.txtBoxCNPJ.Mask = "00,000,000 /0000-00";
            this.txtBoxCNPJ.Name = "txtBoxCNPJ";
            this.txtBoxCNPJ.Size = new System.Drawing.Size(161, 26);
            this.txtBoxCNPJ.TabIndex = 7;
            this.txtBoxCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dateFundacao
            // 
            this.dateFundacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFundacao.Location = new System.Drawing.Point(327, 106);
            this.dateFundacao.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateFundacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateFundacao.Name = "dateFundacao";
            this.dateFundacao.Size = new System.Drawing.Size(117, 26);
            this.dateFundacao.TabIndex = 11;
            this.dateFundacao.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // txtBoxCelular
            // 
            this.txtBoxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCelular.Location = new System.Drawing.Point(266, 238);
            this.txtBoxCelular.Mask = "(00) 00000-0000";
            this.txtBoxCelular.Name = "txtBoxCelular";
            this.txtBoxCelular.Size = new System.Drawing.Size(134, 26);
            this.txtBoxCelular.TabIndex = 27;
            this.txtBoxCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefone.Location = new System.Drawing.Point(112, 238);
            this.txtBoxTelefone.Mask = "(00) 0000-0000";
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(123, 26);
            this.txtBoxTelefone.TabIndex = 25;
            this.txtBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBairro.Location = new System.Drawing.Point(265, 174);
            this.txtBoxBairro.MaxLength = 30;
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(212, 26);
            this.txtBoxBairro.TabIndex = 17;
            // 
            // txtBoxIE
            // 
            this.txtBoxIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIE.Location = new System.Drawing.Point(184, 106);
            this.txtBoxIE.MaxLength = 13;
            this.txtBoxIE.Name = "txtBoxIE";
            this.txtBoxIE.Size = new System.Drawing.Size(127, 26);
            this.txtBoxIE.TabIndex = 13;
            this.txtBoxIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(6, 79);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(63, 24);
            this.lblCNPJ.TabIndex = 6;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazao.Location = new System.Drawing.Point(408, 13);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(124, 24);
            this.lblRazao.TabIndex = 4;
            this.lblRazao.Text = "Razão Social:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(113, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(142, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome Fantasia:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Enabled = false;
            this.txtBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(10, 40);
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
            this.lblCodigo.Location = new System.Drawing.Point(6, 13);
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
            this.comboEstado.Location = new System.Drawing.Point(10, 238);
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
            this.lblCelular.Location = new System.Drawing.Point(264, 211);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(74, 24);
            this.lblCelular.TabIndex = 26;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(108, 211);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(90, 24);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(593, 147);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(53, 24);
            this.lblCEP.TabIndex = 20;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(6, 211);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 24);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(261, 147);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(64, 24);
            this.lblBairro.TabIndex = 16;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero.Location = new System.Drawing.Point(496, 174);
            this.txtBoxNumero.MaxLength = 6;
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(80, 26);
            this.txtBoxNumero.TabIndex = 19;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(492, 147);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 24);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Número:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEndereco.Location = new System.Drawing.Point(10, 174);
            this.txtBoxEndereco.MaxLength = 30;
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(237, 26);
            this.txtBoxEndereco.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(6, 149);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(99, 24);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIE.Location = new System.Drawing.Point(180, 79);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(32, 24);
            this.lblIE.TabIndex = 8;
            this.lblIE.Text = "IE:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(117, 40);
            this.txtBoxNome.MaxLength = 70;
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(267, 26);
            this.txtBoxNome.TabIndex = 3;
            // 
            // txtBoxResponsavel
            // 
            this.txtBoxResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResponsavel.Location = new System.Drawing.Point(22, 406);
            this.txtBoxResponsavel.MaxLength = 60;
            this.txtBoxResponsavel.Name = "txtBoxResponsavel";
            this.txtBoxResponsavel.Size = new System.Drawing.Size(253, 26);
            this.txtBoxResponsavel.TabIndex = 3;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(495, 399);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 41);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsavel.Location = new System.Drawing.Point(6, 275);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(124, 24);
            this.lblResponsavel.TabIndex = 30;
            this.lblResponsavel.Text = "Responsável:";
            // 
            // FrmEmpresaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 451);
            this.Controls.Add(this.txtBoxResponsavel);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.picBoxEmpresa);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.panelEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(740, 490);
            this.Name = "FrmEmpresaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmpresa)).EndInit();
            this.panelEmpresa.ResumeLayout(false);
            this.panelEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox picBoxEmpresa;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Panel panelEmpresa;
        private System.Windows.Forms.TextBox txtBoxResponsavel;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxRazao;
        private System.Windows.Forms.Label lblFundacao;
        private System.Windows.Forms.MaskedTextBox txtBoxCEP;
        private System.Windows.Forms.MaskedTextBox txtBoxCNPJ;
        private System.Windows.Forms.DateTimePicker dateFundacao;
        private System.Windows.Forms.MaskedTextBox txtBoxCelular;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefone;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.TextBox txtBoxIE;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazao;
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
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtBoxCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblResponsavel;
    }
}