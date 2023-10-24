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

namespace ErpSigmaVenda.Produtos
{
    public partial class FrmBuscarFornecedor : Form
    {
        venda_produtoEntities dbFornecedor = new venda_produtoEntities();
        public fornecedor oFornecedor = new fornecedor();

        public FrmBuscarFornecedor()
        {
            InitializeComponent();
        }

        private void PesquisarFornFrm_Load(object sender, EventArgs e)
        {
            dg.DataSource = pFornecedor.GetFornecedor();
            FilterCb.SelectedIndex = 0;
            rowsCheck();
        }

        private void rowsCheck()
        {
            if (dg.RowCount <= 0)
            {
                this.OkBtn.Enabled = false;
            }
            else
            {
                this.OkBtn.Enabled = true;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string filter = "id";
            if(FilterCb.SelectedItem == "Id")
            {
                filter = "idfornecedor";
            }else if(FilterCb.SelectedItem == "Nome")
            {
                filter = "nome";
            }else if(FilterCb.SelectedItem == "CNPJ")
            {
                filter = "cnpj";
            }

            try
            {
                dg.DataSource = dbFornecedor.Database.SqlQuery<AxFornecedor>("select fornecedor.*, endereco.bairro as endereco from fornecedor inner join endereco on fornecedor.idendereco = endereco.idendereco where " + filter + " like '" + SearchTextBox.Text + "%';").ToList();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Tentar procurar no Banco de Dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rowsCheck();
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AxFornecedor axFornecedor = (AxFornecedor)dg.SelectedRows[0].DataBoundItem;
                this.oFornecedor = dbFornecedor.fornecedor.Find(axFornecedor.idfornecedor);

            }
            catch (Exception ex)
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
    }
}
