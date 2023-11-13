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
    public static class pProduto
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();
        static Table<produto> tProduto = dc.GetTable<produto>();

        private static void UpdateDc()
        {
            dc = new dataContextErpSigmaDataContext();
            tProduto = dc.GetTable<produto>();
        }

        public static produto Create()
        {
            UpdateDc();
            produto p = new produto();
            string query = "select * from produto";
            var lstProduto = dc.ExecuteQuery<produto>(query).ToList().OrderBy(o => o.idproduto).ToList();
            var oProduto = lstProduto[lstProduto.Count - 1];
            p.idproduto = (oProduto.idproduto + 1);

            return p;
        }

        public static void Insert(produto pobjProduto)
        {
            tProduto.InsertOnSubmit(pobjProduto);
            dc.SubmitChanges();
        }

        public static produto load(int id)
        {
            UpdateDc();
            var oProduto = (from p in tProduto where p.idproduto == id select p).SingleOrDefault();
            return oProduto;
        }

        public static produto LoadWhere(Expression<Func<produto, bool>> predicate)
        {
            UpdateDc();
            var oProduto = tProduto.Where(predicate).SingleOrDefault();
            return oProduto;
        }

        public static void Update(produto pobjProduto)
        {
            var oProduto = (from p in tProduto
                               where p.idproduto == pobjProduto.idproduto
                               select p).SingleOrDefault();

            oProduto.idproduto = pobjProduto.idproduto;
            oProduto.nome = pobjProduto.nome;
            oProduto.preco = pobjProduto.preco;
            oProduto.descricao = pobjProduto.descricao;
            oProduto.estoque_qnt = pobjProduto.estoque_qnt;

            dc.SubmitChanges();
        }


        public static void Delete(produto pobjProduto)
        {
            var oProduto = (from p in tProduto
                               where p.idproduto == pobjProduto.idproduto
                               select p).SingleOrDefault();
            tProduto.DeleteOnSubmit(oProduto);
            dc.SubmitChanges();
        }

        public static List<produto> ReturnAll()
        {
            UpdateDc();
            var lstProduto = (from p in tProduto
                              orderby p.idproduto
                              descending
                              select p).ToList<produto>();
            return lstProduto;
        }

        
    }
}
