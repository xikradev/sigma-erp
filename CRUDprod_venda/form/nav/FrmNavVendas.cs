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
        public venda oVenda = new venda();

        public FrmNavVendas()
        {
            InitializeComponent();
        }

       

        private void VendaMainScreen_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            dg.DataSource = pVenda.GetVenda().ToList();
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

        

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                object oIndex = dg.Rows[e.RowIndex].Cells[0].Value;
                if (oIndex != null)
                {
                    string idvenda = oIndex.ToString();

                    this.oVenda = db.venda.Find(int.Parse(idvenda));
                    this.DialogResult = DialogResult.OK;
                }

            }
        }
    }
}
