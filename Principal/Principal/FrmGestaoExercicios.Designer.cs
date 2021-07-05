namespace Principal
{
    partial class FrmGestaoExercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoExercicios));
            this.pnlInfoEquipamento = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxEquipamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxObs = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pnlInfoEquipamento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfoEquipamento
            // 
            this.pnlInfoEquipamento.Controls.Add(this.label2);
            this.pnlInfoEquipamento.Controls.Add(this.cbBoxEquipamento);
            this.pnlInfoEquipamento.Controls.Add(this.label1);
            this.pnlInfoEquipamento.Controls.Add(this.txtBoxObs);
            this.pnlInfoEquipamento.Controls.Add(this.lblNome);
            this.pnlInfoEquipamento.Controls.Add(this.txtBoxCodigo);
            this.pnlInfoEquipamento.Controls.Add(this.lblCodigo);
            this.pnlInfoEquipamento.Controls.Add(this.txtBoxNome);
            this.pnlInfoEquipamento.Location = new System.Drawing.Point(13, 77);
            this.pnlInfoEquipamento.Name = "pnlInfoEquipamento";
            this.pnlInfoEquipamento.Size = new System.Drawing.Size(738, 196);
            this.pnlInfoEquipamento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipamento:";
            // 
            // cbBoxEquipamento
            // 
            this.cbBoxEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxEquipamento.FormattingEnabled = true;
            this.cbBoxEquipamento.Location = new System.Drawing.Point(496, 36);
            this.cbBoxEquipamento.Name = "cbBoxEquipamento";
            this.cbBoxEquipamento.Size = new System.Drawing.Size(233, 28);
            this.cbBoxEquipamento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Obs:";
            // 
            // txtBoxObs
            // 
            this.txtBoxObs.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObs.Location = new System.Drawing.Point(14, 108);
            this.txtBoxObs.MaxLength = 45;
            this.txtBoxObs.Multiline = true;
            this.txtBoxObs.Name = "txtBoxObs";
            this.txtBoxObs.Size = new System.Drawing.Size(715, 73);
            this.txtBoxObs.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(112, 10);
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
            this.txtBoxCodigo.Location = new System.Drawing.Point(14, 37);
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
            this.lblCodigo.Location = new System.Drawing.Point(10, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(116, 37);
            this.txtBoxNome.MaxLength = 45;
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(362, 26);
            this.txtBoxNome.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(540, 282);
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
            this.btnCancelar.Location = new System.Drawing.Point(642, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCadastro.Location = new System.Drawing.Point(215, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(335, 47);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Gestão de Exercicios";
            // 
            // FrmGestaoExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlInfoEquipamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 370);
            this.Name = "FrmGestaoExercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Exercicios";
            this.Load += new System.EventHandler(this.FrmGestaoExercicios_Load);
            this.pnlInfoEquipamento.ResumeLayout(false);
            this.pnlInfoEquipamento.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlInfoEquipamento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoxEquipamento;
    }
}