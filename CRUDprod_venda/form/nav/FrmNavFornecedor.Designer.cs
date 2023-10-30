namespace ErpSigmaVenda.fornecedores
{
    partial class FrmNavFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNavFornecedor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.InsertButton = new System.Windows.Forms.ToolStripButton();
            this.UpdateButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.dgPF = new System.Windows.Forms.DataGridView();
            this.nomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.idfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axFornecedorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.axFornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.axFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.axClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.axFornecedorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPF)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qfornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertButton,
            this.UpdateButton,
            this.DeleteButton,
            this.btnRelatorio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 52);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // InsertButton
            // 
            this.InsertButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertButton.Image")));
            this.InsertButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InsertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(89, 49);
            this.InsertButton.Text = "Incluir";
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(102, 49);
            this.UpdateButton.Text = "Atualizar";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 49);
            this.DeleteButton.Text = "Remover";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(23, 49);
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // dgPF
            // 
            this.dgPF.AllowUserToAddRows = false;
            this.dgPF.AllowUserToDeleteRows = false;
            this.dgPF.AutoGenerateColumns = false;
            this.dgPF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfornecedorDataGridViewTextBoxColumn,
            this.nomeCompleto,
            this.registro,
            this.Rua,
            this.CEP,
            this.estado});
            this.dgPF.DataSource = this.axFornecedorBindingSource2;
            this.dgPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPF.Location = new System.Drawing.Point(3, 3);
            this.dgPF.Name = "dgPF";
            this.dgPF.ReadOnly = true;
            this.dgPF.RowHeadersVisible = false;
            this.dgPF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPF.Size = new System.Drawing.Size(786, 366);
            this.dgPF.TabIndex = 9;
            this.dgPF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick_1);
            this.dgPF.SelectionChanged += new System.EventHandler(this.dg_SelectionChanged);
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.DataPropertyName = "nomeCompleto";
            this.nomeCompleto.HeaderText = "Nome";
            this.nomeCompleto.Name = "nomeCompleto";
            this.nomeCompleto.ReadOnly = true;
            // 
            // registro
            // 
            this.registro.DataPropertyName = "registro";
            this.registro.HeaderText = "CPF/CNPJ";
            this.registro.Name = "registro";
            this.registro.ReadOnly = true;
            // 
            // Rua
            // 
            this.Rua.DataPropertyName = "rua";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "cep";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 398);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgPF);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // idfornecedorDataGridViewTextBoxColumn
            // 
            this.idfornecedorDataGridViewTextBoxColumn.DataPropertyName = "idfornecedor";
            this.idfornecedorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idfornecedorDataGridViewTextBoxColumn.Name = "idfornecedorDataGridViewTextBoxColumn";
            this.idfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // axFornecedorBindingSource2
            // 
            this.axFornecedorBindingSource2.DataSource = typeof(ErpSigmaVenda.auxiliar.AxFornecedor);
            // 
            // axFornecedorBindingSource1
            // 
            this.axFornecedorBindingSource1.DataSource = typeof(ErpSigmaVenda.auxiliar.AxFornecedor);
            // 
            // axFornecedorBindingSource
            // 
            this.axFornecedorBindingSource.DataSource = typeof(ErpSigmaVenda.auxiliar.AxFornecedor);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(ErpSigmaVenda.conexão.fornecedor);
            // 
            // qfornecedorBindingSource
            // 
            this.qfornecedorBindingSource.DataSource = typeof(ErpSigmaVenda.query.pFornecedor);
            // 
            // axClienteBindingSource
            // 
            this.axClienteBindingSource.DataSource = typeof(ErpSigmaVenda.auxiliar.AxCliente);
            // 
            // axFornecedorBindingSource3
            // 
            this.axFornecedorBindingSource3.DataSource = typeof(ErpSigmaVenda.auxiliar.AxFornecedor);
            // 
            // FrmNavFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNavFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FornecedorMainScreen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPF)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qfornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFornecedorBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton InsertButton;
        private System.Windows.Forms.ToolStripButton UpdateButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.BindingSource axFornecedorBindingSource;
        private System.Windows.Forms.BindingSource qfornecedorBindingSource;
        private System.Windows.Forms.BindingSource axFornecedorBindingSource1;
        private System.Windows.Forms.BindingSource axFornecedorBindingSource2;
        private System.Windows.Forms.DataGridView dgPF;
        private System.Windows.Forms.BindingSource axFornecedorBindingSource3;
        private System.Windows.Forms.BindingSource axClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}