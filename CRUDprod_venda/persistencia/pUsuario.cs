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
    public class pUsuario
    {
        static dataContextErpSigmaDataContext dc = new dataContextErpSigmaDataContext();

        static Table<usuario> tUsuario = dc.GetTable<usuario>();

        public static void UpdateDc()
        {
            dc = new dataContextErpSigmaDataContext();

            tUsuario = dc.GetTable<usuario>();
        }

        public static usuario Create()
        {
            UpdateDc();
            usuario u = new usuario();
            string query = "select * from usuario";
            var lstUsuario = dc.ExecuteQuery<usuario>(query).ToList().OrderBy(o => o.idusuario).ToList();
            var oUsuario = lstUsuario[(lstUsuario.Count - 1)];
            u.idusuario = (oUsuario.idusuario+ 1);

            return u;
        }

        public static void Insert(usuario pobjUsuario)
        {
            tUsuario.InsertOnSubmit(pobjUsuario);
            dc.SubmitChanges();
        }

        public static usuario load(int id)
        {
            UpdateDc();
            var oUsuario = (from u in tUsuario where u.idusuario == id select u).SingleOrDefault();
            return oUsuario;
        }

        public static usuario LoadWhere(Expression<Func<usuario, bool>> predicate)
        {
            UpdateDc();
            var oUsuario = tUsuario.Where(predicate).SingleOrDefault();
            return oUsuario;
        }

        public static void Update(usuario pobjUsuario)
        {
            var oUsuario = (from u in tUsuario
                            where u.idusuario == pobjUsuario.idusuario
                            select u).SingleOrDefault();

            oUsuario.idusuario = pobjUsuario.idusuario;
            oUsuario.nomeCompleto = pobjUsuario.nomeCompleto;
            oUsuario.email = pobjUsuario.email;
            oUsuario.cpf = pobjUsuario.cpf;
            oUsuario.dataNascimento = pobjUsuario.dataNascimento;
            oUsuario.idendereco = pobjUsuario.idendereco;
            oUsuario.sexo = pobjUsuario.sexo;
            oUsuario.senha = pobjUsuario.senha;
            oUsuario.role = pobjUsuario.role;

            dc.SubmitChanges();

        }

        public static void Delete(usuario pobjUsuario)
        {
            var oUsuario = (from u in tUsuario
                            where u.idusuario == pobjUsuario.idusuario
                            select u).SingleOrDefault();
            tUsuario.DeleteOnSubmit(oUsuario);
            dc.SubmitChanges();
        }

        public static List<usuario> ReturnAll()
        {
            UpdateDc();
            var lstUsuario = (from u in tUsuario
                              orderby u.idusuario
                              descending
                              select u).ToList<usuario>();
            return lstUsuario;
        }

        public static IEnumerable<AxUsuario> GetUsuario()
        {
            UpdateDc();
            StringBuilder query = new StringBuilder();
            query.AppendLine("select usuario.*, endereco.rua, endereco.cep, endereco.estado from usuario inner join endereco on usuario.idendereco = endereco.idendereco ");
            return dc.ExecuteQuery<AxUsuario>(query.ToString()).ToList();
        }

    }
}
