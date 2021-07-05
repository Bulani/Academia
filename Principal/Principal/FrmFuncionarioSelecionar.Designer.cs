namespace Principal
{
    partial class FrmFuncionarioSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarioSelecionar));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            this.btnFecharFunc = new System.Windows.Forms.Button();
            this.btnConsultarFunc = new System.Windows.Forms.Button();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnAlterarFunc = new System.Windows.Forms.Button();
            this.btnInserirFunc = new System.Windows.Forms.Button();
            this.btnPesquisarFunc = new System.Windows.Forms.Button();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colDemissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.AllowUserToAddRows = false;
            this.dataGridViewFuncionario.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionario.AllowUserToOrderColumns = true;
            this.dataGridViewFuncionario.AllowUserToResizeColumns = false;
            this.dataGridViewFuncionario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFuncionario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNomeP,
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
            this.colDemissao,
            this.colTelefone,
            this.colCelular,
            this.colFuncao,
            this.colSalario});
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(14, 82);
            this.dataGridViewFuncionario.MultiSelect = false;
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            this.dataGridViewFuncionario.ReadOnly = true;
            this.dataGridViewFuncionario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(858, 319);
            this.dataGridViewFuncionario.TabIndex = 3;
            // 
            // btnFecharFunc
            // 
            this.btnFecharFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharFunc.Image")));
            this.btnFecharFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharFunc.Location = new System.Drawing.Point(797, 411);
            this.btnFecharFunc.Name = "btnFecharFunc";
            this.btnFecharFunc.Size = new System.Drawing.Size(75, 39);
            this.btnFecharFunc.TabIndex = 8;
            this.btnFecharFunc.Text = "&Fechar";
            this.btnFecharFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharFunc.UseVisualStyleBackColor = true;
            this.btnFecharFunc.Click += new System.EventHandler(this.btnFecharFunc_Click);
            // 
            // btnConsultarFunc
            // 
            this.btnConsultarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarFunc.Image")));
            this.btnConsultarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFunc.Location = new System.Drawing.Point(620, 411);
            this.btnConsultarFunc.Name = "btnConsultarFunc";
            this.btnConsultarFunc.Size = new System.Drawing.Size(90, 39);
            this.btnConsultarFunc.TabIndex = 6;
            this.btnConsultarFunc.Text = "&Consultar";
            this.btnConsultarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarFunc.UseVisualStyleBackColor = true;
            this.btnConsultarFunc.Click += new System.EventHandler(this.btnConsultarFunc_Click);
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirFunc.Image")));
            this.btnExcluirFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirFunc.Location = new System.Drawing.Point(716, 411);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(75, 39);
            this.btnExcluirFunc.TabIndex = 7;
            this.btnExcluirFunc.Text = "&Excluir";
            this.btnExcluirFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // btnAlterarFunc
            // 
            this.btnAlterarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarFunc.Image")));
            this.btnAlterarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFunc.Location = new System.Drawing.Point(539, 411);
            this.btnAlterarFunc.Name = "btnAlterarFunc";
            this.btnAlterarFunc.Size = new System.Drawing.Size(75, 39);
            this.btnAlterarFunc.TabIndex = 5;
            this.btnAlterarFunc.Text = "&Alterar";
            this.btnAlterarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarFunc.UseVisualStyleBackColor = true;
            this.btnAlterarFunc.Click += new System.EventHandler(this.btnAlterarFunc_Click);
            // 
            // btnInserirFunc
            // 
            this.btnInserirFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirFunc.Image")));
            this.btnInserirFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirFunc.Location = new System.Drawing.Point(458, 411);
            this.btnInserirFunc.Name = "btnInserirFunc";
            this.btnInserirFunc.Size = new System.Drawing.Size(75, 39);
            this.btnInserirFunc.TabIndex = 4;
            this.btnInserirFunc.Text = "&Inserir";
            this.btnInserirFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirFunc.UseVisualStyleBackColor = true;
            this.btnInserirFunc.Click += new System.EventHandler(this.btnInserirFunc_Click);
            // 
            // btnPesquisarFunc
            // 
            this.btnPesquisarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarFunc.Image")));
            this.btnPesquisarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarFunc.Location = new System.Drawing.Point(666, 36);
            this.btnPesquisarFunc.Name = "btnPesquisarFunc";
            this.btnPesquisarFunc.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisarFunc.TabIndex = 2;
            this.btnPesquisarFunc.Text = "&Pesquisar";
            this.btnPesquisarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarFunc.UseVisualStyleBackColor = true;
            this.btnPesquisarFunc.Click += new System.EventHandler(this.btnPesquisarFunc_Click);
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(97, 39);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(553, 29);
            this.txtBoxPesquisa.TabIndex = 1;
            this.txtBoxPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPesquisa_KeyPress);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(93, 10);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(126, 27);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Funcionário:";
            // 
            // colCodigo
            // 
            this.colCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCodigo.DataPropertyName = "IdFuncionario";
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
            // colSexo
            // 
            this.colSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSexo.DataPropertyName = "Sexo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSexo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Width = 56;
            // 
            // colNascimento
            // 
            this.colNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNascimento.DataPropertyName = "Nascimento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colNascimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNascimento.HeaderText = "Nascimento";
            this.colNascimento.Name = "colNascimento";
            this.colNascimento.ReadOnly = true;
            this.colNascimento.Width = 88;
            // 
            // colCPF
            // 
            this.colCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCPF.DataPropertyName = "CPF";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCPF.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCidade.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Width = 65;
            // 
            // colLogradouro
            // 
            this.colLogradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLogradouro.DataPropertyName = "Logradouro";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLogradouro.DefaultCellStyle = dataGridViewCellStyle8;
            this.colLogradouro.HeaderText = "Endereço";
            this.colLogradouro.Name = "colLogradouro";
            this.colLogradouro.ReadOnly = true;
            this.colLogradouro.Width = 78;
            // 
            // colNumero
            // 
            this.colNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNumero.DataPropertyName = "Numero";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumero.DefaultCellStyle = dataGridViewCellStyle9;
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 69;
            // 
            // colBairro
            // 
            this.colBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBairro.DataPropertyName = "Bairro";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colBairro.DefaultCellStyle = dataGridViewCellStyle10;
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Width = 59;
            // 
            // colUF
            // 
            this.colUF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUF.DataPropertyName = "UF";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUF.DefaultCellStyle = dataGridViewCellStyle11;
            this.colUF.HeaderText = "Estado";
            this.colUF.Name = "colUF";
            this.colUF.ReadOnly = true;
            this.colUF.Width = 65;
            // 
            // colCEP
            // 
            this.colCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCEP.DataPropertyName = "CEP";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCEP.DefaultCellStyle = dataGridViewCellStyle12;
            this.colCEP.HeaderText = "CEP";
            this.colCEP.Name = "colCEP";
            this.colCEP.ReadOnly = true;
            this.colCEP.Width = 53;
            // 
            // colAdmissao
            // 
            this.colAdmissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdmissao.DataPropertyName = "Admissao";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.colAdmissao.DefaultCellStyle = dataGridViewCellStyle13;
            this.colAdmissao.HeaderText = "Admissão";
            this.colAdmissao.Name = "colAdmissao";
            this.colAdmissao.ReadOnly = true;
            this.colAdmissao.Width = 77;
            // 
            // colDemissao
            // 
            this.colDemissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDemissao.DataPropertyName = "Demissao";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.colDemissao.DefaultCellStyle = dataGridViewCellStyle14;
            this.colDemissao.HeaderText = "Demissão";
            this.colDemissao.Name = "colDemissao";
            this.colDemissao.ReadOnly = true;
            this.colDemissao.Width = 78;
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
            // colFuncao
            // 
            this.colFuncao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFuncao.DataPropertyName = "Funcao";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFuncao.DefaultCellStyle = dataGridViewCellStyle17;
            this.colFuncao.HeaderText = "Função";
            this.colFuncao.Name = "colFuncao";
            this.colFuncao.ReadOnly = true;
            this.colFuncao.Width = 68;
            // 
            // colSalario
            // 
            this.colSalario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSalario.DataPropertyName = "Salario";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = null;
            this.colSalario.DefaultCellStyle = dataGridViewCellStyle18;
            this.colSalario.HeaderText = "Salário";
            this.colSalario.Name = "colSalario";
            this.colSalario.ReadOnly = true;
            this.colSalario.Width = 64;
            // 
            // FrmFuncionarioSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.dataGridViewFuncionario);
            this.Controls.Add(this.btnFecharFunc);
            this.Controls.Add(this.btnConsultarFunc);
            this.Controls.Add(this.btnExcluirFunc);
            this.Controls.Add(this.btnAlterarFunc);
            this.Controls.Add(this.btnInserirFunc);
            this.Controls.Add(this.btnPesquisarFunc);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FrmFuncionarioSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewFuncionario;
        private System.Windows.Forms.Button btnFecharFunc;
        private System.Windows.Forms.Button btnConsultarFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnAlterarFunc;
        private System.Windows.Forms.Button btnInserirFunc;
        private System.Windows.Forms.Button btnPesquisarFunc;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeP;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDemissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalario;
    }
}