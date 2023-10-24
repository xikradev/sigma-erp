using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    public static class pCliente
    {
        public static IEnumerable<AxCliente> GetCliente()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select cliente.*, endereco.complemento as endereco from cliente inner join endereco on cliente.idendereco = endereco.idendereco ");
            return db.Database.SqlQuery<AxCliente>(query.ToString()).ToList();
        }
    }
}
