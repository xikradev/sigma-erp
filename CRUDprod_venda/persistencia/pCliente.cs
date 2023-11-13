using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    public static class pCliente
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();

        static Table<cliente> tCliente = dc.GetTable<cliente>();

        public static void UpdateDc()
        {
            dc = new dataContextErpSigmaDataContext();

            tCliente = dc.GetTable<cliente>();
        }

        public static cliente Create()
        {
            UpdateDc();
            cliente c = new cliente();
            string query = "select * from cliente";
            var lstCliente = dc.ExecuteQuery<cliente>(query).ToList().OrderBy(o => o.idcliente).ToList();
            var oCliente = lstCliente[(lstCliente.Count - 1)];
            c.idcliente = (oCliente.idcliente + 1);

            return c;
        }

        public static void Insert(cliente pobjCliente)
        {
            tCliente.InsertOnSubmit(pobjCliente);
            dc.SubmitChanges();
        }

        public static cliente load(int id)
        {
            UpdateDc();
            var oCliente = (from c in tCliente where c.idcliente == id select c).SingleOrDefault();
            return oCliente;
        }

        public static cliente LoadWhere(Expression<Func<cliente, bool>> predicate)
        {
            UpdateDc();
            var oCliente = tCliente.Where(predicate).SingleOrDefault();
            return oCliente;
        }

        public static void Update(cliente pobjCliente)
        {
            var oCliente = (from c in tCliente
                               where c.idcliente == pobjCliente.idcliente
                            select c).SingleOrDefault();

            oCliente.idcliente = pobjCliente.idcliente;
            oCliente.nomeCompleto = pobjCliente.nomeCompleto;
            oCliente.email = pobjCliente.email;
            oCliente.registro = pobjCliente.registro;
            oCliente.dataNascimento = pobjCliente.dataNascimento;
            oCliente.idendereco = pobjCliente.idendereco;
            oCliente.sexo = pobjCliente.sexo;
            oCliente.seguimento = pobjCliente.seguimento;

            dc.SubmitChanges();

        }

        public static void Delete(cliente pobjCliente)
        {
            var oCliente = (from c in tCliente
                               where c.idcliente == pobjCliente.idcliente
                            select c).SingleOrDefault();
            tCliente.DeleteOnSubmit(oCliente);
            dc.SubmitChanges();
        }

        public static List<cliente> ReturnAll()
        {
            UpdateDc();
            var lstCliente = (from c in tCliente
                                 orderby c.idcliente
                                 descending
                                 select c).ToList<cliente>();
            return lstCliente;
        }

        public static IEnumerable<AxCliente> GetCliente()
        {
            UpdateDc();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select cliente.*, endereco.complemento as endereco from cliente inner join endereco on cliente.idendereco = endereco.idendereco ");
            return dc.ExecuteQuery<AxCliente>(query.ToString()).ToList();
        }
    }
}
