using System;
using System.Collections.Generic;

#nullable disable

namespace roman_mobileAPI.Domains
{
    public partial class Tema
    {
        public Tema()
        {
            Projetos = new HashSet<ProjetoDomain>();
        }

        public short IdTema { get; set; }
        public string NomeTema { get; set; }

        public virtual ICollection<ProjetoDomain> Projetos { get; set; }
    }
}
