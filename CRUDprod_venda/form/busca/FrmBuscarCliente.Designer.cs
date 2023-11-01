namespace ErpSigmaVenda.vendas
{
    partial class FrmBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.OkBtn = new System.Windows.Forms.ToolStripButton();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchBtn = new System.Windows.Forms.ToolStripButton();
            this.FilterCb = new System.Windows.Forms.ToolStripComboBox();
            this.dgPF = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgPJ = new System.Windows.Forms.DataGridView();
            this.seguimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPF)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton2,
            this.OkBtn,
            this.SearchTextBox,
            this.SearchBtn,
            this.FilterCb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 411);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 36);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton2.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton2.Text = "Cancelar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OkBtn.Image = ((System.Drawing.Image)(resources.GetObject("OkBtn.Image")));
            this.OkBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OkBtn.Size = new System.Drawing.Size(74, 36);
            this.OkBtn.Text = "Salvar";
            this.OkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(200, 39);
            // 
            // SearchBtn
            // 
            this.SearchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(28, 36);
            this.SearchBtn.Text = "toolStripButton3";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FilterCb
            // 
            this.FilterCb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FilterCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterCb.Items.AddRange(new object[] {
            "Id",
            "CPF/CNPJ",
            "Nome"});
            this.FilterCb.Name = "FilterCb";
            this.FilterCb.Size = new System.Drawing.Size(121, 39);
            this.FilterCb.Click += new System.EventHandler(this.FilterCb_Click);
            // 
            // dgPF
            // 
            this.dgPF.AllowUserToAddRows = false;
            this.dgPF.AllowUserToDeleteRows = false;
            this.dgPF.AutoGenerateColumns = false;
            this.dgPF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.registroDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgPF.DataSource = this.axClienteBindingSource;
            this.dgPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPF.Location = new System.Drawing.Point(3, 3);
            this.dgPF.Name = "dgPF";
            this.dgPF.ReadOnly = true;
            this.dgPF.RowHeadersVisible = false;
            this.dgPF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPF.Size = new System.Drawing.Size(786, 379);
            this.dgPF.TabIndex = 2;
            this.dgPF.SelectionChanged += new System.EventHandler(this.dg_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 411);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgPF);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pessoa Física";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgPJ);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pessoa Jurídica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgPJ
            // 
            this.dgPJ.AllowUserToAddRows = false;
            this.dgPJ.AllowUserToDeleteRows = false;
            this.dgPJ.AutoGenerateColumns = false;
            this.dgPJ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.seguimento,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgPJ.DataSource = this.axClienteBindingSource;
            this.dgPJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPJ.Location = new System.Drawing.Point(3, 3);
            this.dgPJ.Name = "dgPJ";
            this.dgPJ.ReadOnly = true;
            this.dgPJ.RowHeadersVisible = false;
            this.dgPJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPJ.Size = new System.Drawing.Size(786, 379);
            this.dgPJ.TabIndex = 3;
            this.dgPJ.SelectionChanged += new System.EventHandler(this.dgPJ_SelectionChanged);
            // 
            // seguimento
            // 
            this.seguimento.DataPropertyName = "seguimento";
            this.seguimento.HeaderText = "Seguimento";
            this.seguimento.Name = "seguimento";
            this.seguimento.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "nomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "Nome Completo";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sexo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataNascimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de Nascimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn5.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // axClienteBindingSource
            // 
            this.axClienteBindingSource.DataSource = typeof(ErpSigmaVenda.auxiliar.AxCliente);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nomeCompleto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "registro";
            this.dataGridViewTextBoxColumn9.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "dataNascimento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data de Nascimento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn12.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Clientes";
            this.Load += new System.EventHandler(this.PesquisarCliFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPF)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton OkBtn;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.ToolStripButton SearchBtn;
        private System.Windows.Forms.ToolStripComboBox FilterCb;
        private System.Windows.Forms.DataGridView dgPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource axClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}