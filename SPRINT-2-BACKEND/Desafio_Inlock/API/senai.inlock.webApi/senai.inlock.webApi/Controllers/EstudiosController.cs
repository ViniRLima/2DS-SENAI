using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Controller responsavel pelos endpoints referentes aos Estudios.
/// </summary>
namespace senai.inlock.webApi.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato domino/api/nomeController.
    // ex: http://localhost:5000/api/estudios
    [Route("api/[controller]")]

    //Define que é um controlador de API.
    [ApiController]
    public class EstudiosController : ControllerBase
    {
        /// <summary>
        /// Objeto _EstudioRepository que irá receber todos os metodos definidor na interface IEstudioRepository
        /// </summary>
        private IEstudioRepository _EstudioRepository { get; set; }

        /// <summary>
        /// Instancia um objeto _EstudioRepository para que haja a referencia aos metodos no repositorio.
        /// </summary>
        public EstudiosController()
        {
            _EstudioRepository = new EstudioRepository();
        }

        /// <summary>
        /// Lista todos os estudios
        /// </summary>
        /// <returns>Uma lista de estudios e um status code.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR, CLIENTE)
        [Authorize(Roles = "ADMINISTRADOR, CLIENTE")]
        [HttpGet]
 
        public IActionResult Get()
        {
 
            List<EstudioDomain> listaEstudio = _EstudioRepository.ListarTodos();


            return Ok(listaEstudio);


        }

        /// <summary>
        /// Busca o id Estudio
        /// </summary>
        /// <returns>O id buscado um status code.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            EstudioDomain estudioBuscado = _EstudioRepository.BuscarPorId(id);

            if (estudioBuscado == null)
            {
                return NotFound("Nenhum cliente encontrado");
            }
            return Ok(estudioBuscado);
        }

        /// <summary>
        /// Cadastra um novo estudio
        /// </summary>
        /// <returns>Um status code de que foi cadastrado o novo estudio.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPost]
        public IActionResult Post(EstudioDomain novoEstudio)
        {


            _EstudioRepository.Cadastrar(novoEstudio);


            return StatusCode(201);


        }

        /// <summary>
        /// Atualiza estudio pelo seu id
        /// </summary>
        /// <returns>Status code que foi atualizado com sucesso.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPut("{id}")]

        public IActionResult PutIdUrl(int id, EstudioDomain estudioAtualizado)
        {

            EstudioDomain estudioBuscado = _EstudioRepository.BuscarPorId(id);

            if (estudioBuscado == null)
            {

                return NotFound
                    (
                        new
                        {
                            mensagem = "Estudio não encontrado!",
                            erro = true
                        }
                    );

            }

            try
            {
                _EstudioRepository.AtualizarIdUrl(id, estudioAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Atualiza suas descrições no corpo do estudio 
        /// </summary>
        /// <returns>Status code que foi atualizado.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPut]
        public IActionResult PutIdBody(EstudioDomain estudioAtualizado)
        {

            if (estudioAtualizado.nomeEstudio == null || estudioAtualizado.idEstudio <= 0)
            {
                return BadRequest
                    (
                        new
                        {
                            mensagemErro = "Nome ou id do estudio não foi informado!"
                        }
                    );
            }

            EstudioDomain estudioBuscado = _EstudioRepository.BuscarPorId(estudioAtualizado.idEstudio);

            if (estudioBuscado != null)
            {

                try
                {
                    _EstudioRepository.AtualizarIdCorpo(estudioAtualizado);

                    return NoContent();
                }
                catch (Exception erro)
                {

                    return BadRequest(erro);

                }

            }

            return NotFound
            (
                new
                {
                    mensagem = "Estudio não encontrado!",
                    erroStatus = true
                }

            );
        }

        /// <summary>
        /// Deleta o estudio selecionado pelo id
        /// </summary>
        /// <returns>Status code que foi deletado o estudio escolhido pelo id.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
         
            _EstudioRepository.Deletar(id);

            return NoContent();
        }
    }
}
