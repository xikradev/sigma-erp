using ErpSigmaVenda.conexão;
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

namespace ErpSigmaVenda.fornecedores
{
    public partial class FrmCadfornecedor : Form
    {
        public fornecedor oFornecedor = new fornecedor();
        public endereco oEndereco = new endereco();
        Regex regexCnpj = new Regex(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$");
        Regex regexCep = new Regex(@"^\d{5}-\d{3}$", RegexOptions.IgnoreCase);

        public FrmCadfornecedor()
        {
            InitializeComponent();
        }

        private void FornecedoresForm_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            this.NomeComplTextBox.Text = this.oFornecedor.nomeCompleto;
            this.CnpjTextBox.Text = this.oFornecedor.registro;
            this.CepTextBox.Text = this.oEndereco.cep;
            this.ComplTextBox.Text = this.oEndereco.complemento;
            this.RuaTextBox.Text = this.oEndereco.rua;
            this.NumeroTextBox.Text = this.oEndereco.numero.ToString();
            this.CidadeTextBox.Text = this.oEndereco.cidade;
            this.UFComboBox.SelectedItem = this.oEndereco.estado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private Boolean update(int numero)
        {
            this.oFornecedor.nomeCompleto = this.NomeComplTextBox.Text;
            this.oFornecedor.registro = this.CnpjTextBox.Text;
            this.oEndereco.cep = this.CepTextBox.Text;
            this.oEndereco.complemento = this.ComplTextBox.Text;
            this.oEndereco.rua = this.RuaTextBox.Text;
            this.oEndereco.numero = int.Parse(this.NumeroTextBox.Text);
            this.oEndereco.cidade = this.CidadeTextBox.Text;
            this.oEndereco.estado = UFComboBox.Text.Substring(0, 2);

            return true;
        }

        private Boolean verify()
        {
            if (String.IsNullOrEmpty(this.NomeComplTextBox.Text))
            {
                MessageBox.Show("O Campo Nome não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexCnpj.IsMatch(this.CnpjTextBox.Text))
            {
                MessageBox.Show("O Campo CPF/CNPJ não está formatado corretamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexCep.IsMatch(this.CepTextBox.Text))
            {
                MessageBox.Show("O Campo CEP não está formatado corretamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(ComplTextBox.Text))
            {
                MessageBox.Show("O Campo Bairro não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(RuaTextBox.Text))
            {
                MessageBox.Show("O Campo Rua não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(NumeroTextBox.Text, out int numero))
            {
                MessageBox.Show("O Campo Número deve conter números", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(CidadeTextBox.Text))
            {
                MessageBox.Show("O Campo Cidade não pode estar vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(UFComboBox.Text)) {
                MessageBox.Show("O Campo Estado deve ser selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return update(numero);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CnpjTextBox_Leave(object sender, EventArgs e)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            fornecedor foundedFornecedor = new fornecedor();

            foundedFornecedor = db.fornecedor.Where(o => o.registro.Equals(CnpjTextBox.Text)).FirstOrDefault();
            if(foundedFornecedor != null && this.oFornecedor.idfornecedor != foundedFornecedor.idfornecedor )
            {
                MessageBox.Show("Já existe um Fornecedor com este CNPJ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CnpjTextBox.Text = "";
            }
        }

        private void CepTextBox_Leave(object sender, EventArgs e)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            endereco foundedEndereco = new endereco();

            foundedEndereco = db.endereco.Where(o => o.cep.Equals(CepTextBox.Text)).FirstOrDefault();
            if(foundedEndereco != null && this.oEndereco.idendereco != foundedEndereco.idendereco)
            {
                MessageBox.Show("Já existe um Fornecedor com este CEP", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CepTextBox.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
