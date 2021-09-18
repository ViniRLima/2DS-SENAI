using Senai.Rental.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório MarcaRepository
    /// </summary>
    interface IMarcaRepository
    {
        /// <summary>
        /// Listar todas as Marcas
        /// </summary>
        /// <returns>Lista de Marcas</returns>
        List<MarcaDomain> ListarTodos();

        /// <summary>
        /// Busca uma marca através do seu id
        /// </summary>
        /// <param name="idMarca">id da marca que será buscada</param>
        /// <returns>Uma marca buscada</returns>
        MarcaDomain BuscarPorId(int idMarca);

        /// <summary>
        /// Cadastra uma nova Marca
        /// </summary>
        /// <param name="novaMarca">Objeto novaMarca com os novos dados</param>
        void Cadastrar(MarcaDomain novaMarca);

        /// <summary>
        /// Atualiza uma marca existente
        /// </summary>
        /// <param name="marcaAtualizada">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(MarcaDomain marcaAtualizada);

        /// <summary>
        /// Atualiza uma marca existente
        /// </summary>
        /// <param name="idMarca">id da marca que será atualizada</param>
        /// <param name="marcaAtualizada">Objeto marcaAtualizada com os novos dados atualizados</param>
        void AtualizarIdUrl(int idMarca, MarcaDomain marcaAtualizada);

        /// <summary>
        /// Deleta uma marca existente
        /// </summary>
        /// <param name="idMarca">id da marca que será deletada</param>
        void Deletar(int idMarca);
    }
}
