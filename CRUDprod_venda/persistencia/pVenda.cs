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
    class pVenda
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();

        static Table<venda> tVenda = dc.GetTable<venda>();

        public static void UpdateDc()
        {
            dc = new dataContextErpSigmaDataContext();

            tVenda = dc.GetTable<venda>();
        }

        public static venda Create()
        {
            UpdateDc();
            venda v = new venda();
            string query = "select * from venda";
            var lstVenda = dc.ExecuteQuery<venda>(query).ToList().OrderBy(o => o.idvenda).ToList();
            var oVenda = lstVenda[(lstVenda.Count - 1)];
            v.idvenda = (oVenda.idvenda + 1);

            return v;
        }

        public static void Insert(venda pobjVenda)
        {
            tVenda.InsertOnSubmit(pobjVenda);
            dc.SubmitChanges();
        }

        public static venda load(int id)
        {
            UpdateDc();
            var oVenda = (from v in tVenda where v.idvenda == id select v).SingleOrDefault();
            return oVenda;
        }

        public static venda LoadWhere(Expression<Func<venda, bool>> predicate)
        {
            UpdateDc();
            var oVenda = tVenda.Where(predicate).SingleOrDefault();
            return oVenda;
        }

        public static void Update(venda pobjVenda)
        {
            var oVenda = (from v in tVenda
                               where v.idvenda == pobjVenda.idvenda
                               select v).SingleOrDefault();

            oVenda.idvenda = pobjVenda.idvenda;
            oVenda.idusuario = pobjVenda.idusuario;
            oVenda.idcliente = pobjVenda.idcliente;
            oVenda.precoTotal = pobjVenda.precoTotal;
            oVenda.data = pobjVenda.data;
            oVenda.metodo_pagamento = pobjVenda.metodo_pagamento;
            
            dc.SubmitChanges();

        }

        public static void Delete(venda pobjVenda)
        {
            var oVenda = (from v in tVenda
                               where v.idvenda == pobjVenda.idvenda
                               select v).SingleOrDefault();
            tVenda.DeleteOnSubmit(oVenda);
            dc.SubmitChanges();
        }

        public static List<venda> ReturnAll()
        {
            UpdateDc();
            var lstVenda = (from v in tVenda
                                 orderby v.idvenda
                                 descending
                                 select v).ToList<venda>();
            return lstVenda;
        }

        public static IEnumerable<AxVenda> GetVenda()
        {
            UpdateDc();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select idvenda, usr.nomeCompleto as vendedor, cli.nomeCompleto as cliente, precoTotal, data from venda " +
            "inner join usuario usr on venda.idusuario = usr.idusuario inner join cliente cli on venda.idcliente = cli.idcliente;");
            return dc.ExecuteQuery<AxVenda>(query.ToString()).ToList();
        }
    }
}
