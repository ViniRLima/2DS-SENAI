using System;
using System.Collections.Generic;

#nullable disable

namespace roman_mobileAPI.Domains
{
    public partial class ProfessorDomain
    {
        public ProfessorDomain()
        {
            Projetos = new HashSet<ProjetoDomain>();
        }

        public short IdProfessor { get; set; }
        public int? IdUsuario { get; set; }
        public string NomeProfessor { get; set; }
        public string SobrenomeProfessor { get; set; }

        public virtual UsuarioDomain IdUsuarioNavigation { get; set; }
        public virtual ICollection<ProjetoDomain> Projetos { get; set; }
    }
}
