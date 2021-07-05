namespace Principal
{
    partial class FrmGestaoFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoFuncionarios));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbBoxSituacao = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.picBoxFuncionario = new System.Windows.Forms.PictureBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.panelFuncionarios = new System.Windows.Forms.Panel();
            this.cbBoxFuncao = new System.Windows.Forms.ComboBox();
            this.txtBoxSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDemissao = new System.Windows.Forms.Label();
            this.dateDemissao = new System.Windows.Forms.DateTimePicker();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.txtBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxCPF = new System.Windows.Forms.MaskedTextBox();
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
            this.lblSituacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFuncionario)).BeginInit();
            this.panelFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(509, 392);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 41);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            "DEMITIDO"});
            this.cbBoxSituacao.Location = new System.Drawing.Point(17, 407);
            this.cbBoxSituacao.MaxDropDownItems = 4;
            this.cbBoxSituacao.Name = "cbBoxSituacao";
            this.cbBoxSituacao.Size = new System.Drawing.Size(136, 26);
            this.cbBoxSituacao.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(612, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // picBoxFuncionario
            // 
            this.picBoxFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFuncionario.Image")));
            this.picBoxFuncionario.Location = new System.Drawing.Point(136, 14);
            this.picBoxFuncionario.Name = "picBoxFuncionario";
            this.picBoxFuncionario.Size = new System.Drawing.Size(86, 86);
            this.picBoxFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFuncionario.TabIndex = 102;
            this.picBoxFuncionario.TabStop = false;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(228, 38);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(370, 39);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastrar Funcionário:";
            // 
            // panelFuncionarios
            // 
            this.panelFuncionarios.Controls.Add(this.lblSituacao);
            this.panelFuncionarios.Controls.Add(this.lblSalario);
            this.panelFuncionarios.Controls.Add(this.lblDemissao);
            this.panelFuncionarios.Controls.Add(this.lblFuncao);
            this.panelFuncionarios.Controls.Add(this.lblAdmissao);
            this.panelFuncionarios.Controls.Add(this.lblCidade);
            this.panelFuncionarios.Controls.Add(this.lblCPF);
            this.panelFuncionarios.Controls.Add(this.lblNascimento);
            this.panelFuncionarios.Controls.Add(this.lblSexo);
            this.panelFuncionarios.Controls.Add(this.lblNome);
            this.panelFuncionarios.Controls.Add(this.lblCodigo);
            this.panelFuncionarios.Controls.Add(this.lblCelular);
            this.panelFuncionarios.Controls.Add(this.lblTelefone);
            this.panelFuncionarios.Controls.Add(this.lblCEP);
            this.panelFuncionarios.Controls.Add(this.lblEstado);
            this.panelFuncionarios.Controls.Add(this.lblBairro);
            this.panelFuncionarios.Controls.Add(this.lblNumero);
            this.panelFuncionarios.Controls.Add(this.lblEndereco);
            this.panelFuncionarios.Controls.Add(this.lblRG);
            this.panelFuncionarios.Controls.Add(this.cbBoxFuncao);
            this.panelFuncionarios.Controls.Add(this.txtBoxSalario);
            this.panelFuncionarios.Controls.Add(this.dateDemissao);
            this.panelFuncionarios.Controls.Add(this.txtBoxCEP);
            this.panelFuncionarios.Controls.Add(this.txtBoxRG);
            this.panelFuncionarios.Controls.Add(this.txtBoxCPF);
            this.panelFuncionarios.Controls.Add(this.dateAdmissao);
            this.panelFuncionarios.Controls.Add(this.txtBoxCelular);
            this.panelFuncionarios.Controls.Add(this.txtBoxTelefone);
            this.panelFuncionarios.Controls.Add(this.dateNascimento);
            this.panelFuncionarios.Controls.Add(this.comboSexo);
            this.panelFuncionarios.Controls.Add(this.txtBoxBairro);
            this.panelFuncionarios.Controls.Add(this.txtBoxCidade);
            this.panelFuncionarios.Controls.Add(this.txtBoxCodigo);
            this.panelFuncionarios.Controls.Add(this.comboEstado);
            this.panelFuncionarios.Controls.Add(this.txtBoxNumero);
            this.panelFuncionarios.Controls.Add(this.txtBoxEndereco);
            this.panelFuncionarios.Controls.Add(this.txtBoxNome);
            this.panelFuncionarios.Location = new System.Drawing.Point(12, 106);
            this.panelFuncionarios.Name = "panelFuncionarios";
            this.panelFuncionarios.Size = new System.Drawing.Size(710, 295);
            this.panelFuncionarios.TabIndex = 1;
            // 
            // cbBoxFuncao
            // 
            this.cbBoxFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbBoxFuncao.FormattingEnabled = true;
            this.cbBoxFuncao.Location = new System.Drawing.Point(159, 234);
            this.cbBoxFuncao.Name = "cbBoxFuncao";
            this.cbBoxFuncao.Size = new System.Drawing.Size(128, 28);
            this.cbBoxFuncao.TabIndex = 29;
            // 
            // txtBoxSalario
            // 
            this.txtBoxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalario.Location = new System.Drawing.Point(581, 235);
            this.txtBoxSalario.MaxLength = 10;
            this.txtBoxSalario.Name = "txtBoxSalario";
            this.txtBoxSalario.Size = new System.Drawing.Size(128, 26);
            this.txtBoxSalario.TabIndex = 35;
            this.txtBoxSalario.Text = "0";
            this.txtBoxSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(577, 208);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(72, 24);
            this.lblSalario.TabIndex = 34;
            this.lblSalario.Text = "Salário:";
            // 
            // lblDemissao
            // 
            this.lblDemissao.AutoSize = true;
            this.lblDemissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemissao.Location = new System.Drawing.Point(441, 208);
            this.lblDemissao.Name = "lblDemissao";
            this.lblDemissao.Size = new System.Drawing.Size(98, 24);
            this.lblDemissao.TabIndex = 32;
            this.lblDemissao.Text = "Demissão:";
            // 
            // dateDemissao
            // 
            this.dateDemissao.CustomFormat = "\"\"";
            this.dateDemissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDemissao.Location = new System.Drawing.Point(445, 235);
            this.dateDemissao.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateDemissao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateDemissao.Name = "dateDemissao";
            this.dateDemissao.Size = new System.Drawing.Size(117, 26);
            this.dateDemissao.TabIndex = 33;
            this.dateDemissao.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncao.Location = new System.Drawing.Point(155, 208);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(80, 24);
            this.lblFuncao.TabIndex = 28;
            this.lblFuncao.Text = "Função:";
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissao.Location = new System.Drawing.Point(302, 208);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(103, 24);
            this.lblAdmissao.TabIndex = 30;
            this.lblAdmissao.Text = " Admissão:";
            // 
            // txtBoxCEP
            // 
            this.txtBoxCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCEP.Location = new System.Drawing.Point(379, 167);
            this.txtBoxCEP.Mask = "00000-000";
            this.txtBoxCEP.Name = "txtBoxCEP";
            this.txtBoxCEP.Size = new System.Drawing.Size(97, 26);
            this.txtBoxCEP.TabIndex = 21;
            this.txtBoxCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxRG
            // 
            this.txtBoxRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRG.Location = new System.Drawing.Point(147, 101);
            this.txtBoxRG.Mask = "00,000,000-0";
            this.txtBoxRG.Name = "txtBoxRG";
            this.txtBoxRG.Size = new System.Drawing.Size(104, 26);
            this.txtBoxRG.TabIndex = 11;
            this.txtBoxRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPF.Location = new System.Drawing.Point(5, 101);
            this.txtBoxCPF.Mask = "000,000,000-00";
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(126, 26);
            this.txtBoxCPF.TabIndex = 9;
            this.txtBoxCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dateAdmissao
            // 
            this.dateAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAdmissao.Location = new System.Drawing.Point(306, 235);
            this.dateAdmissao.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateAdmissao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateAdmissao.Name = "dateAdmissao";
            this.dateAdmissao.Size = new System.Drawing.Size(117, 26);
            this.dateAdmissao.TabIndex = 31;
            this.dateAdmissao.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            // 
            // txtBoxCelular
            // 
            this.txtBoxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCelular.Location = new System.Drawing.Point(5, 235);
            this.txtBoxCelular.Mask = "(00) 00000-0000";
            this.txtBoxCelular.Name = "txtBoxCelular";
            this.txtBoxCelular.Size = new System.Drawing.Size(134, 26);
            this.txtBoxCelular.TabIndex = 27;
            this.txtBoxCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefone.Location = new System.Drawing.Point(586, 167);
            this.txtBoxTelefone.Mask = "(00) 0000-0000";
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(123, 26);
            this.txtBoxTelefone.TabIndex = 25;
            this.txtBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dateNascimento
            // 
            this.dateNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNascimento.Location = new System.Drawing.Point(592, 35);
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
            this.comboSexo.Location = new System.Drawing.Point(487, 35);
            this.comboSexo.MaxDropDownItems = 2;
            this.comboSexo.MaxLength = 1;
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(89, 26);
            this.comboSexo.TabIndex = 5;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBairro.Location = new System.Drawing.Point(112, 167);
            this.txtBoxBairro.MaxLength = 30;
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(244, 26);
            this.txtBoxBairro.TabIndex = 19;
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCidade.Location = new System.Drawing.Point(274, 101);
            this.txtBoxCidade.MaxLength = 30;
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(210, 26);
            this.txtBoxCidade.TabIndex = 13;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(270, 74);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 24);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(1, 74);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 24);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(588, 8);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(115, 24);
            this.lblNascimento.TabIndex = 6;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(483, 8);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 24);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(108, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Enabled = false;
            this.txtBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(5, 35);
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
            this.lblCodigo.Location = new System.Drawing.Point(1, 8);
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
            this.comboEstado.Location = new System.Drawing.Point(499, 167);
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
            this.lblCelular.Location = new System.Drawing.Point(1, 208);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(74, 24);
            this.lblCelular.TabIndex = 26;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(582, 140);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(90, 24);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(375, 140);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(53, 24);
            this.lblCEP.TabIndex = 20;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(495, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 24);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(108, 140);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(64, 24);
            this.lblBairro.TabIndex = 18;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero.Location = new System.Drawing.Point(5, 167);
            this.txtBoxNumero.MaxLength = 6;
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(80, 26);
            this.txtBoxNumero.TabIndex = 17;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(1, 140);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 24);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Número:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEndereco.Location = new System.Drawing.Point(499, 101);
            this.txtBoxEndereco.MaxLength = 30;
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(210, 26);
            this.txtBoxEndereco.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(495, 74);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(99, 24);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(143, 74);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(42, 24);
            this.lblRG.TabIndex = 10;
            this.lblRG.Text = "RG:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(112, 35);
            this.txtBoxNome.MaxLength = 70;
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(356, 26);
            this.txtBoxNome.TabIndex = 3;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSituacao.Location = new System.Drawing.Point(1, 271);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(87, 24);
            this.lblSituacao.TabIndex = 36;
            this.lblSituacao.Text = "Situação:";
            // 
            // FrmFuncionarioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 446);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbBoxSituacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.picBoxFuncionario);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.panelFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 485);
            this.Name = "FrmFuncionarioCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFuncionario)).EndInit();
            this.panelFuncionarios.ResumeLayout(false);
            this.panelFuncionarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbBoxSituacao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox picBoxFuncionario;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Panel panelFuncionarios;
        private System.Windows.Forms.ComboBox cbBoxFuncao;
        private System.Windows.Forms.TextBox txtBoxSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDemissao;
        private System.Windows.Forms.DateTimePicker dateDemissao;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.MaskedTextBox txtBoxCEP;
        private System.Windows.Forms.MaskedTextBox txtBoxRG;
        private System.Windows.Forms.MaskedTextBox txtBoxCPF;
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
        private System.Windows.Forms.Label lblSituacao;
    }
}