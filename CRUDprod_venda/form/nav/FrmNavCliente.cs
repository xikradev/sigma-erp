using ErpSigmaVenda.auxiliar;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda.clientes
{
    public partial class FrmNavCliente : Form
    {
        private dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();
        cliente oCliente = new cliente();

        public FrmNavCliente()
        {
            InitializeComponent();
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
            if(pCliente.ReturnAll().Count() == 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
            }
            else if(pCliente.ReturnAll().Count() > 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }else if(pCliente.ReturnAll().Count() > 0 && oUsuario.role.Equals("Vendedor"))
            {
                InsertButton.Enabled = true;
                UpdateButton.Enabled = true;
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            FrmCadCliente clienteForm = new FrmCadCliente();
            clienteForm.oCliente = pCliente.Create();
            clienteForm.oEndereco = pEndereco.Create();
            if(clienteForm.ShowDialog() == DialogResult.OK)
            {
                pEndereco.Insert(clienteForm.oEndereco);
                clienteForm.oCliente.idendereco = clienteForm.oEndereco.idendereco;
                pCliente.Insert(clienteForm.oCliente);
                loading();
            }
        }

        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja apagar esse dado?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pCliente.Delete(this.oCliente);
                loading();
            }
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            dgPF_selectedItem();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrmCadCliente clienteForm = new FrmCadCliente();
            clienteForm.oCliente = pCliente.load(this.oCliente.idcliente);
            clienteForm.oEndereco = pEndereco.Load(clienteForm.oCliente.idendereco);
            if(clienteForm.ShowDialog() == DialogResult.OK)
            {
                pCliente.Update(clienteForm.oCliente);
                pEndereco.Update(clienteForm.oEndereco);
                this.loading();
            }
        }

        private void dgPJ_SelectionChanged(object sender, EventArgs e)
        {
            dgPJ_selectedItem();
        }

        private void dgPF_selectedItem()
        {
            try
            {
                AxCliente axCliente = (AxCliente)dgPF.SelectedRows[0].DataBoundItem;
                this.oCliente = pCliente.load(axCliente.idcliente);

            }
            catch (Exception ex)
            {

            }
        }

        private void dgPJ_selectedItem()
        {
            try
            {
                AxCliente axCliente = (AxCliente)dgPJ.SelectedRows[0].DataBoundItem;
                this.oCliente = pCliente.load(axCliente.idcliente);

            }
            catch (Exception ex)
            {

            }
        }

        private void ClienteTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ClienteTabControl.SelectedIndex == 0)
            {
                dgPF_selectedItem();
            }else if(ClienteTabControl.SelectedIndex == 1)
            {
                dgPJ_selectedItem();
            }
        }
    }
}
