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
    public class pItensVenda
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();

        static Table<ItensVenda> tItensVenda = dc.GetTable<ItensVenda>();

        public static void UpdateDc()
        {
            dc = new dataContextErpSigmaDataContext();

            tItens = dc.GetTable<ItensVenda>();
        }

        public static ItensVenda Create()
        {
            UpdateDc();
            ItensVenda iv = new ItensVenda();
            string query = "select * from ItensVenda";
            var lstItensVenda = dc.ExecuteQuery<ItensVenda>(query).ToList().OrderBy(o => o.iditem).ToList();
            var oItensVenda = lstItensVenda[(lstItensVenda.Count - 1)];
            iv.iditem = (oItensVenda.iditem + 1);

            return iv;
        }

        public static void Insert(ItensVenda pobjItensVenda)
        {
            tItensVenda.InsertOnSubmit(pobjItensVenda);
            dc.SubmitChanges();
        }

        public static ItensVenda load(int id)
        {
            UpdateDc();
            var oItensVenda = (from iv in tItensVenda where iv.iditem == id select v).SingleOrDefault();
            return oItensVenda;
        }

        public static ItensVenda LoadWhere(Expression<Func<ItensVenda, bool>> predicate)
        {
            UpdateDc();
            var oItensVenda = tItensVenda.Where(predicate).SingleOrDefault();
            return oItensVenda;
        }

        public static void Update(ItensVenda pobjItensVenda)
        {
            var oItensVenda = (from iv in tItensVenda
                               where iv.iditem == pobjItensVenda.iditem
                               select iv).SingleOrDefault();

            oItensVenda.iditem = pobjItensVenda.iditem;
            oItensVenda.idvenda = pobjItensVenda.idvenda;
            oItensVenda.idproduto = pobjItensVenda.idproduto;
            oItensVenda.quantidade = pobjItensVenda.quantidade;
            oItensVenda.precoUnit = pobjItensVenda.precoUnit;
            oItensVenda.precoTotal = pobjItensVenda.precoTotal;

            dc.SubmitChanges();

        }

        public static void Delete(ItensVenda pobjItensVenda)
        {
            var oItensVenda = (from iv in tItensVenda
                               where iv.iditem == pobjItensVenda.iditem
                               select iv).SingleOrDefault();
            tItensVenda.DeleteOnSubmit(oItensVenda);
            dc.SubmitChanges();
        }

        public static List<ItensVenda> ReturnAll()
        {
            UpdateDc();
            var lstItensVenda = (from iv in tItensVenda
                                 orderby iv.iditem
                                 descending
                                 select iv).ToList<ItensVenda>();
            return lstItensVenda;
        }

        public static AxItemProd GetItem(int id)
        {
            UpdateDc();
            StringBuilder query = new StringBuilder();
            query.AppendLine($"select idproduto, nome, preco as precoUnit, estoque_qnt from produto where idproduto = {id};");
            return dc.ExecuteQuery<AxItemProd>(query.ToString()).FirstOrDefault();
        }
    }
}
