using roman_mobileAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roman_mobileAPI.Interfaces
{
    interface IProfessorRepository
    {
        
       
         /// <summary>
        /// Lista todas os Professores
        /// </summary>
        /// <returns>Uma lista de Professores</returns>
        List<ProfessorDomain> Listar();

        /// <summary>
        /// Busca um Professor através do seu id
        /// </summary>
        /// <param name="idProfessor">ID do Professor que será buscado</param>
        /// <returns>Uma Professor encontrado</returns>
        ProfessorDomain BuscarPorId(int idProfessor);

        /// <summary>
        /// Cadastra uma novo Professor 
        /// </summary>
        /// <param name="novoProfessor">Objeto novoProfessor com os dados que serão cadastrados</param>
        void Cadastrar(ProfessorDomain novoProfessor);

        /// <summary>
        /// Atualiza uma classe existente
        /// </summary>
        /// <param name="idProfessor">ID do professor que será atualizado</param>
        /// <param name="professorAtualizado">Objeto professorAtualizado com as novas informações</param>
        void Atualizar(short idProfessor, ProfessorDomain professorAtualizado);

        /// <summary>
        /// Deleta uma classe existente
        /// </summary>
        /// <param name="idProfessor">ID do professor que será deletado</param>
        void Deletar(int idProfessor);

         
         
         
         
    }
}
