using ErpSigmaVenda.linq;
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
            SaveButton.Enabled = AllFieldsFilled();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = AllFieldsFilled();
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            this.NomeTextBox.Text = this.oProduto.nome;
            this.PrecoTextBox.Text = this.oProduto.preco == 0 ? "0,00": this.oProduto.preco.ToString();
            this.DescricaoTextBox.Text = this.oProduto.descricao;
            this.Qnt_esTtextBox.Text = this.oProduto.estoque_qnt.ToString();
            if (!String.IsNullOrEmpty(this.oFornecedor.nomeCompleto))
            {
                this.FornecedorTb.Text = $"{this.oFornecedor.idfornecedor}- {this.oFornecedor.nomeCompleto}";
            }
        }

        private void update()
        {
            
            oProduto.nome = NomeTextBox.Text;
            oProduto.descricao = DescricaoTextBox.Text;
            decimal value = decimal.Parse(Qnt_esTtextBox.Text);
            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
            if (decimalPlaces > 2)
            {
                Qnt_esTtextBox.Text = value.ToString("0.00");
            }
            oProduto.preco = decimal.Parse(PrecoTextBox.Text);
            oProduto.estoque_qnt = decimal.Parse(Qnt_esTtextBox.Text);
        }

        private Boolean AllFieldsFilled()
        {
            if (String.IsNullOrEmpty(NomeTextBox.Text))
            {
                return false;
            }
            if (PrecoTextBox.Text.Equals("0,00"))
            { 
                return false;
            }
            if (String.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                
                return false;
            }
            if (String.IsNullOrEmpty(FornecedorTb.Text))
            {
                
                return false;
            }
            if (Qnt_esTtextBox.Text.Equals("0"))
            {
                
                return false;
            }


            return true;
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            update();
            this.DialogResult = DialogResult.OK;
            
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
                FornecedorTb.Text = $"{this.oFornecedor.idfornecedor}- {this.oFornecedor.nomeCompleto}";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrecoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Qnt_esTtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void PrecoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!PrecoTextBox.Text.Equals(""))
            {
                TextBox textBox = (TextBox)sender;

                string text = textBox.Text.Replace(",", "").Replace(".", "");

                decimal value = decimal.Parse(text);

                textBox.Text = (value / 100).ToString("0.00");

                textBox.SelectionStart = textBox.Text.Length;
            }
            else
            {
                PrecoTextBox.Text = "0.00";
                PrecoTextBox.SelectAll();
            }

            SaveButton.Enabled = AllFieldsFilled();
        }

        private void Qnt_esTtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Qnt_esTtextBox.Text.Equals(""))
            {
                decimal value = decimal.Parse(Qnt_esTtextBox.Text);
                int decimalPlaces = BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
                if (decimalPlaces > 2)
                {
                    Qnt_esTtextBox.Text = value.ToString("0.00");
                    Qnt_esTtextBox.SelectionStart = Qnt_esTtextBox.Text.Length;
                }
            }
            else
            {
                Qnt_esTtextBox.Text = "0";
                Qnt_esTtextBox.SelectAll();
            }

            SaveButton.Enabled = AllFieldsFilled();
        }

        private void ForneceorTb_TextChanged(object sender, EventArgs e)
        {
            
            SaveButton.Enabled = AllFieldsFilled();
        }

        private void PrecoTextBox_Click(object sender, EventArgs e)
        {
            if (PrecoTextBox.Text.Equals("0,00"))
            {
                PrecoTextBox.SelectAll();
            }
        }

        private void Qnt_esTtextBox_Click(object sender, EventArgs e)
        {
            if (Qnt_esTtextBox.Text.Equals("0"))
            {
                Qnt_esTtextBox.SelectAll();
            }
        }

        private void Qnt_esTtextBox_Leave(object sender, EventArgs e)
        {
            if (Qnt_esTtextBox.Text.Equals(""))
            {
                Qnt_esTtextBox.Text = "0";
            }
            
        }

        private void PrecoTextBox_Leave(object sender, EventArgs e)
        {
            if (PrecoTextBox.Text.Equals(""))
            {
                PrecoTextBox.Text = "0,00";
            }
        }
    }
}
