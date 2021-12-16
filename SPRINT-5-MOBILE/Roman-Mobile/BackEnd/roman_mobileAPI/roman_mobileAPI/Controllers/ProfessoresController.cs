using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using roman_mobileAPI.Domains;
using roman_mobileAPI.Interfaces;
using roman_mobileAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roman_mobileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {


       /// <summary>
       /// Objeto _professorRepository que irá receber todos os metodos definidor na interface IProfessorRepository
       /// </summary>
       private IProfessorRepository _professorRepository { get; set; }

       /// <summary>
       /// Instancia um objeto _professorRepository para que haja a referencia aos metodos no repositorio.
       /// </summary>
       public ProfessoresController()
       {
           _professorRepository = new ProfessorRepository();
       }

       /// <summary>
       /// Lista todos os Professores
       /// </summary>
       /// <returns>uma lista de Professores com status code 200 - Ok</returns>
       [HttpGet]
       public IActionResult Listar()
       {
           return Ok(_professorRepository.Listar());
       }

       /// <summary>
       /// Busca um professor através do seu id
       /// </summary>
       /// <param name="idProfessor">id do Professor que será buscado</param>
       /// <returns>um professor com status code 200 - Ok</returns>
       [HttpGet("{idProfessor}")]
       public IActionResult BuscarPorId(int idProfessor)
       {
           return Ok(_professorRepository.BuscarPorId(idProfessor));
       }

       /// <summary>
       /// Cadastra um novo professor
       /// </summary>
       /// <param name="novoProfessor">Objeto com os dados que serão cadastrados</param>
       /// <returns>um status code 201 - Created</returns>
       [HttpPost]
       public IActionResult Cadastrar(ProfessorDomain novoProfessor)
       {
           _professorRepository.Cadastrar(novoProfessor);

           return StatusCode(201);
       }

       /// <summary>
       /// Deleta um Professor através do seu id
       /// </summary>
       /// <param name="idProfessor">id do Professor que será deletado</param>
       /// <returns>um status code 204 - No Content</returns>
       [HttpDelete("{idProfessor}")]
       public IActionResult Deletar(int idProfessor)
       {
           _professorRepository.Deletar(idProfessor);

           return StatusCode(204);
       }

   }



        


    }
}
