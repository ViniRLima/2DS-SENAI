using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Rental.WebApi.Domains;
using Senai.Rental.WebApi.Interfaces;
using Senai.Rental.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlugueisController : ControllerBase
    {
        private IAluguelRepository _AluguelRepository { get; set; }

        public AlugueisController()
        {
            _AluguelRepository = new AluguelRepository();
        }


        [HttpGet]
        //IActionResult = Resultado de uma ação.
        //Get() = nome generico
        public IActionResult Get()
        {
            //Lista de Veiculos
            //Se conectar com o Repositório.

            //Cria uma lista nomeada listaAlugueis para receber os dados.
            List<AluguelDomain> listaAlugueis = _AluguelRepository.ListarTodos();

            //Retorna status code 200(OK) com a lista alugueis no formato JSON
            return Ok(listaAlugueis);

        }

        /// <summary>
        /// Lista aluguel buscado por id
        /// </summary>
        /// <param name="id">id do aluguel que será buscado</param>
        /// <returns>retorna o aluguel buscado pelo id</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           AluguelDomain aluguelBuscado = _AluguelRepository.BuscarPorId(id);

            if (aluguelBuscado == null)
            {
                return NotFound("Nenhum veiculo encontrado");
            }
            return Ok(aluguelBuscado);
        }

        /// <summary>
        /// Cadastra um novo aluguel
        /// </summary>
        /// <returns>Um status code 201 - Cread</returns>
        [HttpPost]
        public IActionResult Post(AluguelDomain novoAluguel)
        {

            //Faz a chamada para o método .cadastrar
            _AluguelRepository.Cadastrar(novoAluguel);

            //Retorna um status code 201 - Created
            return StatusCode(201);

        }


        [HttpPut("{id}")]

        public IActionResult PutIdUrl(int id, AluguelDomain aluguelAtualizado)
        {

            AluguelDomain aluguelBuscado = _AluguelRepository.BuscarPorId(id);

            if (aluguelBuscado == null)
            {

                return NotFound
                    (
                        new
                        {
                            mensagem = "Aluguel não encontrado!",
                            erro = true
                        }
                    );

            }

            try
            {
                _AluguelRepository.AtualizarIdUrl(id, aluguelAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }

        [HttpPut]
        public IActionResult PutIdBody(AluguelDomain aluguelAtualizado)
        {
 
            if (aluguelAtualizado.aluguel == null || aluguelAtualizado.idAluguel <= 0)
            {
                return BadRequest
                    (
                        new
                        {
                            mensagemErro = "Nome ou id do aluguel não foi informado!"
                        }
                    );
            }

            AluguelDomain aluguelBuscado = _AluguelRepository.BuscarPorId(aluguelAtualizado.idAluguel);

            if (aluguelBuscado != null)
            {

                try
                {
                    _AluguelRepository.AtualizarIdCorpo(aluguelAtualizado);

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
                    mensagem = "Aluguel não encontrado!",
                    erroStatus = true
                }

            );
        }


        /// <summary>
        /// Deleta um aluguel existente
        /// </summary>
        /// <param name="id">id do aluguel que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// ex: http://localhost:5000/api/aluguel/excluir/9
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Deletar()
            _AluguelRepository.Deletar(id);

            // Retorna um status code 204 - No Content
            return NoContent();
        }
    }
}
