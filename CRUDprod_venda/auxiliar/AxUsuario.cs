using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.auxiliar
{
    public class AxUsuario
    {
        public int idusuario { get; set; }
        public string nomeCompleto { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public DateTime dataNascimento { get; set; }
        public string rua { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string role { get; set; }
    }
}
