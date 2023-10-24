using ErpSigmaVenda.conexão;
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
        public produto oProduto { get; set; }
        public venda oVenda { get; set; }
        


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
           
            this.oVenda.idusuario = pLoginUsr.oUsuario.idusuario;
            this.PrecoTotalTb.Text = this.oVenda.precoTotal.ToString();
            this.QuantTb.Text = this.oVenda.quantidade.ToString();
            if (!String.IsNullOrEmpty(this.oCliente.nomeCompleto))
            {
                ClienteTb.Text = $"{this.oCliente.idcliente}- {this.oCliente.nomeCompleto}";
            }
            if (!String.IsNullOrEmpty(this.oProduto.nome))
            {
                ProdutoTb.Text = $"{this.oProduto.idproduto}- {this.oProduto.nome}";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calulatingPrice()
        {
            this.PrecoUniTb.Text = this.oProduto.preco.ToString();
            if (!String.IsNullOrEmpty(QuantTb.Text))
            {
                if (decimal.TryParse(this.QuantTb.Text, out decimal qtn))
                {
                    decimal totalPrice = this.oProduto.preco * qtn;
                    this.PrecoTotalTb.Text = totalPrice.ToString();
                }
            }
            else
            {
                PrecoTotalTb.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscarProduto frm = new FrmBuscarProduto();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.oProduto = frm.oProduto;
                ProdutoTb.Text = $"{this.oProduto.idproduto}- {this.oProduto.nome}";
                calulatingPrice();
            }

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
            calulatingPrice();

        }

        private Boolean update(int qtn)
        {
            this.oVenda.idcliente = this.oCliente.idcliente;
            this.oVenda.idproduto = this.oProduto.idproduto;
            this.oVenda.precoTotal = decimal.Parse(PrecoTotalTb.Text);
            this.oVenda.quantidade = qtn;
            this.oVenda.data = DateTime.Now;
            return true;
        }

        private Boolean verify()
        {
            if (String.IsNullOrEmpty(ProdutoTb.Text))
            {
                MessageBox.Show("Deve selecionar um Produto para registrar uma Venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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
    }
}
