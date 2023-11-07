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
    public partial class FrmBuscarVenda : Form
    {
        private venda_produtoEntities db = new venda_produtoEntities();
        public venda oVenda = new venda();

        public FrmBuscarVenda()
        {
            InitializeComponent();
        }

       

        private void VendaMainScreen_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            usuario oUsuario = pLoginUsr.oUsuario;
            if(pLoginUsr.oUsuario.role == "ADM")
            {
                dg.DataSource = pVenda.GetVenda().ToList();
                FilterComboBox.Items.Add("Vendedor");
            }
            else
            {
                if(FilterComboBox.Items.Count == 4)
                {
                    FilterComboBox.Items.Remove("Vendedor");
                }
                dg.DataSource = db.Database.SqlQuery<AxVenda>("select idvenda, usr.nomeCompleto as vendedor, usr.idusuario, cli.nomeCompleto as cliente, precoTotal, data from venda " +
                $"inner join usuario usr on venda.idusuario = usr.idusuario inner join cliente cli on venda.idcliente = cli.idcliente where usr.idusuario = {pLoginUsr.oUsuario.idusuario};").ToList();
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string filter = "idvenda";
            if(FilterComboBox.SelectedItem == "Código")
            {
                filter = "idvenda";
            }else if(FilterComboBox.SelectedItem == "Data")
            {
                filter = "CONVERT(NVARCHAR, data, 103)";
            }else if (FilterComboBox.SelectedItem == "Cliente")
            {
                filter = "cli.nomeCompleto";
            }else if(FilterComboBox.SelectedItem == "Vendedor")
            {
                filter = "usr.nomeCompleto";
            }

            List<AxVenda> vendaList = db.Database.SqlQuery<AxVenda>("select idvenda, usr.nomeCompleto as vendedor, usr.idusuario, cli.nomeCompleto as cliente, precoTotal, data from venda " +
                $"inner join usuario usr on venda.idusuario = usr.idusuario inner join cliente cli on venda.idcliente = cli.idcliente where {filter} like '{SearchTextBox.Text}%';").ToList();

            if(pLoginUsr.oUsuario.role == "ADM")
            {
                dg.DataSource = vendaList;
            }
            else
            {
                dg.DataSource = vendaList.Where(o => o.idusuario == pLoginUsr.oUsuario.idusuario);
            }
        }
    }
}
