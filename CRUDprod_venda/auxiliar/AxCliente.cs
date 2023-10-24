using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.auxiliar
{
    public class AxCliente
    {
        public int idcliente { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public DateTime dataNascimento { get; set; }
        public string endereco { get; set; }
    }
}
