

using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ErpSigmaVenda.query
{
    public static class pFornecedor
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();

        static Table<fornecedor> tFornecedor = dc.GetTable<fornecedor>();

        public static void UpdateDc()
        {
            dc = new dataContextErpSigmaDataContext();

            tFornecedor = dc.GetTable<fornecedor>();
        }

        public static fornecedor Create()
        {
            UpdateDc();
            fornecedor f = new fornecedor();
            string query = "select * from fornecedor";
            var lstFornecedor  = dc.ExecuteQuery<fornecedor>(query).ToList().OrderBy(o => o.idfornecedor).ToList();
            var oFornecedor = lstFornecedor[(lstFornecedor.Count - 1)];
            f.idfornecedor = (oFornecedor.idfornecedor + 1);

            return f;            
        }

        public static void Insert(fornecedor pobjFornecedor)
        {
            tFornecedor.InsertOnSubmit(pobjFornecedor);
            dc.SubmitChanges();
        }

        public static fornecedor load(int id)
        {
            UpdateDc();
            var oFornecedor = (from f in tFornecedor where f.idfornecedor == id select f).SingleOrDefault();
            return oFornecedor;
        }

        public static fornecedor LoadWhere(Expression<Func<fornecedor, bool>> predicate)
        {
            UpdateDc();
            var oFornecedor = tFornecedor.Where(predicate).SingleOrDefault();
            return oFornecedor;
        }

        public static void Update(fornecedor pobjFornecedor)
        {
            var oFornecedor = (from f in tFornecedor
                               where f.idfornecedor == pobjFornecedor.idfornecedor
                               select f).SingleOrDefault();

            oFornecedor.idfornecedor = pobjFornecedor.idfornecedor;
            oFornecedor.nomeCompleto = pobjFornecedor.nomeCompleto;
            oFornecedor.registro = pobjFornecedor.registro;
            oFornecedor.email = pobjFornecedor.email;
            oFornecedor.dataNascimento = pobjFornecedor.dataNascimento;
            oFornecedor.sexo = pobjFornecedor.sexo;
            oFornecedor.seguimento = pobjFornecedor.seguimento;

            dc.SubmitChanges();

        }

        public static void Delete(fornecedor pobjFornecedor)
        {
            var oFornecedor = (from f in tFornecedor
                               where f.idfornecedor == pobjFornecedor.idfornecedor select f).SingleOrDefault();
            tFornecedor.DeleteOnSubmit(oFornecedor);
            dc.SubmitChanges();
        }

        public static List<fornecedor> ReturnAll()
        {
            UpdateDc();
            var lstFornecedor = (from f in tFornecedor
                                    orderby f.idfornecedor 
                                    descending select f).ToList<fornecedor>();
            return lstFornecedor;
        }

        public static IEnumerable<AxFornecedor> GetFornecedor()
        {
            UpdateDc();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select fornecedor.*, endereco.complemento, endereco.cep from fornecedor inner join endereco on fornecedor.idendereco = endereco.idendereco ");
            return dc.ExecuteQuery<AxFornecedor>(query.ToString()).ToList();
        }


    }
}
