using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using roman_mobileAPI.Domains;
using roman_mobileAPI.Interfaces;
using roman_mobileAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/// <summary>
/// Controller responsavel pelos endpoints referentes aos Projetos.
/// </summary>
namespace roman_mobileAPI.Controllers
{

    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato domino/api/nomeController.
    // ex: http://localhost:5000/api/projetos
    [Route("api/[controller]")]

    //Define que é um controlador de API.
    [ApiController]
    public class ProjetosController : ControllerBase
    {




        /// <summary>
        /// Objeto _projetoRepository que irá receber todos os metodos definidor na interface IProjetoRepository
        /// </summary>
        private IProjetoRepository _projetoRepository { get; set; }

        /// <summary>
        /// Instancia um objeto _projetoRepository para que haja a referencia aos metodos no repositorio.
        /// </summary>
        public ProjetosController()
        {
            _projetoRepository = new ProjetoRepository();
        }

       /// <summary>
       /// Lista todos os Projetos
       /// </summary>
       /// <returns>uma lista de Projeto com status code 200 - Ok</returns>
       [HttpGet]
       public IActionResult Listar()
       {
           return Ok(_projetoRepository.Listar());
       }

       /// <summary>
       /// Busca um Projeto através do seu id
       /// </summary>
       /// <param name="idProjeto">id do Projeto que será buscado</param>
       /// <returns>um Projeto com status code 200 - Ok</returns>
       [HttpGet("{idProjeto}")]
       public IActionResult BuscarPorId(int idProjeto)
       {
           return Ok(_projetoRepository.BuscarPorId(idProjeto));
       }

       /// <summary>
       /// Cadastra um novo Projeto
       /// </summary>
       /// <param name="novoProjeto">Objeto com os dados que serão cadastrados</param>
       /// <returns>um status code 201 - Created</returns>
       [HttpPost]
       public IActionResult Cadastrar(ProjetoDomain novoProjeto)
       {
           _projetoRepository.Cadastrar(novoProjeto);

           return StatusCode(201);
       }

       /// <summary>
       /// Deleta um Projeto através do seu id
       /// </summary>
       /// <param name="idProjeto">id do Projeto que será deletado</param>
       /// <returns>um status code 204 - No Content</returns>
       [HttpDelete("{idProjeto}")]
       public IActionResult Deletar(int idProjeto)
       {
           _projetoRepository.Deletar(idProjeto);

           return StatusCode(204);
       }

   }



        


    }
}
