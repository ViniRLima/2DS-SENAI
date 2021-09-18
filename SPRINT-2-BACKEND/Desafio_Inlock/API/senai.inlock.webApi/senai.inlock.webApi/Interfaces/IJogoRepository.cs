using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface IJogoRepository
    {
        /// <summary>
        /// Listar todos os Jogos
        /// </summary>
        /// <returns>Lista de Jogos</returns>
        List<JogoDomain> ListarTodos();

        /// <summary>
        /// Busca um jogo através do seu id
        /// </summary>
        /// <param name="idJogo">id do jogo que será buscado</param>
        /// <returns>Um jogo buscado</returns>
        JogoDomain BuscarPorId(int idJogo);

        /// <summary>
        /// Cadastra um novo Jogo
        /// </summary>
        /// <param name="novoJogo">Objeto novoJogo com os novos dados</param>
        void Cadastrar(JogoDomain novoJogo);

        /// <summary>
        /// Atualiza um jogo existente
        /// </summary>
        /// <param name="jogoAtualizado">Objeto com as novos dados atualizados</param>
        void AtualizarIdCorpo(JogoDomain jogoAtualizado);

        /// <summary>
        /// Atualiza um jogo existente
        /// </summary>
        /// <param name="idJogo">id do jogo que será atualizado</param>
        /// <param name="jogoAtualizado">Objeto jogoAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idJogo, JogoDomain jogoAtualizado);

        /// <summary>
        /// Deleta um jogo existente
        /// </summary>
        /// <param name="idJogos">id do jogos que será deletado</param>
        void Deletar(int idJogos);
    }
}
