using ErpSigmaVenda.auxiliar;
using ErpSigmaVenda.conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.query
{
    class pVenda
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
            var lstFornecedor = dc.ExecuteQuery<fornecedor>(query).ToList().OrderBy(o => o.idfornecedor).ToList();
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
                               where f.idfornecedor == pobjFornecedor.idfornecedor
                               select f).SingleOrDefault();
            tFornecedor.DeleteOnSubmit(oFornecedor);
            dc.SubmitChanges();
        }

        public static List<fornecedor> ReturnAll()
        {
            UpdateDc();
            var lstFornecedor = (from f in tFornecedor
                                 orderby f.idfornecedor
                                 descending
                                 select f).ToList<fornecedor>();
            return lstFornecedor;
        }

        public static IEnumerable<AxVenda> GetVenda()
        {
            venda_produtoEntities db = new venda_produtoEntities();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select idvenda, usr.nomeCompleto as vendedor, cli.nomeCompleto as cliente, precoTotal, data from venda " +
            "inner join usuario usr on venda.idusuario = usr.idusuario inner join cliente cli on venda.idcliente = cli.idcliente;");
            return db.Database.SqlQuery<AxVenda>(query.ToString()).ToList();
        }
    }
}
