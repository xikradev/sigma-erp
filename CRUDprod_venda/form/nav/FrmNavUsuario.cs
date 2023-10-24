using ErpSigmaVenda.conexão;
using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.login;
using ErpSigmaVenda.query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda.usuarios
{
    public partial class FrmNavUsuario : Form
    {
        private venda_produtoEntities db = new venda_produtoEntities();
        usuario oUsuario = new usuario();

        public FrmNavUsuario()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            FrmCadUsuario usuarioForm = new FrmCadUsuario();
            usuarioForm.oUsuario = new usuario();
            usuarioForm.oEndereco = new endereco();
            if (usuarioForm.ShowDialog() == DialogResult.OK)
            {
                db = new venda_produtoEntities();
                db.endereco.Add(usuarioForm.oEndereco);
                db.SaveChanges();
                db = new venda_produtoEntities();
                usuarioForm.oUsuario.idendereco = usuarioForm.oEndereco.idendereco;
                db.usuario.Add(usuarioForm.oUsuario);
                db.SaveChanges();
                loading();
            }
        }

        private void UsuarioMainScreen_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading() {

            dg.DataSource = pUsuario.GetUsuario();
            if (db.usuario.ToList().Count() == 0)
            {
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrmCadUsuario usuarioForm = new FrmCadUsuario();
            usuarioForm.oUsuario = db.usuario.Find(this.oUsuario.idusuario);
            usuarioForm.oEndereco = db.endereco.Find(this.oUsuario.idendereco);
            if (usuarioForm.ShowDialog() == DialogResult.OK) {
                db.SaveChanges();
                loading();
            }
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AxUsuario axUsuario = (AxUsuario)dg.SelectedRows[0].DataBoundItem;
                this.oUsuario = db.usuario.Find(axUsuario.idusuario);
            }
            catch (Exception ex) {

            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja apagar esse dado?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.usuario.Remove(db.usuario.Find(this.oUsuario.idusuario));
                db.SaveChanges();
                loading();
            }
        }
    }
}
