using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    class pVenda
    {
        public static IEnumerable<AxVenda> GetVenda()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select idvenda, usr.nomeCompleto as vendedor, cli.nomeCompleto as cliente, venda.precoTotal, venda.data from venda inner join usuario usr on venda.idusuario = usr.idusuario inner join cliente cli on venda.idcliente = cli.idcliente;");
            return db.Database.SqlQuery<AxVenda>(query.ToString()).ToList();
        }
    }
}
