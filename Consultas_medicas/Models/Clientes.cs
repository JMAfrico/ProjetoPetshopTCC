﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultas_medicas.Models
{
    public class Clientes
    {
        public int CodCliente { get; set; }

        public string nomeCliente { get; set; }

        public string cpfCliente { get; set; }

        public string emailCliente { get; set; }

        public Int64 telefoneCelularCli { get; set; }

        public Int64 telefoneFixoCli { get; set; }

        public string enderecoCliente { get; set; }

        public string cidadeCliente { get; set; }

        public string estadoCliente { get; set; }

        public int numeroResidenciaCliente { get; set; }

        public string bairroCliente { get; set; }

        public string cepCliente { get; set; }

        public string ComplementoCliente { get; set; }

        public string referencia_cliente { get; set; }
    }
}
