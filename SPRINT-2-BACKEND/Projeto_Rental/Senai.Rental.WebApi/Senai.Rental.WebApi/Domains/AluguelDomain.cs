using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Domains
{
    public class AluguelDomain
    {
        public int idAluguel { get; set; }
        public int aluguel { get; set; }
        public DateTime datainicio { get; set; }
        public DateTime datafim { get; set; }
        public ClienteDomain idCliente { get; set; }
        public VeiculoDomain idVeiculo { get; set; }

    }
}
