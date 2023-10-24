using ErpSigmaVenda.conexão;
using ErpSigmaVenda.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda
{
    public partial class FrmCadProduto : Form
    {
        public produto oProduto { get; set; }
        public fornecedor oFornecedor { get; set; }
        public produto_fornecedor prod_forn { get; set; }

        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            this.NomeTextBox.Text = this.oProduto.nome;
            this.PrecoTextBox.Text = this.oProduto.preco.ToString();
            this.DescricaoTextBox.Text = this.oProduto.descricao;
            this.Qnt_esTtextBox.Text = this.oProduto.estoque_qnt.ToString();
            if (!String.IsNullOrEmpty(this.oFornecedor.nome))
            {
                this.ForneceorTb.Text = $"{this.oFornecedor.idfornecedor}- {this.oFornecedor.nome}";
            }
        }

        private Boolean update(Decimal preco, int quant)
        {
            
            oProduto.nome = NomeTextBox.Text;
            oProduto.descricao = DescricaoTextBox.Text;
            oProduto.preco = preco;
            oProduto.estoque_qnt = quant;
            
           
            return true;
        }

        private Boolean verify()
        {
            if (String.IsNullOrEmpty(NomeTextBox.Text))
            {
                MessageBox.Show("O Campo nome não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(PrecoTextBox.Text))
            {
                MessageBox.Show("O Campo preço não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                MessageBox.Show("O Campo Descrição não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Decimal.TryParse(PrecoTextBox.Text, out decimal preco))
            {
                MessageBox.Show("O campo tem que ser um número decimal", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!int.TryParse(Qnt_esTtextBox.Text, out int quant))
            {
                MessageBox.Show("O campo tem que ser um número inteiro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            return update(preco, quant);
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            
            if (this.verify())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscarFornecedor frm = new FrmBuscarFornecedor();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.oFornecedor = frm.oFornecedor;
                ForneceorTb.Text = $"{this.oFornecedor.idfornecedor}- {this.oFornecedor.nome}";
            }
        }
    }
}
