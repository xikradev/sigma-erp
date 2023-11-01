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

namespace ErpSigmaVenda.vendas
{
    public partial class FrmBuscarCliente : Form
    {
        venda_produtoEntities dbCliente = new venda_produtoEntities();
        public cliente oCliente = new cliente();

        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void PesquisarCliFrm_Load(object sender, EventArgs e)
        {
            dgPF.DataSource = pCliente.GetCliente().Where(o => o.sexo != null).ToList();
            dgPJ.DataSource = pCliente.GetCliente().Where(o => o.seguimento != null).ToList();
            FilterCb.SelectedIndex = 0;
            rowsCheck();
        }

        private void rowsCheck()
        {
            if (dgPF.RowCount <= 0)
            {
                this.OkBtn.Enabled = false;
            }
            else
            {
                this.OkBtn.Enabled = true;
            }
        }

        private void FilterCb_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string filter = "id";
            if(FilterCb.SelectedItem == "Id")
            {
                filter = "idcliente";
            }else if(FilterCb.SelectedItem == "CPF/CNPJ")
            {
                filter = "registro";
            }else if(FilterCb.SelectedItem == "Nome")
            {
                filter = "nomeCompleto";
            }

            try
            {
                dgPF.DataSource = dbCliente.Database.SqlQuery<AxCliente>("select cliente.*, endereco.complemento as endereco from cliente inner join endereco on cliente.idendereco = endereco.idendereco " +
                    "where " + filter + " like '" + SearchTextBox.Text + "%' " +
                    "and sexo IS NOT NULL;").ToList();

                dgPJ.DataSource = dbCliente.Database.SqlQuery<AxCliente>("select cliente.*, endereco.complemento as endereco from cliente inner join endereco on cliente.idendereco = endereco.idendereco " +
                    "where " + filter + " like '" + SearchTextBox.Text + "%' " +
                    "and seguimento IS NOT NULL;").ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar procurar no Banco de Dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rowsCheck();
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgPF.Rows.Count > 0)
                {
                    AxCliente axCliente = (AxCliente)dgPF.SelectedRows[0].DataBoundItem;
                    this.oCliente = dbCliente.cliente.Find(axCliente.idcliente);
                }

            }
            catch(Exception ex)
            {

            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPJ_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgPJ.Rows.Count > 0)
                {
                    AxCliente axCliente = (AxCliente)dgPJ.SelectedRows[0].DataBoundItem;
                    this.oCliente = dbCliente.cliente.Find(axCliente.idcliente);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
