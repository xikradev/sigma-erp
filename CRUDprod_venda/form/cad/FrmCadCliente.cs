using CpfCnpjLibrary;
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
using ViaCep;

namespace ErpSigmaVenda.clientes
{
    public partial class FrmCadCliente : Form
    {
        public cliente oCliente = new cliente();
        public endereco oEndereco = new endereco();
        Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        Regex cpfRegex = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        Regex cnpjRegex = new Regex(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$");
        Regex regexCep = new Regex(@"^\d{5}-\d{3}$", RegexOptions.IgnoreCase);
        string backupRegistro = "";


        public FrmCadCliente()
        {
            InitializeComponent();
        }

       

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            this.PJuridicaBtn.Checked = true;
            
            this.loading();
        }

        private void loading()
        {   
            this.NomeComplTextBox.Text = this.oCliente.nomeCompleto;
            this.EmailTextBox.Text = this.oCliente.email;
            if (!String.IsNullOrEmpty(this.oCliente.registro))
            {
                if (cpfRegex.IsMatch(this.oCliente.registro))
                {
                    this.RegisterGroupBox.Text = "Pessoa Física";
                    this.RegisterLabel.Text = "CPF";
                    this.RegisterTextBox.Mask = "999,999,999-99";
                    this.PFisicaBtn.Checked = true;
                    
                }
                else if (cnpjRegex.IsMatch(this.oCliente.registro))
                {
                    this.RegisterGroupBox.Text = "Pessoa Jurídica";
                    this.RegisterLabel.Text = "CNPJ";
                    this.RegisterTextBox.Mask = "99,999,999/9999-99";
                    this.PJuridicaBtn.Checked = true;
                    
                }
            }
            this.RegisterTextBox.Text = this.oCliente.registro;
            this.SeguimTextBox.Text = this.oCliente.seguimento;
            this.backupRegistro = this.RegisterTextBox.Text;
            if (this.oCliente.sexo == "F")
            {
                this.SexoComboBox.SelectedItem = "Masculino";
            }
            else if (this.oCliente.sexo == "F")
            {
                this.SexoComboBox.SelectedItem = "Feminino";
            }
            if(this.oCliente.dataNascimento.Year > 1)
            {
                this.DataNascDTP.Value = this.oCliente.dataNascimento;
            }
            this.ComplTextBox.Text = this.oEndereco.complemento;
            this.CepTextBox.Text = this.oEndereco.cep;
            this.RuaTextBox.Text = this.oEndereco.rua;
            this.NumeroTextBox.Text = this.oEndereco.numero == 0? "" : this.oEndereco.numero.ToString();
            this.CidadeTextBox.Text = this.oEndereco.cidade;
            this.UFComboBox.SelectedItem = this.oEndereco.estado;
            this.backupRegistro = this.RegisterTextBox.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Boolean updateCliente()
        {
            this.oCliente.nomeCompleto = NomeComplTextBox.Text;
            this.oCliente.email = EmailTextBox.Text;
            this.oCliente.registro = RegisterTextBox.Text;
            this.oCliente.seguimento = PJuridicaBtn.Checked ? SeguimTextBox.Text : null;
            if (SexoComboBox.SelectedItem == "Masculino")
            {
                this.oCliente.sexo = "M";
            }
            else if (SexoComboBox.SelectedItem == "Feminino")
            {
                this.oCliente.sexo = "F";
            }
            else
            {
                this.oCliente.sexo = PFisicaBtn.Checked ? this.oCliente.sexo : null;
            }
            
            this.oCliente.dataNascimento = DateTime.Parse(DataNascDTP.Text);

            return true;
        }

        
        private Boolean verifyCliente()
        {
            if (String.IsNullOrEmpty(NomeComplTextBox.Text))
            {
                MessageBox.Show("O Campo Nome não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexEmail.IsMatch(EmailTextBox.Text))
            {
                MessageBox.Show("O Campo Email não está formatado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (PJuridicaBtn.Checked)
            {
                if (!cnpjRegex.IsMatch(RegisterTextBox.Text))
                {
                    MessageBox.Show("O Campo CNPJ não está em formatação correta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(DataNascDTP.Value.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Data de Nascimento incorreta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                if (!cpfRegex.IsMatch(RegisterTextBox.Text))
                {
                    MessageBox.Show("O Campo CPF não está em formatação correta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if ((DataNascDTP.Value.Year + 18) > DateTime.Now.Year && DataNascDTP.Value.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Data de Nascimento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            

            return updateCliente();
        }




        private Boolean updateEndereco(int numero)
        {
            this.oEndereco.complemento = ComplTextBox.Text;
            this.oEndereco.cep = CepTextBox.Text;
            this.oEndereco.rua = RuaTextBox.Text;
            this.oEndereco.numero = numero;
            this.oEndereco.cidade = CidadeTextBox.Text;
            this.oEndereco.estado = UFComboBox.Text.Substring(0, 2);

            return true;
        }

        
        private Boolean verifyEndereco()
        {
            if (String.IsNullOrEmpty(ComplTextBox.Text))
            {
                MessageBox.Show("O Campo Complemento não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexCep.IsMatch(CepTextBox.Text))
            {
                MessageBox.Show("O Campo CEP não estaformatado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(RuaTextBox.Text)){
                MessageBox.Show("O Campo Rua não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!int.TryParse(NumeroTextBox.Text, out int numero))
            {
                MessageBox.Show("O Campo Número deve conter números", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(CidadeTextBox.Text))
            {
                MessageBox.Show("O Campo Cidade não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(UFComboBox.Text))
            {
                MessageBox.Show("O Campo Estado não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return updateEndereco(numero);
        }
        
      
        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (verifyCliente() && verifyEndereco())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            cliente foundedCliente = new cliente();

            foundedCliente = db.cliente.Where(o => o.email.Equals(EmailTextBox.Text)).FirstOrDefault();
            if(foundedCliente != null && this.oCliente.idcliente != foundedCliente.idcliente)
            {
                MessageBox.Show("Já existe um Cliente com este Email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTextBox.Text = "";
            }
        }

        

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PFisicaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PFisicaBtn.Checked)
            {
                this.RegisterGroupBox.Text = "Pessoa Física";
                this.RegisterLabel.Text = "CPF";
                this.SeguimGB.Visible = false;
                this.SexoGB.Visible = true;
                if (this.backupRegistro.Length > 14 && this.RegisterTextBox.Text.Length > 12) {
                    this.backupRegistro = this.RegisterTextBox.Text;
                }
                this.RegisterTextBox.Mask = "999,999,999-99";
                if (this.backupRegistro.Length <= 14)
                {
                    this.RegisterTextBox.Text = this.backupRegistro;
                    
                }
                else
                {
                    this.RegisterTextBox.Text = "";
                }
            }
        }

        private void PJuridicaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PJuridicaBtn.Checked)
            {
                this.RegisterGroupBox.Text = "Pessoa Jurídica";
                this.RegisterLabel.Text = "CNPJ";
                this.SeguimGB.Visible = true;
                this.SexoGB.Visible = false;
                if (this.backupRegistro.Length < 14 && this.RegisterTextBox.Text.Length <= 12)
                {
                    this.backupRegistro = this.RegisterTextBox.Text;
                }
                this.RegisterTextBox.Mask = "99,999,999/9999-99";
                if (this.backupRegistro.Length > 14)
                {
                    this.RegisterTextBox.Text = this.backupRegistro;
                }
                else
                {
                    this.RegisterTextBox.Text = "";
                }
            }

        }

        private void RegisterTextBox_Leave(object sender, EventArgs e)
        {
            if (this.PFisicaBtn.Checked && !Cpf.Validar(this.RegisterTextBox.Text))
            {
                MessageBox.Show("CPF Inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (this.PJuridicaBtn.Checked && !Cnpj.Validar(this.RegisterTextBox.Text))
            {
                MessageBox.Show("CNPJ Inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            venda_produtoEntities db = new venda_produtoEntities();
            cliente foundedCliente = new cliente();

            foundedCliente = db.cliente.Where(o => o.registro.Equals(RegisterTextBox.Text)).FirstOrDefault();
            if (foundedCliente != null && this.oCliente.idcliente != foundedCliente.idcliente)
            {
                MessageBox.Show("Já existe um Cliente com este CPF/CNPJ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegisterTextBox.Text = "";
            }
        }

        private void CepTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                var result = new ViaCepClient().Search(this.CepTextBox.Text);
                if (result != null)
                {
                    this.RuaTextBox.Text = result.Street;
                    this.ComplTextBox.Text = result.Neighborhood + " " + result.Complement;
                    this.CidadeTextBox.Text = result.City;
                    this.UFComboBox.SelectedItem = $"{result.StateInitials}";
                }
                else
                {
                    MessageBox.Show("CEP Inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("CEP Inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            venda_produtoEntities db = new venda_produtoEntities();
            endereco foundedEndereco = new endereco();
            foundedEndereco = db.endereco.Where(o => o.cep.Equals(CepTextBox.Text)).FirstOrDefault();
            if (foundedEndereco != null && this.oEndereco.idendereco != foundedEndereco.idendereco)
            {
                MessageBox.Show("Já existe um Cliente com este CEP", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CepTextBox.Text = "";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
