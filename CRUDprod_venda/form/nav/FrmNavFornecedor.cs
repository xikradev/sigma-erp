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
using ErpSigmaVenda.form.relatorios;
using ErpSigmaVenda.persistencia;
using ErpSigmaVenda.linq;

namespace ErpSigmaVenda.fornecedores
{
    public partial class FrmNavFornecedor : Form
    {
        //private venda_produtoEntities db = new venda_produtoEntities();
        fornecedor oFornecedor = new fornecedor();
        public FrmNavFornecedor()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            FrmCadfornecedor fornecedoresForm = new FrmCadfornecedor();
            fornecedoresForm.oFornecedor = pFornecedor.Create();
            fornecedoresForm.oEndereco = pEndereco.Create();
            if(fornecedoresForm.ShowDialog() == DialogResult.OK)
            {
                pEndereco.Insert(fornecedoresForm.oEndereco);
                fornecedoresForm.oFornecedor.idendereco = fornecedoresForm.oEndereco.idendereco;
                pFornecedor.Insert(fornecedoresForm.oFornecedor);

                //db = new venda_produtoEntities();
                //db.endereco.Add(fornecedoresForm.oEndereco);
                //db.SaveChanges();
                //db = new venda_produtoEntities();
                //fornecedoresForm.oFornecedor.idendereco = fornecedoresForm.oEndereco.idendereco;
                //db.fornecedor.Add(fornecedoresForm.oFornecedor);
                //db.SaveChanges();
                loading();
            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FornecedorMainScreen_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            dgPF.DataSource = pFornecedor.GetFornecedor().Where(o => o.seguimento == null).ToList();
            dgPJ.DataSource = pFornecedor.GetFornecedor().Where(o => o.sexo == null).ToList();
            if(pFornecedor.ReturnAll().Count == 0)
            {
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                UpdateButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        private void dg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, EventArgs e)
        {
            dgPF_SelectedItem();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja apagar esse dado?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                pFornecedor.Delete(this.oFornecedor);
                //db.fornecedor.Remove(db.fornecedor.Find(this.oFornecedor.idfornecedor));
                //db.SaveChanges();
                loading();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrmCadfornecedor fornecedoresForm = new FrmCadfornecedor();
            fornecedoresForm.oFornecedor = pFornecedor.load(this.oFornecedor.idfornecedor);
            fornecedoresForm.oEndereco = pEndereco.Load(this.oFornecedor.idendereco);
            if(fornecedoresForm.ShowDialog() == DialogResult.OK)
            {
                pEndereco.Update(fornecedoresForm.oEndereco);
                pFornecedor.Update(fornecedoresForm.oFornecedor);
                loading();
            }
        }

        

        private void dgPJ_SelectionChanged(object sender, EventArgs e)
        {
            dgPJ_SelectedItem();
        }

        private void dgPJ_SelectedItem()
        {
            try
            {
                AxFornecedor axFornecedor = (AxFornecedor)dgPJ.SelectedRows[0].DataBoundItem;
                this.oFornecedor = pFornecedor.load(axFornecedor.idfornecedor);
            }
            catch (Exception ex)
            {

            }
        }

        private void dgPF_SelectedItem()
        {
            try
            {
                AxFornecedor axFornecedor = (AxFornecedor)dgPF.SelectedRows[0].DataBoundItem;
                this.oFornecedor = pFornecedor.load(axFornecedor.idfornecedor);
            }
            catch (Exception ex)
            {

            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypePersonTab.SelectedIndex == 0)
            {
                dgPF_SelectedItem();

            }else if(TypePersonTab.SelectedIndex == 1)
            {
                dgPJ_SelectedItem();
            }
        }
    }
}
