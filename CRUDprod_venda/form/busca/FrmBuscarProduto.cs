using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
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
    public partial class FrmBuscarProduto : Form
    {
        venda_produtoEntities dbProduto = new venda_produtoEntities();
        public AxProduto oProduto = new AxProduto();

        public FrmBuscarProduto()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void PesquisarProdFrm_Load(object sender, EventArgs e)
        {
            dg.DataSource = pProduto.GetProduto();
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string filter="Id";

            if(FilterCb.SelectedItem == "Id")
            {
                filter = "prod.idproduto";
            }
            else if(FilterCb.SelectedItem == "Nome")
            {
                filter = "prod.nome";
            }

            try
            {
                IEnumerable<AxProduto> productList = SearchProduct(filter, SearchTextBox.Text);
                if (productList.Count() > 0)
                {
                    dg.DataSource = productList;
                }
                else
                {
                    MessageBox.Show($"Nenhum Produto Encontrado com esse filtro, tente novamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar procurar no Banco de Dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            rowsCheck();
        }

        private IEnumerable<AxProduto> SearchProduct(string filter, string textBox)
        {
            string query = "select prod.*, prod_forn.codProduto, forn.idfornecedor, forn.nomeCompleto as fornecedor from produto_fornecedor prod_forn " +
                "inner join produto prod on prod_forn.idproduto = prod.idproduto " +
                "inner join fornecedor forn on prod_forn.idfornecedor = forn.idfornecedor " +
                "where " + filter + " like '" + SearchTextBox.Text + "%'; ";

            return dbProduto.Database.SqlQuery<AxProduto>(query).ToList();
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.oProduto = (AxProduto)dg.SelectedRows[0].DataBoundItem;
            }
            catch(Exception ex)
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            dg.DataSource = pProduto.GetProduto();
            rowsCheck();
        }
    }
}
