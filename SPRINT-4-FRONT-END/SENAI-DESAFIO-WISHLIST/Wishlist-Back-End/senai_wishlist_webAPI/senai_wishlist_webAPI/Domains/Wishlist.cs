using System;
using System.Collections.Generic;

#nullable disable

namespace senai_wishlist_webAPI.Domains
{
    public partial class Wishlist
    {
        public int IdWishlist { get; set; }
        public int? IdUsuario { get; set; }
        public string Desejo { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
