using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Domains
{
    public class ClienteDomain
    {
        public int idCliente { get; set; }
        public string nomeCLiente { get; set; }
        public string sobrenomeCliente { get; set; }
        public decimal cnh { get; set; }
    }
}
