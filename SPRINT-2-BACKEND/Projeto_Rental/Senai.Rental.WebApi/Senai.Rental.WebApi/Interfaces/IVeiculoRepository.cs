using Senai.Rental.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Interfaces
{

    /// <summary>
    /// Interface responsável pelo repositório VeiculoRepository
    /// </summary>
    interface IVeiculoRepository
    {
        /// <summary>
        /// Listar todos os Veiculos
        /// </summary>
        /// <returns>Lista de Veiculos</returns>
        List<VeiculoDomain> ListarTodos();

        /// <summary>
        /// Busca um veiculo através do seu id
        /// </summary>
        /// <param name="idVeiculo">id do veiculo que será buscado</param>
        /// <returns>Um veiculo buscado</returns>
        VeiculoDomain BuscarPorId(int idVeiculo);

        /// <summary>
        /// Cadastra um novo Veiculo
        /// </summary>
        /// <param name="novoVeiculo">Objeto novoVeiculo com os novos dados</param>
        void Cadastrar(VeiculoDomain novoVeiculo);

        /// <summary>
        /// Atualiza um veiculo existente
        /// </summary>
        /// <param name="veiculoAtualizado">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(VeiculoDomain veiculoAtualizado);

        /// <summary>
        /// Atualiza um veiculo existente
        /// </summary>
        /// <param name="idVeiculo">id do veiculo que será atualizado</param>
        /// <param name="veiculoAtualizado">Objeto veiculoAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idVeiculo, VeiculoDomain veiculoAtualizado);

        /// <summary>
        /// Deleta um veiculo existente
        /// </summary>
        /// <param name="idVeiculo">id do veiculo que será deletado</param>
        void Deletar(int idVeiculo);
    }
}
