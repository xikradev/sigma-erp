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

namespace ErpSigmaVenda.Produtos
{
    public partial class FrmNavProduto : Form
    {
        
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
            this.dg.DataSource = pProduto_fornecedor.GetProduto();
            if(pProduto_fornecedor.ReturnAll().Count == 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
            }
            else if(pProduto_fornecedor.ReturnAll().Count > 0 && oUsuario.role.Equals("ADM"))
            {
                InsertButton.Enabled = true;
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            FrmCadProduto produtoForm = new FrmCadProduto();
            produtoForm.oProduto = pProduto.Create();
            produtoForm.oFornecedor = pFornecedor.Create();
            if(produtoForm.ShowDialog() == DialogResult.OK)
            {
                pProduto.Insert(produtoForm.oProduto);
                produto_fornecedor prod_forn = pProduto_fornecedor.Create();
                prod_forn.idproduto = produtoForm.oProduto.idproduto;
                prod_forn.idfornecedor = produtoForm.oFornecedor.idfornecedor;
                pProduto_fornecedor.Insert(prod_forn);

                //dbProduto.produto.Add(produtoForm.oProduto);
                //dbProduto.SaveChanges();
                //dbProduto = new venda_produtoEntities();

                //produto_fornecedor prod_forn = new produto_fornecedor();
                //prod_forn.idfornecedor = produtoForm.oFornecedor.idfornecedor;
                //prod_forn.idproduto = produtoForm.oProduto.idproduto;
                //dbProduto.produto_fornecedor.Add(prod_forn);
                //dbProduto.SaveChanges();

                loading();
            }

        }

        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCadProduto produtoForm = new FrmCadProduto();
            produtoForm.oProduto = pProduto.load(this.oProduto.idproduto);
            produtoForm.oFornecedor = pFornecedor.load(this.oFornecedor.idfornecedor);
            if (produtoForm.ShowDialog() == DialogResult.OK)
            {
                pProduto.Update(produtoForm.oProduto);
                this.prod_forn.idfornecedor = produtoForm.oFornecedor.idfornecedor;
                this.prod_forn.idproduto = produtoForm.oProduto.idproduto;
                pProduto_fornecedor.Update(this.prod_forn);
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
                this.oProduto = pProduto.load(axProduto.idproduto);
                this.oFornecedor = pFornecedor.load(axProduto.idfornecedor);
                this.prod_forn = pProduto_fornecedor.Load(axProduto.codProduto);
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
                pProduto.Delete(this.oProduto);
                pProduto_fornecedor.Delete(this.prod_forn);
                loading();
            }
        }
    }
}
