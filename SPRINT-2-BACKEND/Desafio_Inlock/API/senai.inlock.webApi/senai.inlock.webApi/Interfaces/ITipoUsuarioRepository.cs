using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Listar todos os Tipo Usuario
        /// </summary>
        /// <returns>Lista de Tipo Usuario</returns>
        List<TipoUsuarioDomain> ListarTodos();

        /// <summary>
        /// Busca um Tipo Usuario através do seu id
        /// </summary>
        /// <param name="idTipoUsuario">id do Tipo Usuario que será buscado</param>
        /// <returns>Um tipo usuario buscado</returns>
        TipoUsuarioDomain BuscarPorId(int idTipoUsuario);

        /// <summary>
        /// Cadastra um novo Tipo Usuario
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novoTipoUsuario com os novos dados</param>
        void Cadastrar(TipoUsuarioDomain novoTipoUsuario);

        /// <summary>
        /// Atualiza um tipo usuario existente
        /// </summary>
        /// <param name="tipousuarioAtualizado">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(TipoUsuarioDomain tipousuarioAtualizado);

        /// <summary>
        /// Atualiza um tipo usuario existente
        /// </summary>
        /// <param name="idTipoUsuario">id do jogo que será atualizado</param>
        /// <param name="tipousuarioAtualizado">Objeto jogoAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idTipoUsuario, TipoUsuarioDomain tipousuarioAtualizado);

        /// <summary>
        /// Deleta um tipo usuario existente
        /// </summary>
        /// <param name="idTipoUsuario">id do tipo usuario que será deletado</param>
        void Deletar(int idTipoUsuario);
    }
}
