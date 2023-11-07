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
    public partial class FrmRelVenda : Form
    {
        AxRelVenda relVenda = new AxRelVenda();

        public FrmRelVenda(AxRelVenda relVenda)
        {
            InitializeComponent();
            this.relVenda = relVenda;
        }

        private void FrmRelVenda_Load(object sender, EventArgs e)
        {
            List<ItensVenda> items = relVenda.oVenda.ItensVenda.ToList();
            rptVenda.Clear();
            rptVenda.Reset();
            rptVenda.LocalReport.ReportEmbeddedResource = "ErpSigmaVenda.form.relatorios.RelVenda.rdlc";
            rptVenda.LocalReport.DataSources.Add(new ReportDataSource("ItensVenda", items));
            this.rptVenda.RefreshReport();
            //rptVenda
            //rptVenda.Clear();
            //rptFornecedor.Reset();
            //rptFornecedor.LocalReport.ReportEmbeddedResource = "ErpSigmaVenda.form.relatorios.RelVenda.rdlc";
            //rptFornecedor.LocalReport.DataSources.Add(new ReportDataSource("tableFornecedor", items));

            //this.reportViewer1.RefreshReport();
        }
    }
}
