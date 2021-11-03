using senai_wishlist_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webAPI.Intefaces
{
    interface IWishlistRepository
    {
        List<Wishlist> ListarTodos();

        Wishlist BuscarPorID(int idWishlist);

        void Cadastrar(Wishlist novoDesejo);
    }
}
