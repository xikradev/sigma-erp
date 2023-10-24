namespace ErpSigmaVenda.fornecedores
{
    partial class FrmCadfornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadfornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.CnpjTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CepTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BairroTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RuaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Button = new System.Windows.Forms.ToolStripButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(21, 50);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(365, 20);
            this.NomeTextBox.TabIndex = 1;
            // 
            // CnpjTextBox
            // 
            this.CnpjTextBox.Location = new System.Drawing.Point(21, 105);
            this.CnpjTextBox.Name = "CnpjTextBox";
            this.CnpjTextBox.Size = new System.Drawing.Size(147, 20);
            this.CnpjTextBox.TabIndex = 3;
            this.CnpjTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.CnpjTextBox.Leave += new System.EventHandler(this.CnpjTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CepTextBox
            // 
            this.CepTextBox.Location = new System.Drawing.Point(239, 105);
            this.CepTextBox.Name = "CepTextBox";
            this.CepTextBox.Size = new System.Drawing.Size(147, 20);
            this.CepTextBox.TabIndex = 5;
            this.CepTextBox.Leave += new System.EventHandler(this.CepTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP";
            // 
            // BairroTextBox
            // 
            this.BairroTextBox.Location = new System.Drawing.Point(22, 161);
            this.BairroTextBox.Name = "BairroTextBox";
            this.BairroTextBox.Size = new System.Drawing.Size(257, 20);
            this.BairroTextBox.TabIndex = 7;
            this.BairroTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RuaTextBox
            // 
            this.RuaTextBox.Location = new System.Drawing.Point(22, 219);
            this.RuaTextBox.Name = "RuaTextBox";
            this.RuaTextBox.Size = new System.Drawing.Size(257, 20);
            this.RuaTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rua";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(318, 219);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(61, 20);
            this.NumeroTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 315);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(409, 39);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Button
            // 
            this.Button.Image = ((System.Drawing.Image)(resources.GetObject("Button.Image")));
            this.Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(74, 36);
            this.Button.Text = "Salvar";
            this.Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(236, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Ex: 00000-000";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(19, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Ex: 00.000.000/0000-00";
            // 
            // FrmCadfornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 354);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RuaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BairroTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CepTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CnpjTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadfornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Fornecedor";
            this.Load += new System.EventHandler(this.FornecedoresForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.TextBox CnpjTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CepTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BairroTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RuaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Button;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
    }
}