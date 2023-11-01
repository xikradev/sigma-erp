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
        private int itemIndex;
        public venda oVenda { get; set; }
        private BindingList<AxItemProd> items = new BindingList<AxItemProd>();
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
            var oUsuario = pLoginUsr.oUsuario;
            VendedorTextBox.Text = $"{oUsuario.idusuario}- {oUsuario.nomeCompleto}";
            dgItem.DataSource = items;
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
            try
            {
                if (dgItem.Rows.Count > 0 && dgItem.SelectedRows.Count > 0)
                {
                    if (int.TryParse(QuantTb.Text, out int num))
                    {
                        this.items[itemIndex].quantidade = num;
                        this.items[itemIndex].precoTotal = num * this.items[itemIndex].precoUnit;
                        dgItem.Refresh();
                    }
                    else if (String.IsNullOrEmpty(QuantTb.Text))
                    {
                        this.items[itemIndex].quantidade = 0;
                        this.items[itemIndex].precoTotal = 0;
                        dgItem.Refresh();
                    }

                    PrecoTotalTb.Text = "0";

                    foreach (var item in this.items)
                    {
                        PrecoTotalTb.Text = (decimal.Parse(PrecoTotalTb.Text) + item.precoTotal).ToString();
                    }
                }
            }catch(Exception ex)
            {

            }

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
            if (!int.TryParse(QuantTb.Text, out int qtn)) {
                MessageBox.Show("Deve o campo Quantidade só deve conter números para registrar uma Venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }if(dgItem.Rows.Count == 0)
            {
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
                AxItemProd newItem = pItemProd.GetItem(frm.oProduto.idproduto);

                if(!items.Any(o => o.idproduto == newItem.idproduto))
                {
                    this.items.Add(newItem);
                    dgItem.Refresh();
                }
                else
                {
                    MessageBox.Show("Esse item já foi adicionado na Venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RemoveProdBtn_Click(object sender, EventArgs e)
        {
            this.items.RemoveAt(this.itemIndex);
            dgItem.Refresh();
        }

        

        private void dgItem_SelectionChanged_1(object sender, EventArgs e)
        {
            

            try
            {
                if (dgItem.Rows.Count > 0)
                {
                    if (dgItem.SelectedRows.Count == 0)
                    {
                        QuantTb.Text = "";
                    }
                    this.itemIndex = dgItem.SelectedRows[0].Index;
                    QuantTb.Text = items[itemIndex].quantidade.ToString();
                    
                }
                else
                {
                    QuantTb.Text = "";
                    PrecoTotalTb.Text = "";
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void dgItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void QuantTb_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
