using ErpSigmaVenda.conexão;
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

namespace ErpSigmaVenda.login
{
    public partial class FrmCadUsuario : Form
    {
        public usuario oUsuario = new usuario();
        public endereco oEndereco = new endereco();
        Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        Regex regexCpf = new Regex(@"^(\d{2}\.?\d{3}\.?\d{3}\/?\d{4}-?\d{2}|\d{3}\.?\d{3}\.?\d{3}-?\d{2})$", RegexOptions.IgnoreCase);
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
            NomeTextBox.Text = this.oUsuario.nomeCompleto;
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
            this.BairroTextBox.Text = this.oEndereco.complemento;
            this.CepTextBox.Text = this.oEndereco.cep;
            this.RuaTextBox.Text = this.oEndereco.rua;
            this.NumeroTextBox.Text = this.oEndereco.numero.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Boolean updateUsuario()
        {
            this.oUsuario.nomeCompleto = NomeTextBox.Text;
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
                //return false;
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
                //return false;
            }
            this.oUsuario.dataNascimento = DateTime.Parse(DataNascDTP.Text);
            return true;
        }

        private Boolean verifyUsuario()
        {
            if (String.IsNullOrEmpty(NomeTextBox.Text))
            {
                MessageBox.Show("O Campo Nome não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(SobrenomeTextBox.Text))
            {
                MessageBox.Show("O Campo Sobrenome não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexEmail.IsMatch(EmailTextBox.Text))
            {
                MessageBox.Show("O Campo Email não está formatado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexSenha.IsMatch(SenhaTextBox.Text))
            {
                MessageBox.Show("A senha não está formatada corretamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexCpf.IsMatch(CpfTextBox.Text))
            {
                MessageBox.Show("O Campo CPF não está formatado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DataNascDTP.Value > DateTime.Now)
            {
                MessageBox.Show("Coloque uma Data de Nascimento correta!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return updateUsuario();
        }

        private Boolean updateEndereco(int numero)
        {
            this.oEndereco.complemento = this.BairroTextBox.Text;
            this.oEndereco.rua = this.RuaTextBox.Text;
            this.oEndereco.cep = this.CepTextBox.Text;
            this.oEndereco.numero = numero;
            return true;
        }


        private Boolean verifyEndereco()
        {
            if (String.IsNullOrEmpty(BairroTextBox.Text))
            {
                MessageBox.Show("O Campo Bairro não pode ser vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!regexCep.IsMatch(CepTextBox.Text))
            {
                MessageBox.Show("O Campo CEP não estaformatado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            return updateEndereco(numero);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(verifyUsuario() && verifyEndereco())
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void CepTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            usuario foundedUsuario = new usuario();
            foundedUsuario = db.usuario.Where(o => o.email.Equals(EmailTextBox.Text)).FirstOrDefault();
            if (foundedUsuario != null && this.oUsuario.idusuario != foundedUsuario.idusuario)
            {
                MessageBox.Show("Já existe um Usuário com este Email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTextBox.Text = "";
            }
        }

        private void CpfTextBox_Leave(object sender, EventArgs e)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            usuario foundedUsuario = new usuario();
            foundedUsuario = db.usuario.Where(o => o.cpf.Equals(CpfTextBox.Text)).FirstOrDefault();
            if (foundedUsuario != null && this.oUsuario.idusuario != foundedUsuario.idusuario)
            {
                MessageBox.Show("Já existe um Usuário com este CPF", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CpfTextBox.Text = "";
            }
        }

        private void CepTextBox_Leave(object sender, EventArgs e)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            endereco foundedEndereco = new endereco();
            foundedEndereco = db.endereco.Where(o => o.cep.Equals(CepTextBox.Text)).FirstOrDefault();
            if (foundedEndereco != null && this.oEndereco.idendereco != foundedEndereco.idendereco)
            {
                MessageBox.Show("Já existe um Usuário com este CEP", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CepTextBox.Text = "";
            }
        }
    }
}
