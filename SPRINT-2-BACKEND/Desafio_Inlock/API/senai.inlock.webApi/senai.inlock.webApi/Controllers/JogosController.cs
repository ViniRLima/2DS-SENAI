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
/// Controller responsavel pelos endpoints referentes aos Jogos.
/// </summary>
namespace senai.inlock.webApi.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato domino/api/nomeController.
    // ex: http://localhost:5000/api/jogos
    [Route("api/[controller]")]

    //Define que é um controlador de API.
    [ApiController]
    public class JogosController : ControllerBase
    {
        /// <summary>
        /// Objeto _JogoRepository que irá receber todos os metodos definidor na interface IJogoRepository
        /// </summary>
        private IJogoRepository _JogoRepository { get; set; }

        /// <summary>
        /// Instancia um objeto _JogoRepository para que haja a referencia aos metodos no repositorio.
        /// </summary>
        public JogosController()
        {
            _JogoRepository = new JogoRepository();
        }

        /// <summary>
        /// Lista todos os jogos
        /// </summary>
        /// <returns>Uma lista de jogos e um status code.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR, CLIENTE)
        [Authorize(Roles = "ADMINISTRADOR, CLIENTE")]
        [HttpGet]

        public IActionResult Get()
        {

            List<JogoDomain> listaJogo = _JogoRepository.ListarTodos();


            return Ok(listaJogo);


        }

        /// <summary>
        /// Busca o id Jogo
        /// </summary>
        /// <returns>O id buscado um status code.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            JogoDomain jogoBuscado = _JogoRepository.BuscarPorId(id);

            if (jogoBuscado == null)
            {
                return NotFound("Nenhum jogo encontrado");
            }
            return Ok(jogoBuscado);
        }

        /// <summary>
        /// Cadastra um novo jogo
        /// </summary>
        /// <returns>Um status code de que foi cadastrado o novo jogo.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize (Roles = "ADMINISTRADOR")]
        [HttpPost]
        public IActionResult Post(JogoDomain novoJogo)
        {


            _JogoRepository.Cadastrar(novoJogo);


            return StatusCode(201);


        }

        /// <summary>
        /// Atualiza jogo pelo seu id
        /// </summary>
        /// <returns>Status code que foi atualizado com sucesso.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize (Roles = "ADMINISTRADOR")]
        [HttpPut("{id}")]

        public IActionResult PutIdUrl(int id, JogoDomain jogoAtualizado)
        {

            JogoDomain jogoBuscado = _JogoRepository.BuscarPorId(id);

            if (jogoBuscado == null)
            {

                return NotFound
                    (
                        new
                        {
                            mensagem = "Jogo não encontrado!",
                            erro = true
                        }
                    );

            }

            try
            {
                _JogoRepository.AtualizarIdUrl(id, jogoAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Atualiza suas descrições no corpo do jogo 
        /// </summary>
        /// <returns>Status code que foi atualizado.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize (Roles = "ADMINISTRADOR")]
        [HttpPut]
        public IActionResult PutIdBody(JogoDomain jogoAtualizado)
        {

            if (jogoAtualizado.nomeJogo == null || jogoAtualizado.idJogo <= 0)
            {
                return BadRequest
                    (
                        new
                        {
                            mensagemErro = "Nome ou id do jogo não foi informado!"
                        }
                    );
            }

            JogoDomain jogoBuscado = _JogoRepository.BuscarPorId(jogoAtualizado.idJogo);

            if (jogoBuscado != null)
            {

                try
                {
                    _JogoRepository.AtualizarIdCorpo(jogoAtualizado);

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
                    mensagem = "Jogo não encontrado!",
                    erroStatus = true
                }

            );
        }

        /// <summary>
        /// Deleta o jogo selecionado pelo id
        /// </summary>
        /// <returns>Status code que foi deletado o jogo escolhido pelo id.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize (Roles = "ADMINISTRADOR")]
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
   
            _JogoRepository.Deletar(id);


            return NoContent();
        }
    }
}
