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

namespace ErpSigmaVenda.Produtos
{
    public partial class FrmNavProduto : Form
    {
        venda_produtoEntities dbProduto = new venda_produtoEntities();
        produto oProduto = new produto();
        produto_fornecedor prod_forn = new produto_fornecedor();
        fornecedor oFornecedor = new fornecedor();

        public FrmNavProduto()
        {
            InitializeComponent();

        }

        private void ProdutosMainScreen_Load(object sender, EventArgs e)
        {
            
            loading();
            
        }

       
        private void loading()
        {
            var oUsuario = pLoginUsr.oUsuario;
            this.dg.DataSource = pProduto.GetProduto();
            if(dbProduto.produto_fornecedor.ToList().Count == 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
            }
            else if(dbProduto.produto_fornecedor.ToList().Count > 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            FrmCadProduto produtoForm = new FrmCadProduto();
            produtoForm.oProduto = new produto();
            produtoForm.oFornecedor = new fornecedor();
            if(produtoForm.ShowDialog() == DialogResult.OK)
            {
                
                dbProduto.produto.Add(produtoForm.oProduto);
                dbProduto.SaveChanges();
                dbProduto = new venda_produtoEntities();

                produto_fornecedor prod_forn = new produto_fornecedor();
                prod_forn.idfornecedor = produtoForm.oFornecedor.idfornecedor;
                prod_forn.idproduto = produtoForm.oProduto.idproduto;
                dbProduto.produto_fornecedor.Add(prod_forn);
                dbProduto.SaveChanges();

                loading();
            }

        }

        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCadProduto produtoForm = new FrmCadProduto();
            produtoForm.oProduto = dbProduto.produto.Find(this.oProduto.idproduto);
            produtoForm.oFornecedor = dbProduto.fornecedor.Find(this.oFornecedor.idfornecedor);
            if (produtoForm.ShowDialog() == DialogResult.OK)
            {
                this.prod_forn.idfornecedor = produtoForm.oFornecedor.idfornecedor;
                dbProduto.SaveChanges();
                loading();
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AxProduto axProduto = (AxProduto) dg.SelectedRows[0].DataBoundItem;
                this.oProduto = dbProduto.produto.Find(axProduto.idproduto);
                this.oFornecedor = dbProduto.fornecedor.Find(axProduto.idfornecedor);
                this.prod_forn = dbProduto.produto_fornecedor.Find(axProduto.codProduto);
            }
            catch (Exception ex)
            {

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Você tem certeza que deseja apagar esse dado?","",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dbProduto.produto.Remove(dbProduto.produto.Find(this.oProduto.idproduto));
                dbProduto.produto_fornecedor.Remove(dbProduto.produto_fornecedor.Find(this.prod_forn.codProduto));
                dbProduto.SaveChanges();
                loading();
            }
        }
    }
}
