using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using ErpSigmaVenda.persistencia;
using ErpSigmaVenda.query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda.vendas
{
    public partial class FrmCadVendas : Form
    {
        public cliente oCliente { get; set; }
        public usuario oUsuario = pLoginUsr.oUsuario;
        public AxItemProd itemProd { get; set; }
        public venda oVenda { get; set; }
        public List<AxItemProd> items = new List<AxItemProd>();
        private venda_produtoEntities db = new venda_produtoEntities();



        public FrmCadVendas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendasForm_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            //dgItem.DataSource = new List<AxItemProd>();
            

            dgItem.DataSource = this.items;

            for (int i = 0; i < dgItem.Rows.Count; i++)
            {
                var currentRow = dgItem.Rows[i];

                currentRow.Cells[idprodutoDataGridViewTextBoxColumn.Index].Value = ((AxItemProd)dgItem.SelectedRows[i].DataBoundItem).idproduto;
                //currentRow.Cells[idprodutoDataGridViewTextBoxColumn.Index].Value = ((AxItemProd)dgItem.SelectedRows[i].DataBoundItem).idproduto;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm = new FrmBuscarCliente();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.oCliente = frm.oCliente;
                ClienteTb.Text = $"{this.oCliente.idcliente}- {this.oCliente.nomeCompleto}";
            }
        }

        private void QuantTb_TextChanged(object sender, EventArgs e)
        {
            

        }

        private Boolean update(int qtn)
        {
            this.oVenda.idcliente = this.oCliente.idcliente;
            //this.oVenda.idproduto = this.oProduto.idproduto;
            this.oVenda.precoTotal = decimal.Parse(PrecoTotalTb.Text);
            //this.oVenda.quantidade = qtn;
            this.oVenda.data = DateTime.Now;
            return true;
        }

        private Boolean verify()
        {
            
            if (String.IsNullOrEmpty(ClienteTb.Text))
            {
                MessageBox.Show("Deve selecionar um Cliente para registrar uma Venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(QuantTb.Text))
            {
                MessageBox.Show("Deve ser preenchido o campo Quantidade para registrar uma Venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(QuantTb.Text, out int qtn)) {
                MessageBox.Show("Deve o campo Quantidade só deve conter números para registrar uma Venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return update(qtn);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            FrmBuscarProduto frm = new FrmBuscarProduto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.items.Add(pItemProd.GetItem(frm.oProduto.idproduto));
                loading();
            }
        }

        private void RemoveProdBtn_Click(object sender, EventArgs e)
        {
            this.items.Remove(this.itemProd);
            loading();
        }

        

        private void dgItem_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgItem.Rows.Count > 0) {
                this.itemProd = (AxItemProd)dgItem.SelectedRows[0].DataBoundItem;
            }
           
        }

        private void dgItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }
    }
}
