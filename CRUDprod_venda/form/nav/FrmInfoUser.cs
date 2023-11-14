
using ErpSigmaVenda.linq;
using ErpSigmaVenda.navegacao;
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

namespace ErpSigmaVenda.form.nav
{
    public partial class FrmInfoUser : Form
    {
        Regex regexSenha = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])[0-9a-zA-Z$*&@#]{8,}$");
        usuario oUsuario = new usuario();

        public FrmInfoUser()
        {
            InitializeComponent();
        }

        

        private void FrmInfoUser_Load(object sender, EventArgs e)
        {
            loading();

        }

        private void loading()
        {
            this.oUsuario = pLoginUsr.oUsuario;
            this.IdTextBox.Text = this.oUsuario.idusuario.ToString();
            this.TypeTextBox.Text = this.oUsuario.role;
            this.NameTextBox.Text = this.oUsuario.nomeCompleto;
            this.EmailTextBox.Text = this.oUsuario.email;
            this.PWTextBox.Text = this.oUsuario.senha;
        }

        private void NewPwTextBox_TextChanged(object sender, EventArgs e)
        {
            if(this.NewPwTextBox.Text.Length >= 8)
            {
                labelRule1.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule1.ForeColor = Color.DarkRed;
            }

            if (Regex.IsMatch(this.NewPwTextBox.Text, @".*[A-Z].*"))
            {
                labelRule2.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule2.ForeColor = Color.DarkRed;
            }

            if (Regex.IsMatch(this.NewPwTextBox.Text, @".*\d.*"))
            {
                labelRule3.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule3.ForeColor = Color.DarkRed;
            }

            if (Regex.IsMatch(this.NewPwTextBox.Text, @".*[$*&@#].*"))
            {
                labelRule4.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule4.ForeColor = Color.DarkRed;
            }
            if (!String.IsNullOrEmpty(this.NewPwTextBox.Text) && !Regex.IsMatch(this.NewPwTextBox.Text, @".*(.)\1.*"))
            {
                labelRule5.ForeColor = Color.ForestGreen;
            }
            else
            {
                labelRule5.ForeColor = Color.DarkRed;
            }
        }

        private void SwitchPwBtn_Click(object sender, EventArgs e)
        {
            if (regexSenha.IsMatch(this.NewPwTextBox.Text))
            {
                if (this.NewPwTextBox.Text.Equals(ConfirmPwTextBox.Text))
                {
                    var updatedUsr = pUsuario.load(this.oUsuario.idusuario);
                    updatedUsr.senha = NewPwTextBox.Text;
                    pUsuario.Update(updatedUsr);
                    pLoginUsr.GetUser(EmailTextBox.Text, NewPwTextBox.Text);
                    MessageBox.Show("Redefinição de Senha efetuada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loading();
                }
                else
                {
                    MessageBox.Show("O Campo Nova Senha deve ser igual ao Confirmar Senha", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("O Campo Senha não está na formtação correta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }

        private void SwitchUserBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
          
        }

        private void CloseProgBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
