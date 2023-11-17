using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.auxiliar
{
    public class AxProduto
    {
        public int idproduto { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string descricao { get; set; }
        public decimal estoque_qnt { get; set; }
        public string fornecedor { get; set; }
        public int idfornecedor { get; set; }
        public int codProduto { get; set; }
    }
}
