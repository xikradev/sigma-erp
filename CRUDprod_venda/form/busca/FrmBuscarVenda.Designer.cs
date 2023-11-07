namespace ErpSigmaVenda.vendas
{
    partial class FrmBuscarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarVenda));
            this.dg = new System.Windows.Forms.DataGridView();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.idvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axVendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.axVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AutoGenerateColumns = false;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvenda,
            this.clienteDataGridViewTextBoxColumn,
            this.vendedor,
            this.dataDataGridViewTextBoxColumn,
            this.precoTotal});
            this.dg.DataSource = this.axVendaBindingSource1;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(0, 25);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(891, 492);
            this.dg.TabIndex = 5;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.SelectionChanged += new System.EventHandler(this.dg_SelectionChanged);
            // 
            // vendedor
            // 
            this.vendedor.DataPropertyName = "vendedor";
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            // 
            // precoTotal
            // 
            this.precoTotal.DataPropertyName = "precoTotal";
            this.precoTotal.HeaderText = "Total";
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.SearchTextBox,
            this.SearchBtn,
            this.toolStripSeparator1,
            this.FilterComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(891, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // SearchBtn
            // 
            this.SearchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(23, 22);
            this.SearchBtn.Text = "toolStripButton1";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Código",
            "Data",
            "Cliente"});
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Pesquisar";
            // 
            // idvenda
            // 
            this.idvenda.DataPropertyName = "idvenda";
            this.idvenda.HeaderText = "Código";
            this.idvenda.Name = "idvenda";
            this.idvenda.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axVendaBindingSource1
            // 
            this.axVendaBindingSource1.DataSource = typeof(ErpSigmaVenda.auxiliar.AxVenda);
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataSource = typeof(ErpSigmaVenda.conexão.venda);
            // 
            // axVendaBindingSource
            // 
            this.axVendaBindingSource.DataSource = typeof(ErpSigmaVenda.auxiliar.AxVenda);
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(ErpSigmaVenda.conexão.venda);
            // 
            // FrmNavVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 517);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNavVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendaMainScreen";
            this.Load += new System.EventHandler(this.VendaMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.BindingSource axVendaBindingSource;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private System.Windows.Forms.BindingSource axVendaBindingSource1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.ToolStripButton SearchBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox FilterComboBox;
    }
}