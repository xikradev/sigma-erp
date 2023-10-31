using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.auxiliar
{
    public class AxItemProd
    {
        public int idproduto { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public decimal precoUnit { get; set; }
        public decimal precoTotal { get; set; }

    }
}
