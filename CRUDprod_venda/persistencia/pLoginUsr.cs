using ErpSigmaVenda.linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    public static class pLoginUsr
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();

        public static usuario oUsuario { get; set; }

        public static usuario GetUser(string email, string senha)
        {
            dc = new dataContextErpSigmaDataContext();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select * from usuario where email ='"+email+"' and senha ='"+senha+"';");
            oUsuario = dc.ExecuteQuery<usuario>(query.ToString()).FirstOrDefault();
            return oUsuario;
        }
    }
}
