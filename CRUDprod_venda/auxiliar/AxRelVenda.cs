using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.auxiliar
{
    public class AxRelVenda
    {
        public int idvenda { get; set; }
        public string clientName { get; set; }
        public string clientEmail { get; set; }
        public string clientAddress { get; set; }
        public string register { get; set; }
        public string uf {  get; set; } 
        public string city { get; set; }
        public string sellerName {  get; set; }
        public DateTime dateOfSale { get; set; }
        public string paymentMethod { get; set; }
        public int totalProductsQty {  get; set; }
        public decimal totalSaleValue {  get; set; }
        public List<AxItemProd> items = new List<AxItemProd>();
       
    }
}
