﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSigmaVenda.auxiliar
{
    public class AxCliente
    {
        public int idcliente { get; set; }
        public string nomeCompleto { get; set; }
        public string email { get; set; }
        public string registro { get; set; }
        public string sexo { get; set; }
        public string seguimento { get; set; }
        public DateTime dataNascimento { get; set; }
        public string endereco { get; set; }
    }
}
