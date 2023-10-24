using ErpSigmaVenda.conexão;
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
        public produto oProduto = new produto();

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
            dg.DataSource = dbProduto.produto.ToList();
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
            string filter="id";

            if(FilterCb.SelectedItem == "Id")
            {
                filter = "idproduto";
            }
            else if(FilterCb.SelectedItem == "Nome")
            {
                filter = "nome";
            }

            try
            {
                dg.DataSource = dbProduto.Database.SqlQuery<produto>("select * from produto where "+filter+" like '" + SearchTextBox.Text + "%';").ToList();
                
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
                this.oProduto = (produto)dg.SelectedRows[0].DataBoundItem;
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
    }
}
