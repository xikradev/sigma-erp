namespace ErpSigmaVenda.login
{
    partial class FrmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsuario));
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RuaTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComplTextBox = new System.Windows.Forms.TextBox();
            this.DataNascDTP = new System.Windows.Forms.DateTimePicker();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NomeComplTextBox = new System.Windows.Forms.TextBox();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.TipoUsrComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.InsertBtn = new System.Windows.Forms.ToolStripButton();
            this.UFComboBox = new System.Windows.Forms.ComboBox();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CepErrorLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NumeroErrorLabel = new System.Windows.Forms.Label();
            this.CepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CpfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelRule2 = new System.Windows.Forms.Label();
            this.labelRule3 = new System.Windows.Forms.Label();
            this.labelRule4 = new System.Windows.Forms.Label();
            this.labelRule5 = new System.Windows.Forms.Label();
            this.labelRule1 = new System.Windows.Forms.Label();
            this.CpfErrorLabel = new System.Windows.Forms.Label();
            this.DateErrorLabel = new System.Windows.Forms.Label();
            this.TipoUsrErrorLabel = new System.Windows.Forms.Label();
            this.SexoErrorLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.EmailErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(283, 100);
            this.NumeroTextBox.MaxLength = 3;
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(93, 20);
            this.NumeroTextBox.TabIndex = 54;
            this.NumeroTextBox.TextChanged += new System.EventHandler(this.NumeroTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Número";
            // 
            // RuaTextBox
            // 
            this.RuaTextBox.Location = new System.Drawing.Point(162, 45);
            this.RuaTextBox.MaxLength = 100;
            this.RuaTextBox.Name = "RuaTextBox";
            this.RuaTextBox.ReadOnly = true;
            this.RuaTextBox.Size = new System.Drawing.Size(214, 20);
            this.RuaTextBox.TabIndex = 52;
            this.RuaTextBox.TextChanged += new System.EventHandler(this.RuaTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "CEP";
            // 
            // ComplTextBox
            // 
            this.ComplTextBox.Location = new System.Drawing.Point(10, 100);
            this.ComplTextBox.MaxLength = 100;
            this.ComplTextBox.Name = "ComplTextBox";
            this.ComplTextBox.ReadOnly = true;
            this.ComplTextBox.Size = new System.Drawing.Size(267, 20);
            this.ComplTextBox.TabIndex = 48;
            this.ComplTextBox.TextChanged += new System.EventHandler(this.ComplTextBox_TextChanged);
            // 
            // DataNascDTP
            // 
            this.DataNascDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascDTP.Location = new System.Drawing.Point(16, 302);
            this.DataNascDTP.Name = "DataNascDTP";
            this.DataNascDTP.Size = new System.Drawing.Size(194, 20);
            this.DataNascDTP.TabIndex = 45;
            this.DataNascDTP.ValueChanged += new System.EventHandler(this.DataNascDTP_ValueChanged);
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.SexoComboBox.Location = new System.Drawing.Point(224, 245);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(170, 21);
            this.SexoComboBox.TabIndex = 43;
            this.SexoComboBox.SelectedValueChanged += new System.EventHandler(this.SexoComboBox_SelectedValueChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Location = new System.Drawing.Point(12, 85);
            this.EmailTextBox.MaxLength = 80;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(227, 20);
            this.EmailTextBox.TabIndex = 40;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // NomeComplTextBox
            // 
            this.NomeComplTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NomeComplTextBox.Location = new System.Drawing.Point(13, 25);
            this.NomeComplTextBox.MaxLength = 150;
            this.NomeComplTextBox.Name = "NomeComplTextBox";
            this.NomeComplTextBox.Size = new System.Drawing.Size(381, 20);
            this.NomeComplTextBox.TabIndex = 36;
            this.NomeComplTextBox.TextChanged += new System.EventHandler(this.NomeComplTextBox_TextChanged);
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(13, 169);
            this.SenhaTextBox.MaxLength = 20;
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(196, 20);
            this.SenhaTextBox.TabIndex = 56;
            this.SenhaTextBox.TextChanged += new System.EventHandler(this.SenhaTextBox_TextChanged);
            // 
            // TipoUsrComboBox
            // 
            this.TipoUsrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoUsrComboBox.FormattingEnabled = true;
            this.TipoUsrComboBox.Items.AddRange(new object[] {
            "ADM",
            "Vendedor"});
            this.TipoUsrComboBox.Location = new System.Drawing.Point(13, 245);
            this.TipoUsrComboBox.Name = "TipoUsrComboBox";
            this.TipoUsrComboBox.Size = new System.Drawing.Size(196, 21);
            this.TipoUsrComboBox.TabIndex = 57;
            this.TipoUsrComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoUsrComboBox_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.InsertBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 595);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(414, 39);
            this.toolStrip1.TabIndex = 60;
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
            // InsertBtn
            // 
            this.InsertBtn.Enabled = false;
            this.InsertBtn.Image = ((System.Drawing.Image)(resources.GetObject("InsertBtn.Image")));
            this.InsertBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InsertBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(74, 36);
            this.InsertBtn.Text = "Salvar";
            this.InsertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InsertBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // UFComboBox
            // 
            this.UFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UFComboBox.Enabled = false;
            this.UFComboBox.FormattingEnabled = true;
            this.UFComboBox.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.UFComboBox.Location = new System.Drawing.Point(269, 164);
            this.UFComboBox.Name = "UFComboBox";
            this.UFComboBox.Size = new System.Drawing.Size(107, 21);
            this.UFComboBox.TabIndex = 75;
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.Location = new System.Drawing.Point(13, 165);
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.ReadOnly = true;
            this.CidadeTextBox.Size = new System.Drawing.Size(250, 20);
            this.CidadeTextBox.TabIndex = 74;
            this.CidadeTextBox.TextChanged += new System.EventHandler(this.CidadeTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CepErrorLabel);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.NumeroErrorLabel);
            this.groupBox1.Controls.Add(this.CepTextBox);
            this.groupBox1.Controls.Add(this.ComplTextBox);
            this.groupBox1.Controls.Add(this.UFComboBox);
            this.groupBox1.Controls.Add(this.CidadeTextBox);
            this.groupBox1.Controls.Add(this.RuaTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NumeroTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 215);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(266, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 120;
            this.label4.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(10, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 15);
            this.label18.TabIndex = 120;
            this.label18.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(10, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 15);
            this.label15.TabIndex = 120;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(159, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 15);
            this.label14.TabIndex = 120;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(10, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 120;
            this.label13.Text = "*";
            // 
            // CepErrorLabel
            // 
            this.CepErrorLabel.AutoSize = true;
            this.CepErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CepErrorLabel.Location = new System.Drawing.Point(10, 68);
            this.CepErrorLabel.Name = "CepErrorLabel";
            this.CepErrorLabel.Size = new System.Drawing.Size(75, 13);
            this.CepErrorLabel.TabIndex = 103;
            this.CepErrorLabel.Text = "* CEP Inválido";
            this.CepErrorLabel.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 101;
            this.label17.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Cidade";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 97;
            this.label22.Text = "Complemento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(169, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 95;
            this.label16.Text = "Rua";
            // 
            // NumeroErrorLabel
            // 
            this.NumeroErrorLabel.AutoSize = true;
            this.NumeroErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.NumeroErrorLabel.Location = new System.Drawing.Point(280, 123);
            this.NumeroErrorLabel.Name = "NumeroErrorLabel";
            this.NumeroErrorLabel.Size = new System.Drawing.Size(101, 13);
            this.NumeroErrorLabel.TabIndex = 91;
            this.NumeroErrorLabel.Text = "* Somente Números";
            this.NumeroErrorLabel.Visible = false;
            // 
            // CepTextBox
            // 
            this.CepTextBox.Location = new System.Drawing.Point(10, 45);
            this.CepTextBox.Mask = "99999-999";
            this.CepTextBox.Name = "CepTextBox";
            this.CepTextBox.Size = new System.Drawing.Size(142, 20);
            this.CepTextBox.TabIndex = 85;
            this.CepTextBox.TextChanged += new System.EventHandler(this.CepTextBox_TextChanged);
            // 
            // CpfTextBox
            // 
            this.CpfTextBox.Location = new System.Drawing.Point(250, 85);
            this.CpfTextBox.Mask = "999,999,999-99";
            this.CpfTextBox.Name = "CpfTextBox";
            this.CpfTextBox.Size = new System.Drawing.Size(144, 20);
            this.CpfTextBox.TabIndex = 79;
            this.CpfTextBox.TextChanged += new System.EventHandler(this.CpfTextBox_TextChanged);
            // 
            // labelRule2
            // 
            this.labelRule2.AutoSize = true;
            this.labelRule2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule2.Location = new System.Drawing.Point(219, 150);
            this.labelRule2.Name = "labelRule2";
            this.labelRule2.Size = new System.Drawing.Size(151, 16);
            this.labelRule2.TabIndex = 80;
            this.labelRule2.Text = "- 1 Letra Maiúscula no mínimo;";
            // 
            // labelRule3
            // 
            this.labelRule3.AutoSize = true;
            this.labelRule3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule3.Location = new System.Drawing.Point(219, 166);
            this.labelRule3.Name = "labelRule3";
            this.labelRule3.Size = new System.Drawing.Size(115, 16);
            this.labelRule3.TabIndex = 81;
            this.labelRule3.Text = "- 1 Número no mínimo;";
            // 
            // labelRule4
            // 
            this.labelRule4.AutoSize = true;
            this.labelRule4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule4.Location = new System.Drawing.Point(219, 182);
            this.labelRule4.Name = "labelRule4";
            this.labelRule4.Size = new System.Drawing.Size(156, 16);
            this.labelRule4.TabIndex = 82;
            this.labelRule4.Text = "- 1 Símbolo no mínimo: ($*&@#);";
            // 
            // labelRule5
            // 
            this.labelRule5.AutoSize = true;
            this.labelRule5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule5.Location = new System.Drawing.Point(219, 198);
            this.labelRule5.Name = "labelRule5";
            this.labelRule5.Size = new System.Drawing.Size(172, 16);
            this.labelRule5.TabIndex = 83;
            this.labelRule5.Text = "- Sem sequencias (aa, bb, 44, 55);";
            // 
            // labelRule1
            // 
            this.labelRule1.AutoSize = true;
            this.labelRule1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRule1.Location = new System.Drawing.Point(219, 134);
            this.labelRule1.Name = "labelRule1";
            this.labelRule1.Size = new System.Drawing.Size(126, 16);
            this.labelRule1.TabIndex = 84;
            this.labelRule1.Text = "- 8 caracteres no mínimo;";
            // 
            // CpfErrorLabel
            // 
            this.CpfErrorLabel.AutoSize = true;
            this.CpfErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CpfErrorLabel.Location = new System.Drawing.Point(247, 108);
            this.CpfErrorLabel.Name = "CpfErrorLabel";
            this.CpfErrorLabel.Size = new System.Drawing.Size(142, 13);
            this.CpfErrorLabel.TabIndex = 87;
            this.CpfErrorLabel.Text = "* O Campo CPF é obrigatório";
            this.CpfErrorLabel.Visible = false;
            // 
            // DateErrorLabel
            // 
            this.DateErrorLabel.AutoSize = true;
            this.DateErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.DateErrorLabel.Location = new System.Drawing.Point(13, 325);
            this.DateErrorLabel.Name = "DateErrorLabel";
            this.DateErrorLabel.Size = new System.Drawing.Size(191, 13);
            this.DateErrorLabel.TabIndex = 88;
            this.DateErrorLabel.Text = "* O Usuário tem que ser maior de idade";
            this.DateErrorLabel.Visible = false;
            // 
            // TipoUsrErrorLabel
            // 
            this.TipoUsrErrorLabel.AutoSize = true;
            this.TipoUsrErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TipoUsrErrorLabel.Location = new System.Drawing.Point(13, 269);
            this.TipoUsrErrorLabel.Name = "TipoUsrErrorLabel";
            this.TipoUsrErrorLabel.Size = new System.Drawing.Size(152, 13);
            this.TipoUsrErrorLabel.TabIndex = 89;
            this.TipoUsrErrorLabel.Text = "* Selecione um tipo de Usuário";
            this.TipoUsrErrorLabel.Visible = false;
            // 
            // SexoErrorLabel
            // 
            this.SexoErrorLabel.AutoSize = true;
            this.SexoErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.SexoErrorLabel.Location = new System.Drawing.Point(226, 269);
            this.SexoErrorLabel.Name = "SexoErrorLabel";
            this.SexoErrorLabel.Size = new System.Drawing.Size(149, 13);
            this.SexoErrorLabel.TabIndex = 90;
            this.SexoErrorLabel.Text = "* Selecione o sexo do Usuário";
            this.SexoErrorLabel.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 99;
            this.label19.Text = "Nome Completo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 101;
            this.label21.Text = "Email";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(263, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 103;
            this.label23.Text = "CPF";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 150);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 105;
            this.label24.Text = "Senha";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(235, 229);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 107;
            this.label25.Text = "Sexo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(21, 229);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 13);
            this.label26.TabIndex = 109;
            this.label26.Text = "Tipo de Usuário";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(23, 286);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 13);
            this.label27.TabIndex = 111;
            this.label27.Text = "Data de Nascimento";
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.AutoSize = true;
            this.EmailErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.EmailErrorLabel.Location = new System.Drawing.Point(13, 108);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(147, 13);
            this.EmailErrorLabel.TabIndex = 86;
            this.EmailErrorLabel.Text = "* O Campo Email é obrigatório";
            this.EmailErrorLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(11, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 113;
            this.label7.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(12, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 15);
            this.label12.TabIndex = 114;
            this.label12.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(247, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 115;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(10, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 116;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(226, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 117;
            this.label1.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(13, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 118;
            this.label6.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(13, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 119;
            this.label2.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(149, 579);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(253, 13);
            this.label20.TabIndex = 122;
            this.label20.Text = "*Preencha os campos obrigatórios para poder salvar";
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 634);
            this.ControlBox = false;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.SexoErrorLabel);
            this.Controls.Add(this.TipoUsrErrorLabel);
            this.Controls.Add(this.DateErrorLabel);
            this.Controls.Add(this.CpfErrorLabel);
            this.Controls.Add(this.EmailErrorLabel);
            this.Controls.Add(this.labelRule1);
            this.Controls.Add(this.labelRule5);
            this.Controls.Add(this.labelRule4);
            this.Controls.Add(this.labelRule3);
            this.Controls.Add(this.labelRule2);
            this.Controls.Add(this.CpfTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TipoUsrComboBox);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.DataNascDTP);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NomeComplTextBox);
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Usuário";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RuaTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ComplTextBox;
        private System.Windows.Forms.DateTimePicker DataNascDTP;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NomeComplTextBox;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.ComboBox TipoUsrComboBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton InsertBtn;
        private System.Windows.Forms.ComboBox UFComboBox;
        private System.Windows.Forms.TextBox CidadeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox CpfTextBox;
        private System.Windows.Forms.Label labelRule2;
        private System.Windows.Forms.Label labelRule3;
        private System.Windows.Forms.Label labelRule4;
        private System.Windows.Forms.Label labelRule5;
        private System.Windows.Forms.Label labelRule1;
        private System.Windows.Forms.MaskedTextBox CepTextBox;
        private System.Windows.Forms.Label NumeroErrorLabel;
        private System.Windows.Forms.Label CpfErrorLabel;
        private System.Windows.Forms.Label DateErrorLabel;
        private System.Windows.Forms.Label TipoUsrErrorLabel;
        private System.Windows.Forms.Label SexoErrorLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label CepErrorLabel;
        private System.Windows.Forms.Label EmailErrorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
    }
}