using roman_mobileAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roman_mobileAPI.Interfaces
{
    interface IProjetoRepository
    {

        
       /// <summary>
      /// Lista todas os Projetos
      /// </summary>
      /// <returns>Uma lista de Projetos</returns>
      List<ProjetoDomain> Listar();

      /// <summary>
      /// Busca um Projeto através do seu id
      /// </summary>
      /// <param name="idProjeto">ID do Projeto que será buscado</param>
      /// <returns>Uma Projeto encontrado</returns>
      ProjetoDomain BuscarPorId(int idProjeto);

      /// <summary>
      /// Cadastra uma novo Projeto 
      /// </summary>
      /// <param name="novoProjeto">Objeto novoProjeto com os dados que serão cadastrados</param>
      void Cadastrar(ProjetoDomain novoProjeto);

      /// <summary>
      /// Atualiza uma classe existente
      /// </summary>
      /// <param name="idProjeto">ID do Projeto que será atualizado</param>
      /// <param name="ProjetoAtualizado">Objeto ProjetoAtualizado com as novas informações</param>
      void Atualizar(short idProjeto, ProjetoDomain ProjetoAtualizado);

      /// <summary>
      /// Deleta uma classe existente
      /// </summary>
      /// <param name="idProjeto">ID do Projeto que será deletado</param>
      void Deletar(int idProjeto);


       


    }
}
