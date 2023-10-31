using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    class pFornecedor
    {
        public static IEnumerable<AxFornecedor> GetFornecedor()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select fornecedor.*, endereco.complemento, endereco.cep, from fornecedor inner join endereco on fornecedor.idendereco = endereco.idendereco ");
            return db.Database.SqlQuery<AxFornecedor>(query.ToString()).ToList();
        }
    }
}
