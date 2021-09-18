using Senai.Rental.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ModeloRepository
    /// </summary>
    interface IModeloRepository
    {
        /// <summary>
        /// Listar todos os Modelos
        /// </summary>
        /// <returns>Lista de Modelos</returns>
        List<ModeloDomain> ListarTodos();

        /// <summary>
        /// Busca um modelo através do seu id
        /// </summary>
        /// <param name="idModelo">id do modelo que será buscado</param>
        /// <returns>Um modelo buscado</returns>
        ModeloDomain BuscarPorId(int idModelo);

        /// <summary>
        /// Cadastra um novo Modelo
        /// </summary>
        /// <param name="novoModelo">Objeto novoModelo com os novos dados</param>
        void Cadastrar(ModeloDomain novoModelo);

        /// <summary>
        /// Atualiza um modelo existente
        /// </summary>
        /// <param name="modeloAtualizado">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(ModeloDomain modeloAtualizado);

        /// <summary>
        /// Atualiza um modelo existente
        /// </summary>
        /// <param name="idModelo">id do modelo que será atualizado</param>
        /// <param name="modeloAtualizado">Objeto modeloAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idModelo, ModeloDomain modeloAtualizado);

        /// <summary>
        /// Deleta um modelo existente
        /// </summary>
        /// <param name="idModelo">id do modelo que será deletado</param>
        void Deletar(int idModelo);
    }
}
