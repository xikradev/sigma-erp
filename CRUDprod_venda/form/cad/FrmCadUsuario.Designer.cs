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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ComplTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DataNascDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeComplTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoUsrComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.UFComboBox = new System.Windows.Forms.ComboBox();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CpfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelRule2 = new System.Windows.Forms.Label();
            this.labelRule3 = new System.Windows.Forms.Label();
            this.labelRule4 = new System.Windows.Forms.Label();
            this.labelRule5 = new System.Windows.Forms.Label();
            this.labelRule1 = new System.Windows.Forms.Label();
            this.CepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(363, 100);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(93, 20);
            this.NumeroTextBox.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Número";
            // 
            // RuaTextBox
            // 
            this.RuaTextBox.Location = new System.Drawing.Point(17, 45);
            this.RuaTextBox.Name = "RuaTextBox";
            this.RuaTextBox.Size = new System.Drawing.Size(274, 20);
            this.RuaTextBox.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Rua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "CEP";
            // 
            // ComplTextBox
            // 
            this.ComplTextBox.Location = new System.Drawing.Point(17, 100);
            this.ComplTextBox.Name = "ComplTextBox";
            this.ComplTextBox.Size = new System.Drawing.Size(275, 20);
            this.ComplTextBox.TabIndex = 48;
            this.ComplTextBox.TextChanged += new System.EventHandler(this.BairroTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Data de Nascimento";
            // 
            // DataNascDTP
            // 
            this.DataNascDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascDTP.Location = new System.Drawing.Point(15, 269);
            this.DataNascDTP.Name = "DataNascDTP";
            this.DataNascDTP.Size = new System.Drawing.Size(239, 20);
            this.DataNascDTP.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Sexo";
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.SexoComboBox.Location = new System.Drawing.Point(338, 269);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(121, 21);
            this.SexoComboBox.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "CPF";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Location = new System.Drawing.Point(15, 102);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(214, 20);
            this.EmailTextBox.TabIndex = 40;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Email";
            // 
            // NomeComplTextBox
            // 
            this.NomeComplTextBox.Location = new System.Drawing.Point(15, 53);
            this.NomeComplTextBox.Name = "NomeComplTextBox";
            this.NomeComplTextBox.Size = new System.Drawing.Size(463, 20);
            this.NomeComplTextBox.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nome Completo";
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(15, 165);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(211, 20);
            this.SenhaTextBox.TabIndex = 56;
            this.SenhaTextBox.TextChanged += new System.EventHandler(this.SenhaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tipo de Usuário";
            // 
            // TipoUsrComboBox
            // 
            this.TipoUsrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoUsrComboBox.FormattingEnabled = true;
            this.TipoUsrComboBox.Items.AddRange(new object[] {
            "ADM",
            "Vendedor"});
            this.TipoUsrComboBox.Location = new System.Drawing.Point(15, 213);
            this.TipoUsrComboBox.Name = "TipoUsrComboBox";
            this.TipoUsrComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoUsrComboBox.TabIndex = 57;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 518);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(524, 39);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(15, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Ex: exemplo44@gmail.com";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 77;
            this.label13.Text = "Estado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 76;
            this.label17.Text = "Cidade";
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
            this.UFComboBox.Location = new System.Drawing.Point(229, 153);
            this.UFComboBox.Name = "UFComboBox";
            this.UFComboBox.Size = new System.Drawing.Size(128, 21);
            this.UFComboBox.TabIndex = 75;
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.Location = new System.Drawing.Point(13, 154);
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.Size = new System.Drawing.Size(180, 20);
            this.CidadeTextBox.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CepTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.ComplTextBox);
            this.groupBox1.Controls.Add(this.UFComboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CidadeTextBox);
            this.groupBox1.Controls.Add(this.RuaTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NumeroTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 193);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // CpfTextBox
            // 
            this.CpfTextBox.Location = new System.Drawing.Point(315, 102);
            this.CpfTextBox.Mask = "999,999,999-99";
            this.CpfTextBox.Name = "CpfTextBox";
            this.CpfTextBox.Size = new System.Drawing.Size(163, 20);
            this.CpfTextBox.TabIndex = 79;
            // 
            // labelRule2
            // 
            this.labelRule2.AutoSize = true;
            this.labelRule2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule2.Location = new System.Drawing.Point(254, 165);
            this.labelRule2.Name = "labelRule2";
            this.labelRule2.Size = new System.Drawing.Size(151, 16);
            this.labelRule2.TabIndex = 80;
            this.labelRule2.Text = "- 1 Letra Maiúscula no mínimo;";
            this.labelRule2.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelRule3
            // 
            this.labelRule3.AutoSize = true;
            this.labelRule3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule3.Location = new System.Drawing.Point(254, 181);
            this.labelRule3.Name = "labelRule3";
            this.labelRule3.Size = new System.Drawing.Size(115, 16);
            this.labelRule3.TabIndex = 81;
            this.labelRule3.Text = "- 1 Número no mínimo;";
            // 
            // labelRule4
            // 
            this.labelRule4.AutoSize = true;
            this.labelRule4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule4.Location = new System.Drawing.Point(254, 197);
            this.labelRule4.Name = "labelRule4";
            this.labelRule4.Size = new System.Drawing.Size(156, 16);
            this.labelRule4.TabIndex = 82;
            this.labelRule4.Text = "- 1 Símbolo no mínimo: ($*&@#);";
            this.labelRule4.Click += new System.EventHandler(this.label19_Click);
            // 
            // labelRule5
            // 
            this.labelRule5.AutoSize = true;
            this.labelRule5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule5.Location = new System.Drawing.Point(254, 213);
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
            this.labelRule1.Location = new System.Drawing.Point(254, 149);
            this.labelRule1.Name = "labelRule1";
            this.labelRule1.Size = new System.Drawing.Size(126, 16);
            this.labelRule1.TabIndex = 84;
            this.labelRule1.Text = "- 8 caracteres no mínimo;";
            this.labelRule1.Click += new System.EventHandler(this.label18_Click_1);
            // 
            // CepTextBox
            // 
            this.CepTextBox.Location = new System.Drawing.Point(323, 45);
            this.CepTextBox.Mask = "99999-999";
            this.CepTextBox.Name = "CepTextBox";
            this.CepTextBox.Size = new System.Drawing.Size(122, 20);
            this.CepTextBox.TabIndex = 85;
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 557);
            this.ControlBox = false;
            this.Controls.Add(this.labelRule1);
            this.Controls.Add(this.labelRule5);
            this.Controls.Add(this.labelRule4);
            this.Controls.Add(this.labelRule3);
            this.Controls.Add(this.labelRule2);
            this.Controls.Add(this.CpfTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoUsrComboBox);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataNascDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeComplTextBox);
            this.Controls.Add(this.label12);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ComplTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DataNascDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomeComplTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoUsrComboBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
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
    }
}