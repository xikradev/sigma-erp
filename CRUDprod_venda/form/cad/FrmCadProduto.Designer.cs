namespace ErpSigmaVenda
{
    partial class FrmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter1 = new ErpSigmaVenda.venda_produtoDataSetTableAdapters.clienteTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.DescricaoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.Qnt_esTtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FornecedorTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(15, 36);
            this.NomeTextBox.MaxLength = 100;
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(485, 20);
            this.NomeTextBox.TabIndex = 1;
            this.NomeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço (R$)";
            // 
            // DescricaoTextBox
            // 
            this.DescricaoTextBox.Location = new System.Drawing.Point(13, 137);
            this.DescricaoTextBox.MaxLength = 500;
            this.DescricaoTextBox.Multiline = true;
            this.DescricaoTextBox.Name = "DescricaoTextBox";
            this.DescricaoTextBox.Size = new System.Drawing.Size(285, 82);
            this.DescricaoTextBox.TabIndex = 5;
            this.DescricaoTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.SaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 239);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(512, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 36);
            this.SaveButton.Text = "Salvar";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Qnt_esTtextBox
            // 
            this.Qnt_esTtextBox.Location = new System.Drawing.Point(320, 155);
            this.Qnt_esTtextBox.MaxLength = 10;
            this.Qnt_esTtextBox.Name = "Qnt_esTtextBox";
            this.Qnt_esTtextBox.Size = new System.Drawing.Size(180, 20);
            this.Qnt_esTtextBox.TabIndex = 9;
            this.Qnt_esTtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qnt_esTtextBox.Click += new System.EventHandler(this.Qnt_esTtextBox_Click);
            this.Qnt_esTtextBox.TextChanged += new System.EventHandler(this.Qnt_esTtextBox_TextChanged);
            this.Qnt_esTtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qnt_esTtextBox_KeyPress);
            this.Qnt_esTtextBox.Leave += new System.EventHandler(this.Qnt_esTtextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade no Estoque (Unid/Kg)";
            // 
            // FornecedorTb
            // 
            this.FornecedorTb.Location = new System.Drawing.Point(14, 90);
            this.FornecedorTb.Name = "FornecedorTb";
            this.FornecedorTb.ReadOnly = true;
            this.FornecedorTb.Size = new System.Drawing.Size(255, 20);
            this.FornecedorTb.TabIndex = 10;
            this.FornecedorTb.TextChanged += new System.EventHandler(this.ForneceorTb_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(275, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Buscar Fornecedor";
            // 
            // PrecoTextBox
            // 
            this.PrecoTextBox.Location = new System.Drawing.Point(321, 92);
            this.PrecoTextBox.MaxLength = 10;
            this.PrecoTextBox.Name = "PrecoTextBox";
            this.PrecoTextBox.Size = new System.Drawing.Size(179, 20);
            this.PrecoTextBox.TabIndex = 17;
            this.PrecoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrecoTextBox.Click += new System.EventHandler(this.PrecoTextBox_Click);
            this.PrecoTextBox.TextChanged += new System.EventHandler(this.PrecoTextBox_TextChanged);
            this.PrecoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoTextBox_KeyPress);
            this.PrecoTextBox.Leave += new System.EventHandler(this.PrecoTextBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(244, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 13);
            this.label10.TabIndex = 121;
            this.label10.Text = "* Preencha os campos obrigatórios para poder salvar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(13, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 122;
            this.label7.Text = "*";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(318, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 123;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(318, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 124;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(10, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 125;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(10, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 126;
            this.label11.Text = "*";
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 278);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PrecoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FornecedorTb);
            this.Controls.Add(this.Qnt_esTtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DescricaoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Produto";
            this.Load += new System.EventHandler(this.ProdutoForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTextBox;
        private venda_produtoDataSetTableAdapters.clienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescricaoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.TextBox Qnt_esTtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FornecedorTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}