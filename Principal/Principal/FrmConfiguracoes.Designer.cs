namespace Principal
{
    partial class FrmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            this.tabConfigs = new System.Windows.Forms.TabControl();
            this.tpBackup = new System.Windows.Forms.TabPage();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.lblDirBkp = new System.Windows.Forms.Label();
            this.tpRegras = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabConfigs.SuspendLayout();
            this.tpBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfigs
            // 
            this.tabConfigs.Controls.Add(this.tpBackup);
            this.tabConfigs.Controls.Add(this.tpRegras);
            this.tabConfigs.Location = new System.Drawing.Point(12, 12);
            this.tabConfigs.Name = "tabConfigs";
            this.tabConfigs.SelectedIndex = 0;
            this.tabConfigs.Size = new System.Drawing.Size(687, 229);
            this.tabConfigs.TabIndex = 0;
            // 
            // tpBackup
            // 
            this.tpBackup.Controls.Add(this.btnPesquisar);
            this.tpBackup.Controls.Add(this.txtBoxPesquisa);
            this.tpBackup.Controls.Add(this.lblDirBkp);
            this.tpBackup.Location = new System.Drawing.Point(4, 22);
            this.tpBackup.Name = "tpBackup";
            this.tpBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tpBackup.Size = new System.Drawing.Size(679, 203);
            this.tpBackup.TabIndex = 0;
            this.tpBackup.Text = "Backup";
            this.tpBackup.UseVisualStyleBackColor = true;
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxPesquisa.Location = new System.Drawing.Point(25, 34);
            this.txtBoxPesquisa.MaxLength = 60;
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(515, 26);
            this.txtBoxPesquisa.TabIndex = 1;
            // 
            // lblDirBkp
            // 
            this.lblDirBkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirBkp.Location = new System.Drawing.Point(25, 11);
            this.lblDirBkp.Name = "lblDirBkp";
            this.lblDirBkp.Size = new System.Drawing.Size(172, 20);
            this.lblDirBkp.TabIndex = 0;
            this.lblDirBkp.Text = "Diretório de Backup:";
            // 
            // tpRegras
            // 
            this.tpRegras.Location = new System.Drawing.Point(4, 22);
            this.tpRegras.Name = "tpRegras";
            this.tpRegras.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegras.Size = new System.Drawing.Size(679, 203);
            this.tpRegras.TabIndex = 1;
            this.tpRegras.Text = "Regras de Negócio";
            this.tpRegras.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(487, 247);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 41);
            this.btnSalvar.TabIndex = 1;
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
            this.btnCancelar.Location = new System.Drawing.Point(590, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 41);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(546, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 298);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tabConfigs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfiguracoes_Load);
            this.tabConfigs.ResumeLayout(false);
            this.tpBackup.ResumeLayout(false);
            this.tpBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfigs;
        private System.Windows.Forms.TabPage tpBackup;
        private System.Windows.Forms.TabPage tpRegras;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.Label lblDirBkp;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}