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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NomeComplTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label16 = new System.Windows.Forms.Label();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.UFComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PJuridicaBtn = new System.Windows.Forms.RadioButton();
            this.PFisicaBtn = new System.Windows.Forms.RadioButton();
            this.RegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.RegisterTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RegisterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 562);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(547, 39);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // NomeComplTextBox
            // 
            this.NomeComplTextBox.Location = new System.Drawing.Point(42, 47);
            this.NomeComplTextBox.Name = "NomeComplTextBox";
            this.NomeComplTextBox.Size = new System.Drawing.Size(446, 20);
            this.NomeComplTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome Completo";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Location = new System.Drawing.Point(49, 196);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(214, 20);
            this.EmailTextBox.TabIndex = 19;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.SexoComboBox.Location = new System.Drawing.Point(46, 268);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(121, 21);
            this.SexoComboBox.TabIndex = 22;
            this.SexoComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sexo";
            // 
            // DataNascDTP
            // 
            this.DataNascDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascDTP.Location = new System.Drawing.Point(254, 269);
            this.DataNascDTP.Name = "DataNascDTP";
            this.DataNascDTP.Size = new System.Drawing.Size(231, 20);
            this.DataNascDTP.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Data de Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Complemento";
            // 
            // ComplTextBox
            // 
            this.ComplTextBox.Location = new System.Drawing.Point(26, 107);
            this.ComplTextBox.Name = "ComplTextBox";
            this.ComplTextBox.Size = new System.Drawing.Size(268, 20);
            this.ComplTextBox.TabIndex = 27;
            // 
            // CepTextBox
            // 
            this.CepTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CepTextBox.Location = new System.Drawing.Point(312, 45);
            this.CepTextBox.Name = "CepTextBox";
            this.CepTextBox.Size = new System.Drawing.Size(156, 20);
            this.CepTextBox.TabIndex = 29;
            this.CepTextBox.Leave += new System.EventHandler(this.CepTextBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "CEP";
            // 
            // RuaTextBox
            // 
            this.RuaTextBox.Location = new System.Drawing.Point(26, 45);
            this.RuaTextBox.Name = "RuaTextBox";
            this.RuaTextBox.Size = new System.Drawing.Size(267, 20);
            this.RuaTextBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Rua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Número";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(379, 107);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(86, 20);
            this.NumeroTextBox.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(46, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Ex: exemplo44@gmail.com";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(309, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Ex: 00000-000";
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.Location = new System.Drawing.Point(26, 160);
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.Size = new System.Drawing.Size(173, 20);
            this.CidadeTextBox.TabIndex = 70;
            // 
            // UFComboBox
            // 
            this.UFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.UFComboBox.Location = new System.Drawing.Point(242, 159);
            this.UFComboBox.Name = "UFComboBox";
            this.UFComboBox.Size = new System.Drawing.Size(121, 21);
            this.UFComboBox.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ComplTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.UFComboBox);
            this.groupBox1.Controls.Add(this.CepTextBox);
            this.groupBox1.Controls.Add(this.CidadeTextBox);
            this.groupBox1.Controls.Add(this.RuaTextBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NumeroTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 233);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PJuridicaBtn);
            this.groupBox2.Controls.Add(this.PFisicaBtn);
            this.groupBox2.Location = new System.Drawing.Point(42, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 90);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Cliente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PJuridicaBtn
            // 
            this.PJuridicaBtn.AutoSize = true;
            this.PJuridicaBtn.Location = new System.Drawing.Point(7, 54);
            this.PJuridicaBtn.Name = "PJuridicaBtn";
            this.PJuridicaBtn.Size = new System.Drawing.Size(101, 17);
            this.PJuridicaBtn.TabIndex = 1;
            this.PJuridicaBtn.TabStop = true;
            this.PJuridicaBtn.Text = "Pessoa Jurídica";
            this.PJuridicaBtn.UseVisualStyleBackColor = true;
            this.PJuridicaBtn.CheckedChanged += new System.EventHandler(this.PJuridicaBtn_CheckedChanged);
            // 
            // PFisicaBtn
            // 
            this.PFisicaBtn.AutoSize = true;
            this.PFisicaBtn.Location = new System.Drawing.Point(7, 31);
            this.PFisicaBtn.Name = "PFisicaBtn";
            this.PFisicaBtn.Size = new System.Drawing.Size(92, 17);
            this.PFisicaBtn.TabIndex = 0;
            this.PFisicaBtn.TabStop = true;
            this.PFisicaBtn.Text = "Pessoa Física";
            this.PFisicaBtn.UseVisualStyleBackColor = true;
            this.PFisicaBtn.CheckedChanged += new System.EventHandler(this.PFisicaBtn_CheckedChanged);
            // 
            // RegisterGroupBox
            // 
            this.RegisterGroupBox.Controls.Add(this.RegisterTextBox);
            this.RegisterGroupBox.Controls.Add(this.RegisterLabel);
            this.RegisterGroupBox.Location = new System.Drawing.Point(211, 87);
            this.RegisterGroupBox.Name = "RegisterGroupBox";
            this.RegisterGroupBox.Size = new System.Drawing.Size(273, 90);
            this.RegisterGroupBox.TabIndex = 77;
            this.RegisterGroupBox.TabStop = false;
            this.RegisterGroupBox.Text = "Pessoa Física";
            // 
            // RegisterTextBox
            // 
            this.RegisterTextBox.Location = new System.Drawing.Point(26, 48);
            this.RegisterTextBox.Mask = "999,999,999-99";
            this.RegisterTextBox.Name = "RegisterTextBox";
            this.RegisterTextBox.Size = new System.Drawing.Size(209, 20);
            this.RegisterTextBox.TabIndex = 2;
            this.RegisterTextBox.Leave += new System.EventHandler(this.RegisterTextBox_Leave);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(23, 31);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(27, 13);
            this.RegisterLabel.TabIndex = 1;
            this.RegisterLabel.Text = "CPF";
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 601);
            this.ControlBox = false;
            this.Controls.Add(this.RegisterGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataNascDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NomeComplTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RegisterGroupBox.ResumeLayout(false);
            this.RegisterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox NomeComplTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CidadeTextBox;
        private System.Windows.Forms.ComboBox UFComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PJuridicaBtn;
        private System.Windows.Forms.RadioButton PFisicaBtn;
        private System.Windows.Forms.GroupBox RegisterGroupBox;
        private System.Windows.Forms.MaskedTextBox RegisterTextBox;
        private System.Windows.Forms.Label RegisterLabel;
    }
}