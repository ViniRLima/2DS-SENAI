using roman_mobileAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roman_mobileAPI.Interfaces
{
    interface IUsuarioRepository
    {
        
        
        /// <summary>
        /// Lista todos os Usuarios
        /// </summary>
        /// <returns>Uma lista de Usuarios</returns>
        List<UsuarioDomain> Listar();

        /// <summary>
        /// Busca um Usuario através do seu id
        /// </summary>
        /// <param name="IdTipoUsuario">ID do Usuario que será buscado</param>
        /// <returns>Um Usuario encontrado</returns>
        UsuarioDomain BuscarPorId(int IdTipoUsuario);

        /// <summary>
        /// Cadastra um Usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario com os dados que serão cadastrados</param>
        void Cadastrar(UsuarioDomain novoUsuario);

        /// <summary>
        /// Atualiza um Usuario existente
        /// </summary>
        /// <param name="IdUsuario">ID do Usuario que será atualizada</param>
        /// <param name="usuarioAtualizado">Objeto usuarioAtualizado com as novas informações</param>
        void Atualizar(int IdUsuario, UsuarioDomain usuarioAtualizado);

        /// <summary>
        /// Deleta um Usuario existente
        /// </summary>
        /// <param name="IdUsuario">ID Usuario que será deletada</param>
        void Deletar(int IdUsuario);



        /// <summary>
        /// Busca o Email e senha para a verificação no banco de dados
        /// </summary>
        /// <param name="email">parâmentro email para buscar</param>
        /// <param name="senha">parâmentro senha para buscar</param>
        /// <returns>Busca email e senha retornando status code</returns>
        UsuarioDomain BuscarPorEmailSenha(string email, string senha);

        



    }
}
