﻿using CpfCnpjLibrary;
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

namespace ErpSigmaVenda.fornecedores
{
    public partial class FrmCadfornecedor : Form
    {
        public fornecedor oFornecedor = new fornecedor();
        public endereco oEndereco = new endereco();
        Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        Regex cpfRegex = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        Regex cnpjRegex = new Regex(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$");
        string backupRegistro = "";

        public FrmCadfornecedor()
        {
            InitializeComponent();
        }

        private void FornecedoresForm_Load(object sender, EventArgs e)
        {
            this.PJuridicaBtn.Checked = true;

            loading();
        }

        private void loading()
        {
            this.NomeComplTextBox.Text = this.oFornecedor.nomeCompleto;
            this.EmailTextBox.Text = this.oFornecedor.email;
            if (!String.IsNullOrEmpty(this.oFornecedor.registro))
            {
                if (cpfRegex.IsMatch(this.oFornecedor.registro))
                {
                    this.RegisterGroupBox.Text = "Pessoa Física";
                    this.RegisterLabel.Text = "CPF";
                    this.RegisterTextBox.Mask = "999,999,999-99";
                    this.PFisicaBtn.Checked = true;

                }
                else if (cnpjRegex.IsMatch(this.oFornecedor.registro))
                {
                    this.RegisterGroupBox.Text = "Pessoa Jurídica";
                    this.RegisterLabel.Text = "CNPJ";
                    this.RegisterTextBox.Mask = "99,999,999/9999-99";
                    this.PJuridicaBtn.Checked = true;

                }
            }
            this.RegisterTextBox.Text = this.oFornecedor.registro;
            this.SeguimTextBox.Text = this.oFornecedor.seguimento;
            this.backupRegistro = this.RegisterTextBox.Text;
            if (this.oFornecedor.sexo == "F")
            {
                this.SexoComboBox.SelectedItem = "Masculino";
            }
            else if (this.oFornecedor.sexo == "F")
            {
                this.SexoComboBox.SelectedItem = "Feminino";
            }
            if (this.oFornecedor.dataNascimento.Year > 1)
            {
                this.DataNascDTP.Value = this.oFornecedor.dataNascimento;
            }
            this.ComplTextBox.Text = this.oEndereco.complemento;
            this.CepTextBox.Text = this.oEndereco.cep;
            this.RuaTextBox.Text = this.oEndereco.rua;
            this.NumeroTextBox.Text = this.oEndereco.numero == 0 ? "" : this.oEndereco.numero.ToString();
            this.CidadeTextBox.Text = this.oEndereco.cidade;
            this.UFComboBox.SelectedItem = this.oEndereco.estado;
            this.backupRegistro = this.RegisterTextBox.Text;
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

        private Boolean updateFornecedor()
        {
            this.oFornecedor.nomeCompleto = NomeComplTextBox.Text;
            this.oFornecedor.email = EmailTextBox.Text;
            this.oFornecedor.registro = RegisterTextBox.Text;
            this.oFornecedor.seguimento = PJuridicaBtn.Checked ? SeguimTextBox.Text : null;
            if (SexoComboBox.SelectedItem == "Masculino")
            {
                this.oFornecedor.sexo = "M";
            }
            else if (SexoComboBox.SelectedItem == "Feminino")
            {
                this.oFornecedor.sexo = "F";
            }
            else
            {
                this.oFornecedor.sexo = PFisicaBtn.Checked ? this.oFornecedor.sexo : null;
            }

            this.oFornecedor.dataNascimento = DateTime.Parse(DataNascDTP.Text);

            return true;
        }

        private Boolean verifyFornecedor()
        {
            if (String.IsNullOrEmpty(NomeComplTextBox.Text) || NomeComplTextBox.Text.Length > 150)
            {
                MessageBox.Show("O Campo Nome não pode estar vazio e não pode ultrapassar de 150 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (EmailValidation())
            {
                return false;
            }
            if (cnpjValidation())
            {
                return false;

            }
            else if (cpfValidation())
            {
                return false;
            }
            if (PJuridicaBtn.Checked && DataNascDTP.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Data de Nascimento incorreta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (PFisicaBtn.Checked && (DataNascDTP.Value.Year + 18) > DateTime.Now.Year || DataNascDTP.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("O Cliente não pode ser Menor de idade", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (PJuridicaBtn.Checked && (String.IsNullOrEmpty(SeguimTextBox.Text) || SeguimTextBox.Text.Length > 100))
            {
                MessageBox.Show("O Campo Seguimento não pode ser vazio e nem pode ultrpassar mais de 100 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return updateFornecedor();
        }

        private Boolean updateEndereco(int numero)
        {
            this.oEndereco.complemento = ComplTextBox.Text;
            this.oEndereco.cep = CepTextBox.Text;
            this.oEndereco.rua = RuaTextBox.Text;
            this.oEndereco.numero = numero;
            this.oEndereco.cidade = CidadeTextBox.Text;
            this.oEndereco.estado = UFComboBox.Text;

            return true;
        }

        private Boolean verifyEndereco()
        {
            if (String.IsNullOrEmpty(ComplTextBox.Text) || ComplTextBox.Text.Length > 100)
            {
                MessageBox.Show("O Campo Complemento não pode ser vazio e não pode ultrapassar de 100 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(RuaTextBox.Text) || RuaTextBox.Text.Length > 100)
            {
                MessageBox.Show("O Campo Rua não pode ser vazio e não pode ultrapassar de 100 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(NumeroTextBox.Text, out int numero))
            {
                MessageBox.Show("O Campo Número deve conter somente números", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(CidadeTextBox.Text) || CidadeTextBox.Text.Length > 50)
            {
                MessageBox.Show("O Campo Cidade não pode ser vazio e não pode ultrapassar de 50 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(UFComboBox.Text))
            {
                MessageBox.Show("O Campo Estado não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(CepTextBox.Text) || searchCep(CepTextBox.Text) == null)
            {
                MessageBox.Show("O Campo CEP não está formatado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return updateEndereco(numero);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (verifyFornecedor() && verifyEndereco())
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

        private bool EmailValidation()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            fornecedor foundedFornecedor = new fornecedor();

            foundedFornecedor = db.fornecedor.Where(o => o.email.Equals(EmailTextBox.Text)).FirstOrDefault();
            if (foundedFornecedor != null && this.oFornecedor.idfornecedor != foundedFornecedor.idfornecedor)
            {
                MessageBox.Show("Já existe um registro com esse Email, por favor insire outro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (!regexEmail.IsMatch(EmailTextBox.Text))
            {
                MessageBox.Show("O Campo Email tem que estar no formato correto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (EmailTextBox.Text.Length > 80)
            {
                MessageBox.Show("O Campo Email não pode ultrapassar 80 Caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void PFisicaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PFisicaBtn.Checked)
            {
                this.RegisterGroupBox.Text = "Pessoa Física";
                this.RegisterLabel.Text = "CPF";
                this.SeguimGB.Visible = false;
                this.SexoGB.Visible = true;
                if (this.backupRegistro.Length > 14 && this.RegisterTextBox.Text.Length > 12)
                {
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
        private bool cpfValidation()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            fornecedor foundedFornecedor = new fornecedor();

            foundedFornecedor = db.fornecedor.Where(o => o.registro.Equals(RegisterTextBox.Text)).FirstOrDefault();

            if (this.PFisicaBtn.Checked && !Cpf.Validar(this.RegisterTextBox.Text))
            {
                MessageBox.Show("CPF Inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (foundedFornecedor != null && this.oFornecedor.idfornecedor != foundedFornecedor.idfornecedor)
            {
                MessageBox.Show("Já existe um Cliente com este CPF", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegisterTextBox.Text = "";
                return true;
            }

            return false;

        }

        private bool cnpjValidation()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            fornecedor foundedFornecedor = new fornecedor();

            foundedFornecedor = db.fornecedor.Where(o => o.registro.Equals(RegisterTextBox.Text)).FirstOrDefault();

            if (this.PJuridicaBtn.Checked && !Cnpj.Validar(this.RegisterTextBox.Text))
            {
                MessageBox.Show("CNPJ Inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (foundedFornecedor != null && this.oFornecedor.idfornecedor != foundedFornecedor.idfornecedor)
            {
                MessageBox.Show("Já existe um Cliente com este CNPJ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegisterTextBox.Text = "";
                return true;
            }

            return false;
        }

        private ViaCepResult searchCep(string cep)
        {
            try
            {
                return new ViaCepClient().Search(cep);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        private void CepTextBox_Leave(object sender, EventArgs e)
        {
            var result = searchCep(this.CepTextBox.Text);
            if (result != null)
            {
                this.RuaTextBox.Text = result.Street;
                this.ComplTextBox.Text = result.Neighborhood + " " + result.Complement;
                this.CidadeTextBox.Text = result.City;
                this.UFComboBox.SelectedItem = result.StateInitials;
            }
            else
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
    }
}
