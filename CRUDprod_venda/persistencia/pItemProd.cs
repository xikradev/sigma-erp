using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.persistencia
{
    public class pItemProd
    {
        public static AxItemProd GetItem(int id)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine($"select idproduto, nome, preco as precoUnit from produto where idproduto = {id};");
            return db.Database.SqlQuery<AxItemProd>(query.ToString()).FirstOrDefault();
        }
    }
}
