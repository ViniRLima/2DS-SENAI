using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Listar todos os Usuario
        /// </summary>
        /// <returns>Lista de Usuario</returns>
        List<UsuarioDomain> ListarTodos();

        /// <summary>
        /// Busca um usuario através do seu id
        /// </summary>
        /// <param name="idUsuario">id do usuario que será buscado</param>
        /// <returns>Um usuario buscado</returns>
        UsuarioDomain BuscarPorId(int idUsuario);

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario com os novos dados</param>
        void Cadastrar(UsuarioDomain novoUsuario);

        /// <summary>
        /// Atualiza um usuario existente
        /// </summary>
        /// <param name="usuarioAtualizado">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(UsuarioDomain usuarioAtualizado);

        /// <summary>
        /// Atualiza um usuario existente
        /// </summary>
        /// <param name="idUsuario">id do usuario que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto usuarioAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idUsuario, UsuarioDomain usuarioAtualizado);

        /// <summary>
        /// Deleta um usuario existente
        /// </summary>
        /// <param name="idUsuario">id do usuario que será deletado</param>
        void Deletar(int idUsuario);

        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}
