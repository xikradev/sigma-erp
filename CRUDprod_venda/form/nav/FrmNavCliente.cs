using ErpSigmaVenda.conexão;
using ErpSigmaVenda.auxiliar;
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

namespace ErpSigmaVenda.clientes
{
    public partial class FrmNavCliente : Form
    {
        private venda_produtoEntities db = new venda_produtoEntities();
        cliente oCliente = new cliente();

        public FrmNavCliente()
        {
            InitializeComponent();
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClienteMainScreen_Load(object sender, EventArgs e)
        {
            loading();
            
        }

        private void loading()
        {
            var oUsuario = pLoginUsr.oUsuario;
            dgPF.DataSource = pCliente.GetCliente().Where(o => o.seguimento == null).ToList();
            dgPJ.DataSource = pCliente.GetCliente().Where(o => o.sexo == null).ToList();
            if(db.cliente.ToList().Count() == 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
            }
            else if(db.cliente.ToList().Count() > 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }else if(db.cliente.ToList().Count() > 0 && oUsuario.role.Equals("Vendedor"))
            {
                InsertButton.Enabled = true;
                UpdateButton.Enabled = true;
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            FrmCadCliente clienteForm = new FrmCadCliente();
            clienteForm.oCliente = new cliente();
            clienteForm.oEndereco = new endereco();
            if(clienteForm.ShowDialog() == DialogResult.OK)
            {
                db = new venda_produtoEntities();
                db.endereco.Add(clienteForm.oEndereco);
                db.SaveChanges();
                db = new venda_produtoEntities();
                clienteForm.oCliente.idendereco = clienteForm.oEndereco.idendereco;
                db.cliente.Add(clienteForm.oCliente);
                db.SaveChanges();
                loading();
            }
        }

        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja apagar esse dado?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.cliente.Remove(db.cliente.Find(this.oCliente.idcliente));
                db.SaveChanges();
                loading();
            }
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AxCliente axCliente = (AxCliente)dgPF.SelectedRows[0].DataBoundItem;
                this.oCliente = db.cliente.Find(axCliente.idcliente);

            }catch(Exception ex)
            {

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrmCadCliente clienteForm = new FrmCadCliente();
            clienteForm.oCliente = db.cliente.Find(this.oCliente.idcliente);
            clienteForm.oEndereco = db.endereco.Find(clienteForm.oCliente.idendereco);
            if(clienteForm.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                this.loading();
            }
        }

        private void dgPJ_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AxCliente axCliente = (AxCliente)dgPJ.SelectedRows[0].DataBoundItem;
                this.oCliente = db.cliente.Find(axCliente.idcliente);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
