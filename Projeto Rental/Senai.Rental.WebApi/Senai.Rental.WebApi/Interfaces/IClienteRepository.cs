using Senai.Rental.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ClienteRepository
    /// </summary>
    interface IClienteRepository
    {
        /// <summary>
        /// Listar todos os Clientes
        /// </summary>
        /// <returns> Lista de Clientes </returns>
        List<ClienteDomain> ListarTodos();

        /// <summary>
        /// Busca um cliente através do seu id
        /// </summary>
        /// <param name="idCliente">id do cliente que será buscado</param>
        /// <returns>Um cliente buscado</returns>
        ClienteDomain BuscarPorId(int idCliente);

        /// <summary>
        /// Cadastra um novo cliente
        /// </summary>
        /// <param name="novoCliente">Objeto novoCliente com os novos dados</param>
        void Cadastrar(ClienteDomain novoCliente);

        /// <summary>
        /// Atualiza um cliente existente
        /// </summary>
        /// <param name="clienteAtualizado">Objeto com as novos atualizados</param>
        void AtualizarIdCorpo(ClienteDomain clienteAtualizado);

        /// <summary>
        /// Atualiza um cliente existente
        /// </summary>
        /// <param name="idCliente">id do cliente que será atualizado</param>
        /// <param name="clienteAtualizado">Objeto clienteAtulizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idCliente, ClienteDomain clienteAtualizado);

        /// <summary>
        /// Deleta um cliente existente
        /// </summary>
        /// <param name="idCLiente">id do cliente que será deletado</param>
        void Deletar(int idCLiente);
    }

}
