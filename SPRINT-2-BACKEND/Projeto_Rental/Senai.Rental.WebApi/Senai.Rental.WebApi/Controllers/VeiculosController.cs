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

    //Define que tipo de resposta da API será no Formato JSON.
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato dominio/api/nomeController.
    // ex http://localhost:5000/api/veiculo
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private IVeiculoRepository _VeiculoRepository { get; set; }

        public VeiculosController()
        {
            _VeiculoRepository = new VeiculoRepository();
        }


        [HttpGet]
        //IActionResult = Resultado de uma ação.
        //Get() = nome generico
        public IActionResult Get()
        {
            //Lista de Veiculos
            //Se conectar com o Repositório.

            //Cria uma lista nomeada listaVeiculos para receber os dados.
            List<VeiculoDomain> listaVeiculos = _VeiculoRepository.ListarTodos();

            //Retorna status code 200(OK) com a lista veiculos no formato JSON
            return Ok(listaVeiculos);

        }

        /// <summary>
        /// Lista veiculo buscado por id
        /// </summary>
        /// <param name="id">id do veiculo que será buscado</param>
        /// <returns>retorna o veiculo buscado pelo id</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            VeiculoDomain veiculoBuscado = _VeiculoRepository.BuscarPorId(id);

            if (veiculoBuscado == null)
            {
                return NotFound("Nenhum veiculo encontrado");
            }
            return Ok(veiculoBuscado);
        }

        /// <summary>
        /// Cadastra um novo veiculo
        /// </summary>
        /// <returns>Um status code 201 - Cread</returns>
        [HttpPost]
        public IActionResult Post(VeiculoDomain novoVeiculo)
        {

            //Faz a chamada para o método .cadastrar
            _VeiculoRepository.Cadastrar(novoVeiculo);

            //Retorna um status code 201 - Created
            return StatusCode(201);

        }


        [HttpPut("{id}")]

        public IActionResult PutIdUrl(int id, VeiculoDomain veiculoAtulizado)
        {

            VeiculoDomain veiculoBuscado = _VeiculoRepository.BuscarPorId(id);

            if (veiculoBuscado == null)
            {

                return NotFound
                    (
                        new
                        {
                            mensagem = "Veiculo não encontrado!",
                            erro = true
                        }
                    );

            }

            try
            {
                _VeiculoRepository.AtualizarIdUrl(id, veiculoAtulizado);

                return NoContent();
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }

        [HttpPut]
        public IActionResult PutIdBody(VeiculoDomain veiculoAtualizado)
        {

            if (veiculoAtualizado.nomeVeiculo == null || veiculoAtualizado.idVeiculo <= 0)
            {
                return BadRequest
                    (
                        new
                        {
                            mensagemErro = "Nome ou id do veiculo não foi informado!"
                        }
                    );
            }

            VeiculoDomain veiculoBuscado = _VeiculoRepository.BuscarPorId(veiculoAtualizado.idVeiculo);

            if (veiculoBuscado != null)
            {

                try
                {
                    _VeiculoRepository.AtualizarIdCorpo(veiculoAtualizado);

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
                    mensagem = "Veiculo não encontrado!",
                    erroStatus = true
                }

            );
        }


        /// <summary>
        /// Deleta um veiculo existente
        /// </summary>
        /// <param name="id">id do veiculo que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// ex: http://localhost:5000/api/veiculo/excluir/9
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Deletar()
            _VeiculoRepository.Deletar(id);

            // Retorna um status code 204 - No Content
            return NoContent();
        }

    }
}
