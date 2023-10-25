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
            this.NomeComplTextBox = new System.Windows.Forms.TextBox();
            this.CnpjTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Button = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UFComboBox = new System.Windows.Forms.ComboBox();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RuaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComplTextBox = new System.Windows.Forms.TextBox();
            this.CepTextBox = new System.Windows.Forms.TextBox();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // NomeComplTextBox
            // 
            this.NomeComplTextBox.Location = new System.Drawing.Point(15, 35);
            this.NomeComplTextBox.Name = "NomeComplTextBox";
            this.NomeComplTextBox.Size = new System.Drawing.Size(431, 20);
            this.NomeComplTextBox.TabIndex = 1;
            // 
            // CnpjTextBox
            // 
            this.CnpjTextBox.Location = new System.Drawing.Point(15, 90);
            this.CnpjTextBox.Name = "CnpjTextBox";
            this.CnpjTextBox.Size = new System.Drawing.Size(195, 20);
            this.CnpjTextBox.TabIndex = 3;
            this.CnpjTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.CnpjTextBox.Leave += new System.EventHandler(this.CnpjTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF/CNPJ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 395);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(472, 39);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(13, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Ex: 00.000.000/0000-00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UFComboBox);
            this.groupBox1.Controls.Add(this.CidadeTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RuaTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComplTextBox);
            this.groupBox1.Controls.Add(this.CepTextBox);
            this.groupBox1.Controls.Add(this.NumeroTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(6, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 215);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Cidade";
            // 
            // UFComboBox
            // 
            this.UFComboBox.FormattingEnabled = true;
            this.UFComboBox.Items.AddRange(new object[] {
            "RO-Rondônia",
            "AC-Acre",
            "AM-Amazonas",
            "RR-Roraima",
            "PA-Pará",
            "AP-Amapá",
            "TO-Tocantins",
            "MA-Maranhão",
            "PI-Piauí\t",
            "CE-Ceará",
            "RN-Rio Grande do Norte",
            "PB-Paraíba",
            "PE-Pernambuco",
            "AL-Alagoas",
            "SE-Sergipe",
            "BA-Bahia",
            "MG-Minas Gerais",
            "ES-Espírito Santo",
            "RJ-Rio de Janeiro",
            "SP-São Paulo",
            "PR-Paraná\t",
            "SC-Santa Catarina",
            "RS-Rio Grande do Sul",
            "MS-Mato Grosso do Sul",
            "MT-Mato Grosso",
            "GO-Goiás",
            "DF-Distrito Federal"});
            this.UFComboBox.Location = new System.Drawing.Point(222, 162);
            this.UFComboBox.Name = "UFComboBox";
            this.UFComboBox.Size = new System.Drawing.Size(121, 21);
            this.UFComboBox.TabIndex = 75;
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.Location = new System.Drawing.Point(6, 163);
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.Size = new System.Drawing.Size(173, 20);
            this.CidadeTextBox.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rua";
            // 
            // RuaTextBox
            // 
            this.RuaTextBox.Location = new System.Drawing.Point(9, 47);
            this.RuaTextBox.Name = "RuaTextBox";
            this.RuaTextBox.Size = new System.Drawing.Size(257, 20);
            this.RuaTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(290, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Ex: 00000-000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Complemento";
            // 
            // ComplTextBox
            // 
            this.ComplTextBox.Location = new System.Drawing.Point(9, 110);
            this.ComplTextBox.Name = "ComplTextBox";
            this.ComplTextBox.Size = new System.Drawing.Size(324, 20);
            this.ComplTextBox.TabIndex = 7;
            // 
            // CepTextBox
            // 
            this.CepTextBox.Location = new System.Drawing.Point(293, 47);
            this.CepTextBox.Name = "CepTextBox";
            this.CepTextBox.Size = new System.Drawing.Size(147, 20);
            this.CepTextBox.TabIndex = 5;
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(368, 111);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(61, 20);
            this.NumeroTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Número";
            // 
            // FrmCadfornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 434);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CnpjTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeComplTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadfornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Fornecedor";
            this.Load += new System.EventHandler(this.FornecedoresForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeComplTextBox;
        private System.Windows.Forms.TextBox CnpjTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UFComboBox;
        private System.Windows.Forms.TextBox CidadeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RuaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ComplTextBox;
        private System.Windows.Forms.TextBox CepTextBox;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}