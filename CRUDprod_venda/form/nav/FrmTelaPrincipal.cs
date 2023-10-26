using ErpSigmaVenda.clientes;
using ErpSigmaVenda.form.nav;
using ErpSigmaVenda.fornecedores;
using ErpSigmaVenda.Produtos;
using ErpSigmaVenda.query;
using ErpSigmaVenda.usuarios;
using ErpSigmaVenda.vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda.navegacao
{
    public partial class FrmTelaPrincipal : Form
    {
        

        public FrmTelaPrincipal()
        {
            InitializeComponent();
            
        }

        private void NavegationForm_Load(object sender, EventArgs e)
        {
            login();
             
        }

        private void login()
        {
            FrmLogin frm = new FrmLogin();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var oUsuario = pLoginUsr.oUsuario;
                if (oUsuario.role.Equals("ADM"))
                {
                    this.btnProduto.Visible = true;
                    this.btnVenda.Visible = true;
                    this.btnFornecedor.Visible = true;
                    this.btnClientes.Visible = true;
                    this.btnUsuarios.Visible = true;
                    this.infoUserLabel.Text = $"Usuário(a) {oUsuario.role} logado(a) em {DateTime.Now.ToShortDateString()} às {DateTime.Now.ToShortTimeString()}";
                }
                else if (oUsuario.role.Equals("Vendedor"))
                {
                    this.btnProduto.Visible = true;
                    this.btnVenda.Visible = true;
                    this.btnClientes.Visible = true;
                    
                    
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmNavProduto produtosMainScreen = new FrmNavProduto();
            produtosMainScreen.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FrmNavVendas vendaMainScreen = new FrmNavVendas();
            vendaMainScreen.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmNavCliente clienteMainScreen = new FrmNavCliente();
            clienteMainScreen.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FrmNavFornecedor fornecedorMS = new FrmNavFornecedor();
            fornecedorMS.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmNavUsuario frm = new FrmNavUsuario();
            frm.ShowDialog();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SwitchUserBtn_Click(object sender, EventArgs e)
        {
            FrmInfoUser frm = new FrmInfoUser();
            frm.ShowDialog();
                
            
        }
    }
}
