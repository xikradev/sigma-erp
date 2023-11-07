namespace ErpSigmaVenda.vendas
{
    partial class FrmNavVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNavVendas));
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.AtualizarVendaBtn = new System.Windows.Forms.ToolStripButton();
            this.FinalizarVendaBtn = new System.Windows.Forms.ToolStripButton();
            this.ClienteTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.VendedorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProdBtn = new System.Windows.Forms.Button();
            this.RemoveProdBtn = new System.Windows.Forms.Button();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.axItemProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EncerrarBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MetPagCB = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CodVendaTextBox = new System.Windows.Forms.TextBox();
            this.CancelarVendaBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecoTotalTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescontoTextBox = new System.Windows.Forms.TextBox();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axItemProdBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.AtualizarVendaBtn,
            this.FinalizarVendaBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 570);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1071, 39);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(101, 36);
            this.toolStripButton1.Text = "Fechar Tela";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // AtualizarVendaBtn
            // 
            this.AtualizarVendaBtn.Enabled = false;
            this.AtualizarVendaBtn.Image = ((System.Drawing.Image)(resources.GetObject("AtualizarVendaBtn.Image")));
            this.AtualizarVendaBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AtualizarVendaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AtualizarVendaBtn.Name = "AtualizarVendaBtn";
            this.AtualizarVendaBtn.Size = new System.Drawing.Size(124, 36);
            this.AtualizarVendaBtn.Text = "Atualizar Venda";
            this.AtualizarVendaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AtualizarVendaBtn.Click += new System.EventHandler(this.AtualizarVendaBtn_Click);
            // 
            // FinalizarVendaBtn
            // 
            this.FinalizarVendaBtn.Enabled = false;
            this.FinalizarVendaBtn.Image = ((System.Drawing.Image)(resources.GetObject("FinalizarVendaBtn.Image")));
            this.FinalizarVendaBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FinalizarVendaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FinalizarVendaBtn.Name = "FinalizarVendaBtn";
            this.FinalizarVendaBtn.Size = new System.Drawing.Size(121, 36);
            this.FinalizarVendaBtn.Text = "Finalizar Venda";
            this.FinalizarVendaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FinalizarVendaBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ClienteTb
            // 
            this.ClienteTb.Location = new System.Drawing.Point(488, 32);
            this.ClienteTb.Name = "ClienteTb";
            this.ClienteTb.ReadOnly = true;
            this.ClienteTb.Size = new System.Drawing.Size(327, 20);
            this.ClienteTb.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(820, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VendedorTextBox
            // 
            this.VendedorTextBox.Location = new System.Drawing.Point(151, 32);
            this.VendedorTextBox.Name = "VendedorTextBox";
            this.VendedorTextBox.ReadOnly = true;
            this.VendedorTextBox.Size = new System.Drawing.Size(314, 20);
            this.VendedorTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vendedor";
            // 
            // AddProdBtn
            // 
            this.AddProdBtn.Location = new System.Drawing.Point(13, 68);
            this.AddProdBtn.Name = "AddProdBtn";
            this.AddProdBtn.Size = new System.Drawing.Size(110, 37);
            this.AddProdBtn.TabIndex = 19;
            this.AddProdBtn.Text = "Adicionar Produto";
            this.AddProdBtn.UseVisualStyleBackColor = true;
            this.AddProdBtn.Click += new System.EventHandler(this.AddProdBtn_Click);
            // 
            // RemoveProdBtn
            // 
            this.RemoveProdBtn.Location = new System.Drawing.Point(129, 68);
            this.RemoveProdBtn.Name = "RemoveProdBtn";
            this.RemoveProdBtn.Size = new System.Drawing.Size(110, 37);
            this.RemoveProdBtn.TabIndex = 20;
            this.RemoveProdBtn.Text = "Remover Produto";
            this.RemoveProdBtn.UseVisualStyleBackColor = true;
            this.RemoveProdBtn.Click += new System.EventHandler(this.RemoveProdBtn_Click);
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
            this.precoTotalDataGridViewTextBoxColumn,
            this.estoque_qnt});
            this.dgItem.DataSource = this.axItemProdBindingSource;
            this.dgItem.Location = new System.Drawing.Point(0, 129);
            this.dgItem.Name = "dgItem";
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(1071, 360);
            this.dgItem.TabIndex = 22;
            this.dgItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellEndEdit);
            this.dgItem.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgItem_CellValidating);
            this.dgItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellValueChanged);
            this.dgItem.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgItem_RowsAdded);
            this.dgItem.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgItem_RowsRemoved);
            this.dgItem.SelectionChanged += new System.EventHandler(this.dgItem_SelectionChanged_1);
            // 
            // axItemProdBindingSource
            // 
            this.axItemProdBindingSource.DataSource = typeof(ErpSigmaVenda.auxiliar.AxItemProd);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgItem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 570);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EncerrarBtn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.MetPagCB);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CodVendaTextBox);
            this.groupBox3.Controls.Add(this.CancelarVendaBtn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.RemoveProdBtn);
            this.groupBox3.Controls.Add(this.VendedorTextBox);
            this.groupBox3.Controls.Add(this.AddProdBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ClienteTb);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1071, 123);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // EncerrarBtn
            // 
            this.EncerrarBtn.Location = new System.Drawing.Point(919, 16);
            this.EncerrarBtn.Name = "EncerrarBtn";
            this.EncerrarBtn.Size = new System.Drawing.Size(126, 42);
            this.EncerrarBtn.TabIndex = 25;
            this.EncerrarBtn.Text = "Encerrar Venda";
            this.EncerrarBtn.UseVisualStyleBackColor = true;
            this.EncerrarBtn.Click += new System.EventHandler(this.EncerrarBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Método de Pagamento";
            // 
            // MetPagCB
            // 
            this.MetPagCB.FormattingEnabled = true;
            this.MetPagCB.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix"});
            this.MetPagCB.Location = new System.Drawing.Point(488, 83);
            this.MetPagCB.Name = "MetPagCB";
            this.MetPagCB.Size = new System.Drawing.Size(197, 21);
            this.MetPagCB.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 37);
            this.button3.TabIndex = 22;
            this.button3.Text = "Filtrar Venda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código da Venda";
            // 
            // CodVendaTextBox
            // 
            this.CodVendaTextBox.Location = new System.Drawing.Point(13, 32);
            this.CodVendaTextBox.Name = "CodVendaTextBox";
            this.CodVendaTextBox.ReadOnly = true;
            this.CodVendaTextBox.Size = new System.Drawing.Size(121, 20);
            this.CodVendaTextBox.TabIndex = 20;
            // 
            // CancelarVendaBtn
            // 
            this.CancelarVendaBtn.Location = new System.Drawing.Point(919, 68);
            this.CancelarVendaBtn.Name = "CancelarVendaBtn";
            this.CancelarVendaBtn.Size = new System.Drawing.Size(126, 42);
            this.CancelarVendaBtn.TabIndex = 19;
            this.CancelarVendaBtn.Text = "Cancelar Venda";
            this.CancelarVendaBtn.UseVisualStyleBackColor = true;
            this.CancelarVendaBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Preço Total da Venda";
            // 
            // PrecoTotalTb
            // 
            this.PrecoTotalTb.Location = new System.Drawing.Point(663, 35);
            this.PrecoTotalTb.Name = "PrecoTotalTb";
            this.PrecoTotalTb.ReadOnly = true;
            this.PrecoTotalTb.Size = new System.Drawing.Size(176, 20);
            this.PrecoTotalTb.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quantidade de Produtos";
            // 
            // QuantTb
            // 
            this.QuantTb.Location = new System.Drawing.Point(468, 35);
            this.QuantTb.Name = "QuantTb";
            this.QuantTb.ReadOnly = true;
            this.QuantTb.Size = new System.Drawing.Size(176, 20);
            this.QuantTb.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.StatusTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DescontoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.QuantTb);
            this.groupBox1.Controls.Add(this.PrecoTotalTb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 75);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(863, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Status da Venda";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(866, 35);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(176, 20);
            this.StatusTextBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Desconto";
            // 
            // DescontoTextBox
            // 
            this.DescontoTextBox.Location = new System.Drawing.Point(15, 35);
            this.DescontoTextBox.Name = "DescontoTextBox";
            this.DescontoTextBox.Size = new System.Drawing.Size(169, 20);
            this.DescontoTextBox.TabIndex = 29;
            this.DescontoTextBox.TextChanged += new System.EventHandler(this.DescontoTextBox_TextChanged);
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
            // estoque_qnt
            // 
            this.estoque_qnt.DataPropertyName = "estoque_qnt";
            this.estoque_qnt.HeaderText = "Quantidade em Estoque";
            this.estoque_qnt.Name = "estoque_qnt";
            // 
            // FrmCadVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 609);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCadVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Vendas";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axItemProdBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton FinalizarVendaBtn;
        private System.Windows.Forms.TextBox ClienteTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox VendedorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProdBtn;
        private System.Windows.Forms.Button RemoveProdBtn;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.BindingSource axItemProdBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodVendaTextBox;
        private System.Windows.Forms.Button CancelarVendaBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrecoTotalTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescontoTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MetPagCB;
        private System.Windows.Forms.Button EncerrarBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.ToolStripButton AtualizarVendaBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_qnt;
    }
}