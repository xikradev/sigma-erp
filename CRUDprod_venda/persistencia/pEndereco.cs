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
    public static class pEndereco
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();
        static Table<endereco> tEndereco = dc.GetTable<endereco>();

        public static void UpdateDC()
        {
            dc = new dataContextErpSigmaDataContext();

            tEndereco = dc.GetTable<endereco>();
        }

        public static endereco Create()
        {
            endereco e = new endereco();
            string query = "select * from endereco";
            var lstEndereco = dc.ExecuteQuery<endereco>(query).ToList().OrderBy(o => o.idendereco).ToList();
            var oEndereco = lstEndereco[(lstEndereco.Count - 1)];
            e.idendereco = (oEndereco.idendereco + 1);

            return e;

        }

        public static void Insert(endereco pobjEndereco)
        {
            tEndereco.InsertOnSubmit(pobjEndereco);
            dc.SubmitChanges();
        }

        public static endereco Load(int id)
        {
            UpdateDC();
            var oEndereco = (from e in tEndereco where e.idendereco == id select e).SingleOrDefault();
            return oEndereco;
        }

        public static endereco LoadWhere(Expression<Func<endereco,bool>> predicate)
        {
            UpdateDC();
            var oEndereco = tEndereco.Where(predicate).SingleOrDefault();
            return oEndereco;
        }


        public static void Update(endereco pobjEndereco)
        {
            var oEndereco = (from e in tEndereco
                             where e.idendereco == pobjEndereco.idendereco
                             select e).SingleOrDefault();
            oEndereco.idendereco = pobjEndereco.idendereco;
            oEndereco.rua = pobjEndereco.rua;
            oEndereco.complemento = pobjEndereco.complemento;
            oEndereco.cep = pobjEndereco.cep;
            oEndereco.numero = pobjEndereco.numero;
            oEndereco.cidade = pobjEndereco.cidade;

            dc.SubmitChanges();
        }


        public static void Delete(endereco pobjEndereco)
        {
            var oEndereco = (from e in tEndereco
                             where e.idendereco == pobjEndereco.idendereco
                             select e).SingleOrDefault();
            tEndereco.DeleteOnSubmit(oEndereco);
            dc.SubmitChanges();
        }

        public static List<endereco> ReturnAll()
        {
            UpdateDC();
            var lstEndereco = (from e in tEndereco
                               orderby e.idendereco 
                               descending select e).ToList<endereco>();
            return lstEndereco;
        }

    }
}
