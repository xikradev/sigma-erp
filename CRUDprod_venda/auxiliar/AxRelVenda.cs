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
        public venda oVenda { get; set; }
        public cliente oCliente { get; set; }
        public usuario oUsuario { get; set; }
    }
}
