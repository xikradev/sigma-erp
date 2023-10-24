using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    public class pProduto
    {
        public static IEnumerable<AxProduto> GetProduto()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select prod.*, prod_forn.codProduto, forn.idfornecedor, forn.nome as fornecedor from produto_fornecedor prod_forn " +
                "inner join produto prod on prod_forn.idproduto = prod.idproduto " +
                "inner join fornecedor forn on prod_forn.idfornecedor = forn.idfornecedor;");
            return db.Database.SqlQuery<AxProduto>(query.ToString()).ToList();
        }
    }
}
