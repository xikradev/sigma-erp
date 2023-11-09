using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using ErpSigmaVenda.form.relatorios;
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

namespace ErpSigmaVenda.vendas
{
    public partial class FrmNavVendas : Form
    {
        public cliente oCliente { get; set; }
        public usuario oUsuario = pLoginUsr.oUsuario;
        private int itemIndex;
        public venda oVenda { get; set; }
        private BindingList<AxItemProd> items = new BindingList<AxItemProd>();
        private venda_produtoEntities db = new venda_produtoEntities();

        private const string VENDA_ABERTA = "Venda Aberta";
        private const string VENDA_FECHADA = "Venda Fechada";



        public FrmNavVendas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendasForm_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void loading()
        {
            MetPagCB.SelectedIndex = 0;
            var oUsuario = pLoginUsr.oUsuario;
            VendedorTextBox.Text = $"{oUsuario.idusuario}- {oUsuario.nomeCompleto}";
            dgItem.DataSource = items;
            StatusTextBox.Text = VENDA_ABERTA;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm = new FrmBuscarCliente();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.oCliente = frm.oCliente;
                ClienteTb.Text = $"{this.oCliente.idcliente}- {this.oCliente.nomeCompleto}";
            }
        }

        private void updatingVenda()
        {
            this.oVenda.idcliente = this.oCliente.idcliente;
            this.oVenda.idusuario = pLoginUsr.oUsuario.idusuario;
            this.oVenda.precoTotal = decimal.Parse(PrecoTotalTb.Text);
            this.oVenda.data = DateTime.Now;
            this.oVenda.metodo_pagamento = MetPagCB.SelectedItem.ToString();
        }

        private void updatingItems(ItensVenda itemToBeSaved, AxItemProd itemContent)
        {
            itemToBeSaved.idvenda = this.oVenda.idvenda;
            itemToBeSaved.idproduto = itemContent.idproduto;
            itemToBeSaved.quantidade = itemContent.quantidade;
            itemToBeSaved.precoUnit = itemContent.precoUnit;
            itemToBeSaved.precoTotal = itemContent.precoTotal;
        }
        

        private Boolean registrandoVenda()
        {
            this.oVenda = new venda();
            updatingVenda();
            db = new venda_produtoEntities();
            db.venda.Add(this.oVenda);
            db.SaveChanges();
            foreach (var item in this.items)
            {
                ItensVenda oItemProd = new ItensVenda();
                updatingItems(oItemProd, item);
                db = new venda_produtoEntities();
                db.ItensVenda.Add(oItemProd);
                db.SaveChanges();
                db = new venda_produtoEntities();
                produto oProduto = db.produto.Find(oItemProd.idproduto);
                oProduto.estoque_qnt -= oItemProd.quantidade;
                db.SaveChanges();
                
            }

            return true;
        }

