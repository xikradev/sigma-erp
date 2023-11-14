using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.persistencia
{
    public static class pProduto_fornecedor
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();
        static Table<produto_fornecedor> tProd_forn = dc.GetTable<produto_fornecedor>();

        private static void UpdateDc()
        {
            dc = new dataContextErpSigmaDataContext();
            tProd_forn = dc.GetTable<produto_fornecedor>();
        }

        public static produto_fornecedor Create()
        {
            UpdateDc();
            produto_fornecedor p = new produto_fornecedor();
            string query = "select * from produto_fornecedor";
            var lstProd_forn = dc.ExecuteQuery<produto_fornecedor>(query).ToList().OrderBy(o => o.codProduto).ToList();
            var oProd_forn = lstProd_forn[lstProd_forn.Count - 1];
            p.codProduto = (oProd_forn.idproduto + 1);

            return p;
        }

        public static void Insert(produto_fornecedor pobjProd_forn)
        {
            tProd_forn.InsertOnSubmit(pobjProd_forn);
            dc.SubmitChanges();
        }

        public static produto_fornecedor Load(int id)
        {
            UpdateDc();
            var oProd_forn = (from pf in tProd_forn where pf.codProduto == id select pf).SingleOrDefault();
            return oProd_forn;
        }

        public static produto_fornecedor LoadWhere(Expression<Func<produto_fornecedor, bool>> predicate)
        {
            UpdateDc();
            var oProd_forn = tProd_forn.Where(predicate).SingleOrDefault();
            return oProd_forn;
        }

        public static void Update(produto_fornecedor pobjProd_forn)
        {
            var oProd_forn = (from pf in tProd_forn
                            where pf.codProduto == pobjProd_forn.codProduto
                            select pf).SingleOrDefault();

            oProd_forn.idproduto = pobjProd_forn.idproduto;
            oProd_forn.idfornecedor = pobjProd_forn.idfornecedor;
            oProd_forn.codProduto = pobjProd_forn.codProduto;

            dc.SubmitChanges();
        }


        public static void Delete(produto_fornecedor pobjProd_forn)
        {
            var oProd_forn = (from pf in tProd_forn
                            where pf.codProduto == pobjProd_forn.codProduto
                            select pf).SingleOrDefault();
            tProd_forn.DeleteOnSubmit(oProd_forn);
            dc.SubmitChanges();
        }

        public static List<produto_fornecedor> ReturnAll()
        {
            UpdateDc();
            var lstProd_forn = (from pf in tProd_forn
                              orderby pf.codProduto
                              descending
                              select pf).ToList<produto_fornecedor>();
            return lstProd_forn;
        }

        public static IEnumerable<AxProduto> GetProduto()
        {
            UpdateDc();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select prod.*, prod_forn.codProduto, forn.idfornecedor, forn.nomeCompleto as fornecedor from produto_fornecedor prod_forn " +
                "inner join produto prod on prod_forn.idproduto = prod.idproduto " +
                "inner join fornecedor forn on prod_forn.idfornecedor = forn.idfornecedor where prod.estoque_qnt > 10;");
            return dc.ExecuteQuery<AxProduto>(query.ToString()).ToList();
        }
    }
}
