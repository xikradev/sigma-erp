using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpSigmaVenda.form.relatorios
{
    public partial class FrmRelFornecedores : Form
    {
        

        public FrmRelFornecedores()
        {
            InitializeComponent();
            
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            

            rptFornecedor.Clear();
            rptFornecedor.Reset();
            rptFornecedor.LocalReport.ReportEmbeddedResource = "ErpSigmaVenda.form.relatorios.RelVenda.rdlc";
            //rptFornecedor.LocalReport.DataSources.Add(new ReportDataSource("tableFornecedor", items));
            ReportParameter[] parametros =
            {
                new ReportParameter("paramData", DateTime.Now.ToShortDateString().ToString())
            };
            this.rptFornecedor.RefreshReport();
            //this.rptFornecedor.RefreshReport();
        }
    }
}
