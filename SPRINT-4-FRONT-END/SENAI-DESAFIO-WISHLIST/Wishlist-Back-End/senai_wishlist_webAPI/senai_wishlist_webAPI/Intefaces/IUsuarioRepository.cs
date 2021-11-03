using senai_wishlist_webAPI.Domains;
using System.Collections.Generic;

namespace senai_wishlist_webAPI.Intefaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();

        Usuario BuscarPorID(int idUsuario);

        void Cadastrar(Usuario novoUsuario);

        void AtualizarURL(int idUsuario, Usuario usuarioAtualizado);

        void Remover(int idUsuario);
    }
}
