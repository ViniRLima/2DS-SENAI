using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface IEstudioRepository
    {
        /// <summary>
        /// Listar todos os Estudios
        /// </summary>
        /// <returns>Lista de Aluguéis</returns>
        List<EstudioDomain> ListarTodos();

        /// <summary>
        /// Busca um estudio através do seu id
        /// </summary>
        /// <param name="idEstudio">id do estudio que será buscado</param>
        /// <returns>Um estudio buscado</returns>
        EstudioDomain BuscarPorId(int idEstudio);

        /// <summary>
        /// Cadastra um novo Estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio com os novos dados</param>
        void Cadastrar(EstudioDomain novoEstudio);

        /// <summary>
        /// Atualiza um estudio existente
        /// </summary>
        /// <param name="estudioAtualizado">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(EstudioDomain estudioAtualizado);

        /// <summary>
        /// Atualiza um estudio existente
        /// </summary>
        /// <param name="idEstudio">id do estudio que será atualizado</param>
        /// <param name="estudioAtualizado">Objeto estudioAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idEstudio, EstudioDomain estudioAtualizado);

        /// <summary>
        /// Deleta um estudio existente
        /// </summary>
        /// <param name="idEstudio">id do aluguel que será deletado</param>
        void Deletar(int idEstudio);
    }
}
