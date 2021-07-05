namespace Principal
{
    partial class FrmRelatorio
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
            this.crvClientes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ListaDeAlunos1 = new Principal.Reports.ListaDeAlunos();
            this.SuspendLayout();
            // 
            // crvClientes
            // 
            this.crvClientes.ActiveViewIndex = 0;
            this.crvClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvClientes.Location = new System.Drawing.Point(0, 0);
            this.crvClientes.Name = "crvClientes";
            this.crvClientes.ReportSource = this.ListaDeAlunos1;
            this.crvClientes.Size = new System.Drawing.Size(803, 542);
            this.crvClientes.TabIndex = 0;
            this.crvClientes.Load += new System.EventHandler(this.crvClientes_Load);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 542);
            this.Controls.Add(this.crvClientes);
            this.Name = "FrmRelatorio";
            this.Text = "FrmRelatorio";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvClientes;
        private Reports.ListaDeAlunos ListaDeAlunos1;
    }
}