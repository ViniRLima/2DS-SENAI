using Senai.Rental.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório AluguelRepository
    /// </summary>
    interface IAluguelRepository
    {
        /// <summary>
        /// Listar todos os Aluguéis
        /// </summary>
        /// <returns>Lista de Aluguéis</returns>
        List<AluguelDomain> ListarTodos();

        /// <summary>
        /// Busca um aluguel através do seu id
        /// </summary>
        /// <param name="idAluguel">id do aluguel que será buscado</param>
        /// <returns>Um aluguel buscado</returns>
        AluguelDomain BuscarPorId(int idAluguel);

        /// <summary>
        /// Cadastra um novo Aluguel
        /// </summary>
        /// <param name="novoAluguel">Objeto novoAluguel com os novos dados</param>
        void Cadastrar(AluguelDomain novoAluguel);

        /// <summary>
        /// Atualiza um aluguel existente
        /// </summary>
        /// <param name="aluguelAtualizado">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(AluguelDomain aluguelAtualizado);

        /// <summary>
        /// Atualiza um aluguel existente
        /// </summary>
        /// <param name="idAluguel">id do aluguel que será atualizado</param>
        /// <param name="aluguelAtualizado">Objeto aluguelAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idAluguel, AluguelDomain aluguelAtualizado);

        /// <summary>
        /// Deleta um aluguel existente
        /// </summary>
        /// <param name="idAluguel">id do aluguel que será deletado</param>
        void Deletar(int idAluguel);
    }
}
