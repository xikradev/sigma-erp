using ErpSigmaVenda.linq;
using ErpSigmaVenda.login;
using ErpSigmaVenda.navegacao;
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
        //private venda_produtoEntities db = new venda_produtoEntities();
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
            //usuarioForm.oEndereco = new endereco();
            //usuarioForm.oUsuario = new usuario();
            if(usuarioForm.ShowDialog() == DialogResult.OK)
            {
                //db = new venda_produtoEntities();
                //db.endereco.Add(usuarioForm.oEndereco);
                try
                {
                    //db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Propriedade: {validationError.PropertyName}, Erro: {validationError.ErrorMessage}");
                        }
                    }
                }

                //db = new venda_produtoEntities();
                usuarioForm.oUsuario.idendereco = usuarioForm.oEndereco.idendereco;
                //db.usuario.Add(usuarioForm.oUsuario);
                //db.SaveChanges();
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
