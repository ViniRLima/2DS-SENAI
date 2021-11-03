using System;
using System.Collections.Generic;

#nullable disable

namespace senai_wishlist_webAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Wishlists = new HashSet<Wishlist>();
        }

        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
