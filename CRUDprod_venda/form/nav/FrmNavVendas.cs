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
    public partial class FrmNavVendas : Form
    {
        private venda_produtoEntities db = new venda_produtoEntities();
        venda oVenda = new venda();

        public FrmNavVendas()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            FrmCadVendas vendasForm = new FrmCadVendas();
            
            vendasForm.oCliente = new cliente();
            vendasForm.oVenda = new venda();
            if(vendasForm.ShowDialog() == DialogResult.OK)
            {

                db = new venda_produtoEntities();
                db.venda.Add(vendasForm.oVenda);
                db.SaveChanges();
                loading();
            }

        }

        private void VendaMainScreen_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            dg.DataSource = pVenda.GetVenda();
            if(db.venda.ToList().Count() == 0)
            {
                //UpdateButton.Enabled = false;
                //DeleteButton.Enabled = false;
            }
            else
            {
                //UpdateButton.Enabled = true;
                //DeleteButton.Enabled = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrmCadVendas vendasForm = new FrmCadVendas();
            //vendasForm.oProduto = this.db.produto.Find(this.oVenda.idproduto);
            vendasForm.oCliente = this.db.cliente.Find(this.oVenda.idcliente);
            vendasForm.oVenda = this.db.venda.Find(this.oVenda.idvenda);
            if (vendasForm.ShowDialog() == DialogResult.OK) {
                db.SaveChanges();
                loading();
            }
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AxVenda axVenda = (AxVenda) dg.SelectedRows[0].DataBoundItem;
                this.oVenda = db.venda.Find(axVenda.idvenda);
            }
            catch (Exception)
            {

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja apagar esse dado?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.venda.Remove(db.venda.Find(this.oVenda.idvenda));
                db.SaveChanges();
                loading();
            }
        }
    }
}
