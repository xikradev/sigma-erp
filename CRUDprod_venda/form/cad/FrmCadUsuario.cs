using CpfCnpjLibrary;
using ErpSigmaVenda.linq;
using ErpSigmaVenda.persistencia;
using ErpSigmaVenda.query;
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

namespace ErpSigmaVenda.login
{
    public partial class FrmCadUsuario : Form
    {
        public usuario oUsuario = new usuario();
        public endereco oEndereco = new endereco();
        Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        Regex regexCpfCnpj = new Regex(@"^(?:\d{3}\.\d{3}\.\d{3}-\d{2}|\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2})$", RegexOptions.IgnoreCase);
        Regex regexSenha = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])[0-9a-zA-Z$*&@#]{8,}$");
        Regex regexCep = new Regex(@"^\d{5}-\d{3}$", RegexOptions.IgnoreCase);

        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            SexoComboBox.SelectedIndex = 0;
            TipoUsrComboBox.SelectedIndex = 0;
            NomeComplTextBox.Text = this.oUsuario.nomeCompleto;
            EmailTextBox.Text = this.oUsuario.email;
            CpfTextBox.Text = this.oUsuario.cpf;
            SenhaTextBox.Text = this.oUsuario.senha;
            if (this.oUsuario.role == "ADM")
            {
                TipoUsrComboBox.SelectedItem = "ADM";
                
            }
            else if (this.oUsuario.role == "Vendedor")
            {
                TipoUsrComboBox.SelectedItem = "Vendedor";
                
            }

            if (this.oUsuario.sexo == "m")
            {
                SexoComboBox.SelectedItem = "Masculino";
            }
            else if (this.oUsuario.sexo == "f")
            {
                SexoComboBox.SelectedItem = "Feminino";
            }
            if (this.oUsuario.dataNascimento.Year > 1)
            {
                this.DataNascDTP.Value = this.oUsuario.dataNascimento;
            }
            this.ComplTextBox.Text = this.oEndereco.complemento;
            this.CepTextBox.Text = this.oEndereco.cep;
            this.RuaTextBox.Text = this.oEndereco.rua;
            this.NumeroTextBox.Text = this.oEndereco.numero.ToString();
            this.CidadeTextBox.Text = this.oEndereco.cidade;
            this.UFComboBox.SelectedItem = this.oEndereco.estado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Boolean updateUsuario()
        {
            this.oUsuario.nomeCompleto = NomeComplTextBox.Text;
            this.oUsuario.email = EmailTextBox.Text;
            this.oUsuario.cpf = CpfTextBox.Text;
            this.oUsuario.senha = SenhaTextBox.Text;
            if(TipoUsrComboBox.SelectedItem == "ADM")
            {
                this.oUsuario.role = "ADM";
            }else if(TipoUsrComboBox.SelectedItem == "Vendedor")
            {
                this.oUsuario.role = "Vendedor";
            }
            else
            {
                MessageBox.Show("Deve se selecionar o Tipo de Usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (SexoComboBox.SelectedItem == "Masculino")
            {
                this.oUsuario.sexo = "m";
            }
            else if (SexoComboBox.SelectedItem == "Feminino")
            {
                this.oUsuario.sexo = "f";
            }
            else
            {
                MessageBox.Show("Deve se selecionar o Sexo do Usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            this.oUsuario.dataNascimento = DateTime.Parse(DataNascDTP.Text);
            return true;
        }

        private Boolean verifyUsuario()
        {
            
            
            
            
            
            

            return updateUsuario();
        }

        private Boolean updateEndereco(int numero)
        {
            this.oEndereco.complemento = this.ComplTextBox.Text;
            this.oEndereco.rua = this.RuaTextBox.Text;
            this.oEndereco.cep = this.CepTextBox.Text;
            this.oEndereco.numero = numero;
            this.oEndereco.cidade = this.CidadeTextBox.Text;
            this.oEndereco.estado = UFComboBox.Text.Substring(0, 2);
            return true;
        }


        private Boolean verifyEndereco()
        {
            if (String.IsNullOrEmpty(ComplTextBox.Text))
            {
                MessageBox.Show("O Campo Bairro não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(CepTextBox.Text) || searchCep(CepTextBox.Text) == null)
            {
                MessageBox.Show("O Campo CEP não estaformatado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(RuaTextBox.Text) || RuaTextBox.Text.Length > 100)
            {
                MessageBox.Show("O Campo Rua não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(NumeroTextBox.Text, out int numero))
            {
                MessageBox.Show("O Campo Número deve conter números", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(UFComboBox.Text))
            {
                MessageBox.Show("O Campo Estado não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(CidadeTextBox.Text) || CidadeTextBox.Text.Length > 50)
            {
                MessageBox.Show("O Campo Cidade não pode ser vazio e não pode ultrapassar de 50 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return updateEndereco(numero);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(verifyUsuario() && verifyEndereco())
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool emailValidation()
        {
            usuario foundedUsuario = new usuario();
            foundedUsuario = pUsuario.LoadWhere(o => o.email.Equals(EmailTextBox.Text));
            if (foundedUsuario != null && this.oUsuario.idusuario != foundedUsuario.idusuario)
            {

                EmailErrorLabel.Text = "Esse Email já foi cadastrado";
                return true;
            }

            if (!regexEmail.IsMatch(EmailTextBox.Text))
            {
                EmailErrorLabel.Text = "Email não está no formato correto";
                return true;
            }
            return false;
        }

        private bool cpfValidation()
        {
            usuario foundedCliente = new usuario();

            foundedCliente = pUsuario.LoadWhere(o => o.cpf.Equals(CpfTextBox.Text));

            if (!Cpf.Validar(this.CpfTextBox.Text))
            {
                CpfErrorLabel.Text = "CPF não é válido";
                return true;
            }

            if (foundedCliente != null && this.oUsuario.idusuario != foundedCliente.idusuario)
            {
                CpfErrorLabel.Text = "CPF já cadastrado";
                CpfTextBox.Text = "";
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

       

        private void SenhaTextBox_TextChanged(object sender, EventArgs e)
        {
            

            if (this.SenhaTextBox.Text.Length >= 8)
            {
                labelRule1.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule1.ForeColor = Color.DarkRed;
            }

            if(Regex.IsMatch(this.SenhaTextBox.Text, @".*[A-Z].*"))
            {
                labelRule2.ForeColor = Color.ForestGreen;
            }
            else 
            {
                labelRule2.ForeColor = Color.DarkRed;
            }

            if (Regex.IsMatch(this.SenhaTextBox.Text, @".*\d.*"))
            {
                labelRule3.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule3.ForeColor = Color.DarkRed;
            }
            
            if (Regex.IsMatch(this.SenhaTextBox.Text, @".*[$*&@#].*"))
            {
                labelRule4.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule4.ForeColor = Color.DarkRed;
            }
            if (!String.IsNullOrEmpty(this.SenhaTextBox.Text) && !Regex.IsMatch(this.SenhaTextBox.Text, @".*(.)\1.*"))
            {
                labelRule5.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule5.ForeColor = Color.DarkRed;
            }


        }

        private void CepTextBox_Leave(object sender, EventArgs e)
        {
           
        }

        private bool camposPreenchidos()
        {
            if (String.IsNullOrEmpty(NomeComplTextBox.Text))
            {
                NameErrorLabel.Visible = true;

                return false;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(CpfTextBox.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(SenhaTextBox.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(CepTextBox.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(RuaTextBox.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(ComplTextBox.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(CidadeTextBox.Text))
            {
                return false;
            }
           

            return true;

        }
        

        private void NomeComplTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NomeComplTextBox.Text))
            {
                
                //NomeComplTextBox.Focus();
                InsertBtn.Enabled = false;
            }
            else
            {
                InsertBtn.Enabled = camposPreenchidos();
            }
        }

        private void NomeComplTextBox_TextChanged(object sender, EventArgs e)
        {
            NameErrorLabel.Visible = false;
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailValidation())
            {
                EmailErrorLabel.Visible = true;
               // EmailTextBox.Focus();
                InsertBtn.Enabled = false;
            }
            else
            {
                InsertBtn.Enabled = camposPreenchidos();
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailErrorLabel.Visible = false;
        }

        private void CpfTextBox_Leave(object sender, EventArgs e)
        {
            if (cpfValidation())
            {
                CpfErrorLabel.Visible= true;
                //CpfTextBox.Focus();
                InsertBtn.Enabled = false;
            }
            else
            {
                InsertBtn.Enabled = camposPreenchidos();
            }
        }

        private void CpfTextBox_TextChanged(object sender, EventArgs e)
        {
            CpfErrorLabel.Visible = false;
        }

        private void DataNascDTP_Leave(object sender, EventArgs e)
        {
            if ((DataNascDTP.Value.Year + 18) > DateTime.Now.Year)
            {
                DateErrorLabel.Text = "O usuário deve ser maior de Idade";
                DateErrorLabel.Visible = true;
                InsertBtn.Enabled = false;

            }
            else if(DataNascDTP.Value.Year > DateTime.Now.Year)
            {
                DateErrorLabel.Text = "Data inválida";
                DateErrorLabel.Visible = true;
                InsertBtn.Enabled = false;
            }
            else
            {
                DateErrorLabel.Visible = false;
                InsertBtn.Enabled = camposPreenchidos();
            }
        }

        private void SenhaTextBox_Leave(object sender, EventArgs e)
        {
            if (!regexSenha.IsMatch(SenhaTextBox.Text))
            {
                InsertBtn.Enabled = false;
            }
            else
            {
                InsertBtn.Enabled = camposPreenchidos();
            }
        }

        private void CepTextBox_TextChanged(object sender, EventArgs e)
        {
            if(CepTextBox.Text.Length == 9)
            {
                var result = searchCep(this.CepTextBox.Text);
                if (result.ZipCode != null)
                {
                    this.RuaTextBox.Text = result.Street;
                    this.ComplTextBox.Text = result.Neighborhood + " " + result.Complement;
                    this.CidadeTextBox.Text = result.City;
                    this.UFComboBox.SelectedItem = result.StateInitials;

                    this.ComplTextBox.ReadOnly = false;
                    this.RuaTextBox.ReadOnly = false;
                    this.CidadeTextBox.ReadOnly = false;
                    this.UFComboBox.Enabled = true;
                }
                else
                {
                    CepErrorLabel.Visible = true;
                    CepErrorLabel.Text = "CEP inválido";

                    this.ComplTextBox.ReadOnly = true;
                    this.RuaTextBox.ReadOnly = true;
                    this.CidadeTextBox.ReadOnly = true;
                    this.UFComboBox.Enabled = false;

                    InsertBtn.Enabled = false;
                }

                endereco foundedEndereco = new endereco();
                foundedEndereco = pEndereco.LoadWhere(o => o.cep.Equals(CepTextBox.Text));
                if (foundedEndereco != null && this.oEndereco.idendereco != foundedEndereco.idendereco)
                {
                    CepErrorLabel.Visible = true;
                    CepErrorLabel.Text = "CEP já cadastrado";

                    this.ComplTextBox.ReadOnly = true;
                    this.RuaTextBox.ReadOnly = true;
                    this.CidadeTextBox.ReadOnly = true;
                    this.UFComboBox.Enabled = false;

                    InsertBtn.Enabled = false;
                }
            }
            else
            {
                CepErrorLabel.Visible = false;

                this.ComplTextBox.ReadOnly = true;
                this.RuaTextBox.ReadOnly = true;
                this.CidadeTextBox.ReadOnly = true;
                this.UFComboBox.Enabled = false;

                this.RuaTextBox.Text = "";
                this.ComplTextBox.Text = "";
                this.CidadeTextBox.Text = "";
                this.UFComboBox.SelectedItem = ""; 
            }
        }

        private void CepTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
