using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Referência o bando de dados tabelas e atributos 
    /// </summary>
    public class JogoDomain
    {
        public int idJogo { get; set; }
        public string nomeJogo { get; set; }
        public string descricao { get; set; }
        public int valor { get; set; }
        public DateTime dataLancamento { get; set; }
        public EstudioDomain idEstudio  { get; set; }
    }
}
