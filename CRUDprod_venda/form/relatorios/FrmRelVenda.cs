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
            List<AxItemProd> items = relVenda.items;
            rptVenda.Clear();
            rptVenda.Reset();
            rptVenda.LocalReport.ReportEmbeddedResource = "ErpSigmaVenda.form.relatorios.RelVenda.rdlc";
            rptVenda.LocalReport.DataSources.Add(new ReportDataSource("ItensVenda", items));
            ReportParameter[] parametros =
            {
                new ReportParameter("paramIdVenda", relVenda.idvenda.ToString()),
                new ReportParameter("paramClientName", relVenda.clientName.ToUpper()),
                new ReportParameter("paramClientEmail", relVenda.clientEmail.ToUpper()),
                new ReportParameter("paramAddress", relVenda.clientAddress.ToUpper()),
                new ReportParameter("paramUF", relVenda.uf.ToUpper()),
                new ReportParameter("paramCity", relVenda.city.ToUpper()),
                new ReportParameter("paramRegister", relVenda.register),
                new ReportParameter("paramSeller", relVenda.sellerName.ToUpper()),
                new ReportParameter("paramDateOfSale", relVenda.dateOfSale.ToShortDateString().ToString()),
                new ReportParameter("paramTotalProductsQty", relVenda.totalProductsQty.ToString()),
                new ReportParameter("paramTotalSaleValue", $"R$ {relVenda.totalSaleValue.ToString()}"),
                new ReportParameter("paramPaymentMethod", relVenda.paymentMethod.ToUpper()),
                new ReportParameter("paramLocalDate", generateLocalDate(DateTime.Now))
            };
            foreach(ReportParameter param in parametros)
            {
                rptVenda.LocalReport.SetParameters(param);
            }
            this.rptVenda.SetDisplayMode(DisplayMode.PrintLayout);
            this.rptVenda.ZoomMode = ZoomMode.Percent;
            this.rptVenda.ZoomPercent = 1;
            this.rptVenda.RefreshReport();
            
        }

        private string generateLocalDate(DateTime date) {
            string[] meses = new string[]
            {
                "janeiro", "fevereiro", "março", "abril", "maio", "junho",
                "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"
            };

            int dia = date.Day;
            int mes = date.Month;
            int ano = date.Year;

            string dataPorExtenso = $"Luziânia-GO,dia {dia}, de {meses[mes - 1]} de {ano}";

            return dataPorExtenso;
        }
    }
}
