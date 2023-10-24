namespace ErpSigmaVenda.clientes
{
    partial class FrmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistroTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataNascDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComplTextBox = new System.Windows.Forms.TextBox();
            this.CepTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RuaTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.UFComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 400);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(543, 39);
            this.toolStrip1.TabIndex = 14;
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
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(74, 36);
            this.toolStripButton2.Text = "Salvar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(42, 60);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(150, 20);
            this.NomeTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // SobrenomeTextBox
            // 
            this.SobrenomeTextBox.Location = new System.Drawing.Point(215, 60);
            this.SobrenomeTextBox.Name = "SobrenomeTextBox";
            this.SobrenomeTextBox.Size = new System.Drawing.Size(273, 20);
            this.SobrenomeTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sobrenome";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Location = new System.Drawing.Point(42, 112);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(214, 20);
            this.EmailTextBox.TabIndex = 19;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RegistroTextBox
            // 
            this.RegistroTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegistroTextBox.Location = new System.Drawing.Point(274, 112);
            this.RegistroTextBox.Name = "RegistroTextBox";
            this.RegistroTextBox.Size = new System.Drawing.Size(214, 20);
            this.RegistroTextBox.TabIndex = 21;
            this.RegistroTextBox.Leave += new System.EventHandler(this.CpfTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "CPF/CNPJ";
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.SexoComboBox.Location = new System.Drawing.Point(42, 195);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(121, 21);
            this.SexoComboBox.TabIndex = 22;
            this.SexoComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sexo";
            // 
            // DataNascDTP
            // 
            this.DataNascDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascDTP.Location = new System.Drawing.Point(258, 195);
            this.DataNascDTP.Name = "DataNascDTP";
            this.DataNascDTP.Size = new System.Drawing.Size(231, 20);
            this.DataNascDTP.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Data de Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Complemento";
            // 
            // ComplTextBox
            // 
            this.ComplTextBox.Location = new System.Drawing.Point(42, 312);
            this.ComplTextBox.Name = "ComplTextBox";
            this.ComplTextBox.Size = new System.Drawing.Size(268, 20);
            this.ComplTextBox.TabIndex = 27;
            // 
            // CepTextBox
            // 
            this.CepTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CepTextBox.Location = new System.Drawing.Point(328, 250);
            this.CepTextBox.Name = "CepTextBox";
            this.CepTextBox.Size = new System.Drawing.Size(156, 20);
            this.CepTextBox.TabIndex = 29;
            this.CepTextBox.Leave += new System.EventHandler(this.CepTextBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "CEP";
            // 
            // RuaTextBox
            // 
            this.RuaTextBox.Location = new System.Drawing.Point(42, 250);
            this.RuaTextBox.Name = "RuaTextBox";
            this.RuaTextBox.Size = new System.Drawing.Size(267, 20);
            this.RuaTextBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Rua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Número";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(395, 312);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(86, 20);
            this.NumeroTextBox.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(39, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Ex: exemplo44@gmail.com";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(273, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "CPF Ex : 000.000.000-00 ou 00000000000";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(325, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Ex: 00000-000";
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.Location = new System.Drawing.Point(42, 365);
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.Size = new System.Drawing.Size(173, 20);
            this.CidadeTextBox.TabIndex = 70;
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
            this.UFComboBox.Location = new System.Drawing.Point(258, 364);
            this.UFComboBox.Name = "UFComboBox";
            this.UFComboBox.Size = new System.Drawing.Size(121, 21);
            this.UFComboBox.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(273, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "CNPJ Ex : 00.000.000/0000-00 ou 00000000000000";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 439);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UFComboBox);
            this.Controls.Add(this.CidadeTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RuaTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CepTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComplTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataNascDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.RegistroTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SobrenomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SobrenomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegistroTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DataNascDTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ComplTextBox;
        private System.Windows.Forms.TextBox CepTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RuaTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CidadeTextBox;
        private System.Windows.Forms.ComboBox UFComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}