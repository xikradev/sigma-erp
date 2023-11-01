namespace ErpSigmaVenda.vendas
{
    partial class FrmCadVendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadVendas));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantTb = new System.Windows.Forms.TextBox();
            this.PrecoTotalTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ClienteTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.VendedorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProdBtn = new System.Windows.Forms.Button();
            this.RemoveProdBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axItemProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axItemProdBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade";
            // 
            // QuantTb
            // 
            this.QuantTb.Location = new System.Drawing.Point(21, 206);
            this.QuantTb.Name = "QuantTb";
            this.QuantTb.Size = new System.Drawing.Size(202, 20);
            this.QuantTb.TabIndex = 6;
            this.QuantTb.TextChanged += new System.EventHandler(this.QuantTb_TextChanged);
            this.QuantTb.Leave += new System.EventHandler(this.QuantTb_Leave);
            // 
            // PrecoTotalTb
            // 
            this.PrecoTotalTb.Location = new System.Drawing.Point(24, 255);
            this.PrecoTotalTb.Name = "PrecoTotalTb";
            this.PrecoTotalTb.ReadOnly = true;
            this.PrecoTotalTb.Size = new System.Drawing.Size(199, 20);
            this.PrecoTotalTb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preço Total da Venda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 359);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(947, 39);
            this.toolStrip1.TabIndex = 11;
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
            // ClienteTb
            // 
            this.ClienteTb.Location = new System.Drawing.Point(24, 96);
            this.ClienteTb.Name = "ClienteTb";
            this.ClienteTb.ReadOnly = true;
            this.ClienteTb.Size = new System.Drawing.Size(233, 20);
            this.ClienteTb.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(263, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VendedorTextBox
            // 
            this.VendedorTextBox.Location = new System.Drawing.Point(21, 46);
            this.VendedorTextBox.Name = "VendedorTextBox";
            this.VendedorTextBox.ReadOnly = true;
            this.VendedorTextBox.Size = new System.Drawing.Size(233, 20);
            this.VendedorTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vendedor";
            // 
            // AddProdBtn
            // 
            this.AddProdBtn.Location = new System.Drawing.Point(21, 138);
            this.AddProdBtn.Name = "AddProdBtn";
            this.AddProdBtn.Size = new System.Drawing.Size(110, 37);
            this.AddProdBtn.TabIndex = 19;
            this.AddProdBtn.Text = "Adicionar Produto";
            this.AddProdBtn.UseVisualStyleBackColor = true;
            this.AddProdBtn.Click += new System.EventHandler(this.AddProdBtn_Click);
            // 
            // RemoveProdBtn
            // 
            this.RemoveProdBtn.Location = new System.Drawing.Point(137, 138);
            this.RemoveProdBtn.Name = "RemoveProdBtn";
            this.RemoveProdBtn.Size = new System.Drawing.Size(117, 37);
            this.RemoveProdBtn.TabIndex = 20;
            this.RemoveProdBtn.Text = "Remover Produto";
            this.RemoveProdBtn.UseVisualStyleBackColor = true;
            this.RemoveProdBtn.Click += new System.EventHandler(this.RemoveProdBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.QuantTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RemoveProdBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VendedorTextBox);
            this.groupBox1.Controls.Add(this.AddProdBtn);
            this.groupBox1.Controls.Add(this.PrecoTotalTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClienteTb);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(633, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 344);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AutoGenerateColumns = false;
            this.dgItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitDataGridViewTextBoxColumn,
            this.precoTotalDataGridViewTextBoxColumn});
            this.dgItem.DataSource = this.axItemProdBindingSource;
            this.dgItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItem.Location = new System.Drawing.Point(3, 16);
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(621, 325);
            this.dgItem.TabIndex = 22;
            this.dgItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellContentClick);
            this.dgItem.SelectionChanged += new System.EventHandler(this.dgItem_SelectionChanged_1);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "idproduto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoUnitDataGridViewTextBoxColumn
            // 
            this.precoUnitDataGridViewTextBoxColumn.DataPropertyName = "precoUnit";
            this.precoUnitDataGridViewTextBoxColumn.HeaderText = "Preço Unitário";
            this.precoUnitDataGridViewTextBoxColumn.Name = "precoUnitDataGridViewTextBoxColumn";
            this.precoUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoTotalDataGridViewTextBoxColumn
            // 
            this.precoTotalDataGridViewTextBoxColumn.DataPropertyName = "precoTotal";
            this.precoTotalDataGridViewTextBoxColumn.HeaderText = "Preço Total";
            this.precoTotalDataGridViewTextBoxColumn.Name = "precoTotalDataGridViewTextBoxColumn";
            this.precoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axItemProdBindingSource
            // 
            this.axItemProdBindingSource.DataSource = typeof(ErpSigmaVenda.auxiliar.AxItemProd);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgItem);
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 344);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // FrmCadVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 398);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCadVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Vendas";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axItemProdBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantTb;
        private System.Windows.Forms.TextBox PrecoTotalTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox ClienteTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox VendedorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProdBtn;
        private System.Windows.Forms.Button RemoveProdBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource axItemProdBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}