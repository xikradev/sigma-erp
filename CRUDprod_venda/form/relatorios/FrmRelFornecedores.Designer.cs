namespace ErpSigmaVenda.form.relatorios
{
    partial class FrmRelFornecedores
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
            this.rptFornecedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptFornecedor
            // 
            this.rptFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptFornecedor.Location = new System.Drawing.Point(0, 0);
            this.rptFornecedor.Name = "rptFornecedor";
            this.rptFornecedor.ServerReport.BearerToken = null;
            this.rptFornecedor.Size = new System.Drawing.Size(800, 450);
            this.rptFornecedor.TabIndex = 0;
            // 
            // FrmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptFornecedor);
            this.Name = "FrmFornecedores";
            this.Text = "FrmFornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFornecedor;
    }
}