using System;
using System.Collections.Generic;

#nullable disable

namespace roman_mobileAPI.Domains
{
    public partial class UsuarioDomain
    {
        public UsuarioDomain()
        {
            Professors = new HashSet<ProfessorDomain>();
        }

        public int IdUsuario { get; set; }
        public byte? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuarioDomain IdTipoUsuarioNavigation { get; set; }
        public virtual ImagemUsuario ImagemUsuario { get; set; }
        public virtual ICollection<ProfessorDomain> Professors { get; set; }
    }
}
