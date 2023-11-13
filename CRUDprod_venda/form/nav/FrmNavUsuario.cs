using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.linq;
using ErpSigmaVenda.login;
using ErpSigmaVenda.persistencia;
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
        private dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();
        usuario oUsuario = new usuario();

        public FrmNavUsuario()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            FrmCadUsuario usuarioForm = new FrmCadUsuario();
            usuarioForm.oUsuario = pUsuario.Create();
            usuarioForm.oEndereco = pEndereco.Create();
            if (usuarioForm.ShowDialog() == DialogResult.OK)
            {
                pEndereco.Insert(usuarioForm.oEndereco);
                usuarioForm.oUsuario.idendereco = usuarioForm.oEndereco.idendereco;
                pUsuario.Insert(usuarioForm.oUsuario);
                loading();
            }
        }

        private void UsuarioMainScreen_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading() {

            dg.DataSource = pUsuario.GetUsuario();
            if (pUsuario.ReturnAll().Count() == 0)
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
            usuarioForm.oUsuario = pUsuario.load(this.oUsuario.idusuario);
            usuarioForm.oEndereco = pEndereco.Load(this.oUsuario.idendereco);
            if (usuarioForm.ShowDialog() == DialogResult.OK) {
                pEndereco.Update(usuarioForm.oEndereco);
                pUsuario.Update(usuarioForm.oUsuario);
                loading();
            }
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AxUsuario axUsuario = (AxUsuario)dg.SelectedRows[0].DataBoundItem;
                this.oUsuario = pUsuario.load(axUsuario.idusuario);
            }
            catch (Exception ex) {

            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja apagar esse dado?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pUsuario.Delete(this.oUsuario);
                loading();
            }
        }
    }
}
