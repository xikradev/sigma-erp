using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    public class pUsuario
    {
        public static IEnumerable<AxUsuario> GetUsuario()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select usuario.*, endereco.bairro as endereco from usuario inner join endereco on usuario.idendereco = endereco.idendereco ");
            return db.Database.SqlQuery<AxUsuario>(query.ToString()).ToList();
        }

    }
}
