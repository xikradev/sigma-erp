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
            this.dg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axVendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.axVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dg.Location = new System.Drawing.Point(1, 82);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(891, 564);
            this.dg.TabIndex = 5;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.SelectionChanged += new System.EventHandler(this.dg_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 0;
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNavVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendaMainScreen";
            this.Load += new System.EventHandler(this.VendaMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.BindingSource axVendaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private System.Windows.Forms.BindingSource axVendaBindingSource1;
    }
}