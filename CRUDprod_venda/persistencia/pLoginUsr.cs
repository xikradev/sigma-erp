using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    public static class pLoginUsr
    {
        public static usuario oUsuario { get; set; }

        public static usuario GetUser(string email, string senha)
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select * from usuario where email ='"+email+"' and senha ='"+senha+"';");
            oUsuario = db.Database.SqlQuery<usuario>(query.ToString()).FirstOrDefault();
            return oUsuario;
        }
    }
}
