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
        private bool nameIsValid, emailIsValid, cpfIdValid, passwordIsValid, roleIsSelected, sexIsSelected;

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
            //SexoComboBox.SelectedIndex = 0;
            //TipoUsrComboBox.SelectedIndex = 0;
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
            if (SexoComboBox.SelectedItem == "Masculino")
            {
                this.oUsuario.sexo = "m";
            }
            else if (SexoComboBox.SelectedItem == "Feminino")
            {
                this.oUsuario.sexo = "f";
            }
            this.oUsuario.dataNascimento = DateTime.Parse(DataNascDTP.Text);
            return true;
        }

        private Boolean updateEndereco()
        {
            this.oEndereco.complemento = this.ComplTextBox.Text;
            this.oEndereco.rua = this.RuaTextBox.Text;
            this.oEndereco.cep = this.CepTextBox.Text;
            this.oEndereco.cidade = this.CidadeTextBox.Text;
            this.oEndereco.estado = UFComboBox.Text.Substring(0, 2);
            return updateUsuario();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(validateAllFields())
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool emailAlreadyRegisted()
        {
            usuario foundedUsuario = new usuario();
            foundedUsuario = pUsuario.LoadWhere(o => o.email.Equals(EmailTextBox.Text));
            if (foundedUsuario != null && this.oUsuario.idusuario != foundedUsuario.idusuario)
            {
                return true;
            }
            return false;
        }

        private bool cpfIsValid()
        {
            usuario foundedCliente = new usuario();

            foundedCliente = pUsuario.LoadWhere(o => o.cpf.Equals(CpfTextBox.Text));

            if (!Cpf.Validar(this.CpfTextBox.Text))
            {
                CpfErrorLabel.Visible = true;
                CpfErrorLabel.Text = "CPF não é válido";
                CpfTextBox.Focus();
                return false;
            }

            if (foundedCliente != null && this.oUsuario.idusuario != foundedCliente.idusuario)
            {
                CpfErrorLabel.Visible = true;
                CpfErrorLabel.Text = "CPF já cadastrado";
                CpfTextBox.Focus();
                return false;
            }

            return true;

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

            if (Regex.IsMatch(this.SenhaTextBox.Text, @".*[A-Z].*"))
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

            InsertBtn.Enabled = allFieldsFilled();
        }
        
        private bool allFieldsFilled()
        {
            if (String.IsNullOrEmpty(NomeComplTextBox.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                return false;
            }if(CpfTextBox.Text.Length < 14)
            {
                return false;
            }
            if (!regexSenha.IsMatch(SenhaTextBox.Text))
            {
                return false; 
            }
            if (SexoComboBox.SelectedItem == null)
            {
                return false;
            }
            if (TipoUsrComboBox.SelectedItem == null)
            {
                return false;
            }
            if(CepTextBox.Text.Length < 9)
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



        private void NomeComplTextBox_TextChanged(object sender, EventArgs e)
        {
            InsertBtn.Enabled = allFieldsFilled();
        }

        private void RuaTextBox_TextChanged(object sender, EventArgs e)
        {
            InsertBtn.Enabled = allFieldsFilled();
        }

        private void ComplTextBox_TextChanged(object sender, EventArgs e)
        {
            InsertBtn.Enabled = allFieldsFilled();
        }

        private void CidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            InsertBtn.Enabled = allFieldsFilled();
        }

        
        private void NumeroTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!NumeroTextBox.Text.Equals(""))
            {
                if (int.TryParse(NumeroTextBox.Text, out int num))
                {
                    NumeroErrorLabel.Visible = true;
                    this.oEndereco.numero = num;
                }
                NumeroErrorLabel.Visible = false;
            }
        }

        private void TipoUsrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertBtn.Enabled = allFieldsFilled();
        }

        private void SexoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            InsertBtn.Enabled = allFieldsFilled();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailErrorLabel.Visible = false;
            InsertBtn.Enabled = allFieldsFilled();
        }

        private void CpfTextBox_TextChanged(object sender, EventArgs e)
        {
            CpfErrorLabel.Visible = false;
            InsertBtn.Enabled = allFieldsFilled();
        }

        private void DataNascDTP_ValueChanged(object sender, EventArgs e)
        {
            DateErrorLabel.Visible = false;
            InsertBtn.Enabled = allFieldsFilled();
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

                    this.RuaTextBox.Text = "";
                    this.ComplTextBox.Text = "";
                    this.CidadeTextBox.Text = "";
                    this.UFComboBox.SelectedItem = "";

                    this.ComplTextBox.ReadOnly = true;
                    this.RuaTextBox.ReadOnly = true;
                    this.CidadeTextBox.ReadOnly = true;
                    this.UFComboBox.Enabled = false;

                    InsertBtn.Enabled = false;
                }
                InsertBtn.Enabled = allFieldsFilled();
            }
            else
            {
                InsertBtn.Enabled = allFieldsFilled();
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

        private bool validateAllFields()
        {
            
            if (emailAlreadyRegisted())
            {
                EmailErrorLabel.Visible = true;
                EmailErrorLabel.Text = "Esse Email já foi cadastrado";
                EmailTextBox.Focus();
                return false;
            }
            if (!regexEmail.IsMatch(EmailTextBox.Text))
            {
                EmailErrorLabel.Visible = true;
                EmailErrorLabel.Text = "Email não está formatado";
                EmailTextBox.Focus();
                return false;
            }
            if (!cpfIsValid())
            {
                return false;
            }
            if (DataNascDTP.Value.Year > DateTime.Now.Year)
            {
                DateErrorLabel.Text = "Data inválida";
                DateErrorLabel.Visible = true;
                DataNascDTP.Focus();
                return false;
            }
            else if ((DataNascDTP.Value.Year + 18) > DateTime.Now.Year)
            {
                DateErrorLabel.Text = "O usuário deve ser maior de Idade";
                DateErrorLabel.Visible = true;
                DataNascDTP.Focus();
                return false;

            }

            return updateEndereco();
        }
    }
}
