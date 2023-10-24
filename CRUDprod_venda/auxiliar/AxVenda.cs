using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.auxiliar
{
    class AxVenda
    {
        public int idvenda { get; set; }
        public string vendedor { get; set; }
        public string produto { get; set; }
        public string cliente { get; set; }
        public decimal precoTotal { get; set; }
        public int quantidade { get; set; }
        public DateTime data { get; set; }
        
    }
}