        private Boolean verify()
        {
            
            if (String.IsNullOrEmpty(ClienteTb.Text))
            {
                MessageBox.Show("Selecione um Cliente para registrar uma Venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(dgItem.Rows.Count == 0)
            {
                MessageBox.Show("Você precisa Adicionar ao menos um produto para registrar a venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach(var item in this.items)
            {
                if ((item.estoque_qnt - item.quantidade) <= 10)
                {
                    MessageBox.Show($"não pode vender {item.quantidade} quantidade do produto {item.nome}, tem que deixar pelo menos 10 quantidades no estoque, reponha o estoque ou diminua a quantidade na venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                registrandoVenda();
                StatusTextBox.Text = VENDA_FECHADA;
                CodVendaTextBox.Text = this.oVenda.idvenda.ToString();
                FinalizarVendaBtn.Enabled = false;
                AtualizarVendaBtn.Enabled = true;
                ReportBtn.Enabled = true;
                MessageBox.Show("Venda Registrada com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            FrmBuscarProduto frm = new FrmBuscarProduto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AxItemProd newItem = pItemProd.GetItem(frm.oProduto.idproduto);
                newItem.quantidade = 1;
                if(!items.Any(o => o.idproduto == newItem.idproduto))
                {
                    newItem.quantidade = 1;
                    newItem.precoTotal = newItem.quantidade * newItem.precoUnit;
                    this.items.Add(newItem);
                    dgItem.Refresh();
                    loadFields();
                }
                else
                {
                    MessageBox.Show("Esse item já foi adicionado na Venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RemoveProdBtn_Click(object sender, EventArgs e)
        {
            if(this.items.Count > 0 && dgItem.SelectedRows.Count > 0)
            {
                this.items.RemoveAt(this.itemIndex);
                loadFields();
            }

        }

        

        private void dgItem_SelectionChanged_1(object sender, EventArgs e)
        {
            

            try
            {
                if (dgItem.Rows.Count > 0)
                {
                    
                    this.itemIndex = dgItem.SelectedRows[0].Index;

                }
                else
                {
                    QuantTb.Text = "";
                    PrecoTotalTb.Text = "";
                }
            }
            catch(Exception ex)
            {

            }
        }

        

        private void QuantTb_Leave(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBuscarVenda frm = new FrmBuscarVenda();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.oVenda = db.venda.Find(frm.oVenda.idvenda);
                CodVendaTextBox.Text = this.oVenda.idvenda.ToString();
                MetPagCB.SelectedItem = this.oVenda.metodo_pagamento;
                this.oCliente = db.cliente.Find(this.oVenda.idcliente);
                this.oUsuario = db.usuario.Find(this.oVenda.idusuario);
                VendedorTextBox.Text = $"{oUsuario.idusuario}- {oUsuario.nomeCompleto}";
                this.items = searchItems(this.oVenda.idvenda);
                StatusTextBox.Text = VENDA_FECHADA;
                dgItem.DataSource = this.items;
                ReportBtn.Enabled = true;
                ClienteTb.Text = $"{this.oCliente.idcliente}- {this.oCliente.nomeCompleto}";
                loadFields();
            }  
        }

        private BindingList<AxItemProd> searchItems(int id)
        {
            return new BindingList<AxItemProd>(db.Database.SqlQuery<AxItemProd>($"select ItensVenda.iditem,ItensVenda.idproduto, ItensVenda.quantidade, produto.nome, produto.preco as precoUnit, produto.estoque_qnt, ItensVenda.precoTotal from ItensVenda " +
            $"inner join produto on ItensVenda.idproduto = produto.idproduto where ItensVenda.idvenda = {id}; ").ToList());
        }

        private void dgItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string quantity = dgItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (int.TryParse(quantity, out int num))
                {
                    if(num > 0)
                    {
                        this.items[itemIndex].precoTotal = num * this.items[itemIndex].precoUnit;
                        dgItem.Refresh();
                    }
                    else if(num == 0)
                    {
                        this.items[itemIndex].quantidade = 1;
                        num = 1;
                        this.items[itemIndex].precoTotal = num * this.items[itemIndex].precoUnit;
                        dgItem.Refresh();
                    }
                    else
                    {
                        this.items[itemIndex].quantidade = num * -1;
                        num =num * -1;
                        this.items[itemIndex].precoTotal = num * this.items[itemIndex].precoUnit;
                        dgItem.Refresh();
                    }
                }

                loadFields();
            }
        }

        private void loadFields()
        {
            PrecoTotalTb.Text = "0";

            foreach (var item in this.items)
            {
                PrecoTotalTb.Text = (decimal.Parse(PrecoTotalTb.Text) + item.precoTotal).ToString();
            }
            QuantTb.Text = "0";
            foreach (var item in this.items)
            {
                QuantTb.Text = (decimal.Parse(QuantTb.Text) + item.quantidade).ToString();
            }
            dgItem.Refresh();
        }

        private void DescontoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(DescontoTextBox.Text))
            {
                
                if (decimal.TryParse(DescontoTextBox.Text, out decimal result))
                {
                    decimal priceToBeDescount = 0;
                    foreach (var item in this.items)
                    {
                        priceToBeDescount += item.precoTotal;
                    }

                    PrecoTotalTb.Text = (priceToBeDescount - result).ToString();
                }
            }
            else
            {
                loadFields();
            }
        }

        private void EncerrarBtn_Click(object sender, EventArgs e)
        {
            clearFields();

        }

        private void clearFields()
        {
            this.oVenda = null;
            this.items.Clear();
            this.oCliente = null;
            this.oUsuario = pLoginUsr.oUsuario;
            DescontoTextBox.Text = "";
            ClienteTb.Text = "";
            VendedorTextBox.Text = $"{oUsuario.idusuario}- {oUsuario.nomeCompleto}";
            StatusTextBox.Text = VENDA_ABERTA;
            ReportBtn.Enabled = false;
            MetPagCB.SelectedIndex = 0;
            CodVendaTextBox.Text = "";
        }

        private void dgItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowsVerification();
        }

        private void dgItem_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowsVerification();
        }

        private void RowsVerification()
        {
            if(this.items.Count > 0)
            {
                FinalizarVendaBtn.Enabled = true;
                if (StatusTextBox.Text.Equals(VENDA_FECHADA))
                {
                    AtualizarVendaBtn.Enabled = true;
                    FinalizarVendaBtn.Enabled = false;
                }
            }
            else
            {
                FinalizarVendaBtn.Enabled = false;
                AtualizarVendaBtn.Enabled = false;
            }
        }

        private void AtualizarVendaBtn_Click(object sender, EventArgs e)
        {
            db = new venda_produtoEntities();
            if(verify() == true)
            {
                this.oVenda = db.venda.Find(this.oVenda.idvenda);
                updatingVenda();
                db.SaveChanges();
                List<ItensVenda> itensSaveds = db.ItensVenda.Where(o => o.idvenda == this.oVenda.idvenda).ToList();
                //remover items
                foreach (var item in itensSaveds)
                {
                    db = new venda_produtoEntities();
                    var itemFounded = this.items.FirstOrDefault(o => o.iditem == item.iditem);
                    if (itemFounded == null)
                    {
                        db.ItensVenda.Remove(db.ItensVenda.Find(item.iditem));
                        db.SaveChanges();
                    }
                }
                //atualizar e adiconar itens
                foreach (var item in this.items)
                {
                    db = new venda_produtoEntities();
                    var itemFounded = itensSaveds.FirstOrDefault(o => o.iditem == item.iditem);
                    if (itemFounded != null)
                    {
                        updatingItems(itemFounded, item);
                        db.SaveChanges();
                    }
                    else
                    {
                        ItensVenda newItem = new ItensVenda();
                        updatingItems(newItem, item);
                        db.ItensVenda.Add(newItem);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Venda Atualizada com sucesso!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(this.oVenda != null)
            {
                if(MessageBox.Show("Você tem certeza que deseja Cancelar essa venda? ela será apagada permanentemente","",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var itemsToBeDeleted = db.ItensVenda.Where(o => o.idvenda == this.oVenda.idvenda).ToList();
                    foreach (var item in itemsToBeDeleted)
                    {
                        db.ItensVenda.Remove(item);
                    }
                    db.venda.Remove(this.oVenda);
                    db.SaveChanges();
                    clearFields();
                    MessageBox.Show("Venda Cancelada com Sucesso!!","", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma venda para que ela possa ser apagada","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (!IsNumeric(e.FormattedValue.ToString(), out double result))
                {
                    MessageBox.Show("Por Favor digite apenas Números", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                int stockQnt = int.Parse(dgItem.Rows[e.RowIndex].Cells[5].Value.ToString());
                if ((stockQnt - result) <= 10)
                {
                    MessageBox.Show("não pode vender esta quantidade desse produto, tem que deixar pelo menos 10 quantidades no estoque, reponha o estoque ou diminua a quantidade na venda", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    e.Cancel = true;
                }

            }
        }

        private bool IsNumeric(string text, out double result)
        {
            return double.TryParse(text, out result);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(this.oVenda != null)
            {
                AxRelVenda report = reportGenerator();
                FrmRelVenda frm = new FrmRelVenda(report);
                frm.ShowDialog();
            }
        }

        private AxRelVenda reportGenerator()
        {
            AxRelVenda axRelVenda = new AxRelVenda();

            axRelVenda.idvenda = oVenda.idvenda;
            axRelVenda.clientName = oCliente.nomeCompleto;
            axRelVenda.clientEmail = oCliente.email;
            axRelVenda.clientAddress = oCliente.endereco.rua + " " + oCliente.endereco.complemento;
            axRelVenda.register = oCliente.registro;
            axRelVenda.uf = oCliente.endereco.estado;
            axRelVenda.city = oCliente.endereco.cidade;
            axRelVenda.sellerName = oUsuario.nomeCompleto;
            axRelVenda.dateOfSale = oVenda.data;
            axRelVenda.paymentMethod = oVenda.metodo_pagamento;
            axRelVenda.totalProductsQty = int.Parse(QuantTb.Text);
            axRelVenda.totalSaleValue = oVenda.precoTotal;
            axRelVenda.items = this.items.ToList();

            return axRelVenda;
        }
    }
}
