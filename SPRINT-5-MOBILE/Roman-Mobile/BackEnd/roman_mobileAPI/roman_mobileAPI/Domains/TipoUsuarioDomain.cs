using System;
using System.Collections.Generic;

#nullable disable

namespace roman_mobileAPI.Domains
{
    public partial class TipoUsuarioDomain
    {
        public TipoUsuarioDomain()
        {
            Usuarios = new HashSet<UsuarioDomain>();
        }

        public byte IdTipoUsuario { get; set; }
        public string DescricaoTipoUsuario { get; set; }

        public virtual ICollection<UsuarioDomain> Usuarios { get; set; }
    }
}
