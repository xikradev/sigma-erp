using ErpSigmaVenda.linq;
using ErpSigmaVenda.login;
using ErpSigmaVenda.navegacao;
using ErpSigmaVenda.persistencia;
using ErpSigmaVenda.query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda
{
    public partial class FrmLogin : Form
    {
        public static usuario oUsuario { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmCadUsuario usuarioForm = new FrmCadUsuario();
            usuarioForm.oEndereco = pEndereco.Create();
            usuarioForm.oUsuario = pUsuario.Create();
            if(usuarioForm.ShowDialog() == DialogResult.OK)
            {
                pEndereco.Insert(usuarioForm.oEndereco);
                usuarioForm.oUsuario.idendereco = usuarioForm.oEndereco.idendereco;
                pUsuario.Insert(usuarioForm.oUsuario);
                EmailTextBox.Text = "";
                SenhaTextBox.Text = "";
                
            }
        }

        private void login()
        {
            oUsuario = pLoginUsr.GetUser(EmailTextBox.Text, SenhaTextBox.Text);
            if (oUsuario != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Login Inválido, Verifique seu Email e senha", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                login();

            }
            if(Convert.ToInt32(e.KeyChar) == 27)
            {
                Application.Exit();
            }
        }

        

        private void PwViewBtn_MouseDown(object sender, MouseEventArgs e)
        {
            SenhaTextBox.UseSystemPasswordChar = false;
        }

        private void PwViewBtn_MouseUp(object sender, MouseEventArgs e)
        {
            SenhaTextBox.UseSystemPasswordChar = true;
        }
    }
}
