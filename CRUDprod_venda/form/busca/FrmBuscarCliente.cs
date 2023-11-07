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
            tabCheck();
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
            string filter = "idcliente";
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
                
                if(PersonsTypeTabControl.SelectedIndex == 0)
                {
                    List<AxCliente> pfList = dbCliente.Database.SqlQuery<AxCliente>("select cliente.*, endereco.complemento as endereco from cliente inner join endereco on cliente.idendereco = endereco.idendereco " +
                    "where " + filter + " like '" + SearchTextBox.Text + "%' " +
                    "and sexo IS NOT NULL;").ToList();
                    if (pfList.Count() > 0)
                    {
                        dgPF.DataSource = pfList;
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum Cliente Pessoa Física encontrado com esse filtro, tente novamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               

                if(PersonsTypeTabControl.SelectedIndex == 1)
                {
                    List<AxCliente> pJList = dbCliente.Database.SqlQuery<AxCliente>("select cliente.*, endereco.complemento as endereco from cliente inner join endereco on cliente.idendereco = endereco.idendereco " +
                    "where " + filter + " like '" + SearchTextBox.Text + "%' " +
                    "and seguimento IS NOT NULL;").ToList();
                    if(pJList.Count() > 0)
                    {
                        dgPJ.DataSource = pJList;
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum Cliente Pessoa Jurídica encontrado com esse filtro, tente novamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
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

        private void FilterClearBtn_Click(object sender, EventArgs e)
        {
            tabCheck();
        }

        private void PersonsTypeTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabCheck();
        }

        private void tabCheck()
        {
            if (PersonsTypeTabControl.SelectedIndex == 0)
            {
                dgPF.DataSource = pCliente.GetCliente().Where(o => o.sexo != null).ToList();
            }
            else if (PersonsTypeTabControl.SelectedIndex == 1)
            {
                dgPJ.DataSource = pCliente.GetCliente().Where(o => o.seguimento != null).ToList();
            }
        }
    }
}
