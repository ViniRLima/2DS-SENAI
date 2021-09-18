using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Referência o bando de dados tabelas e atributos 
    /// </summary>
    public class UsuarioDomain
    {
        public int idUsuario { get; set; }
        public string nomeUsuario { get; set; }

        [Required(ErrorMessage = "Informe o email ")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha ")]
        public string senha { get; set; }

        public TipoUsuarioDomain idTipoUsuario { get; set; }

    }
}
