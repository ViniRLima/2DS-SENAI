using System;
using System.Collections.Generic;

#nullable disable

namespace roman_mobileAPI.Domains
{
    public partial class ProjetoDomain
    {
        public int IdProjeto { get; set; }
        public short IdProfessor { get; set; }
        public short? IdTema { get; set; }
        public string NomeProjeto { get; set; }

        public virtual ProfessorDomain IdProfessorNavigation { get; set; }
        public virtual Tema IdTemaNavigation { get; set; }
        public object IdUsuarioNavigation { get; internal set; }
    }
}
