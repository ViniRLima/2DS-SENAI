using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Rental.WebApi.Domains;
using Senai.Rental.WebApi.Interfaces;
using Senai.Rental.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Controlador responsável pelo end points referentes aos clientes.
/// </summary>
namespace Senai.Rental.WebApi.Controllers
{
    //Define que tipo de resposta da API será no Formato JSON.
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato dominio/api/nomeController.
    // ex http://localhost:5000/api/clientes
    [Route("api/[controller]")]
    //Define que é um controlador de API.
    [ApiController]
    public class ClientesController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber todos os métodos definidos na interface IGeneroRepository.
        /// </summary>
        private IClienteRepository _ClienteRepository { get; set; }

        /// <summary>
        /// Instância um objeto _ClienteRepository para que haja a referência dos métodos no repositório.
        /// </summary>
        public ClientesController()
        {
            _ClienteRepository = new ClienteRepository();
        }
        
        [HttpGet]
        //IActionResult = Resultado de uma ação.
        //Get() = nome generico
        public IActionResult Get() 
        {
            //Lista de Clientes
            //Se conectar com o Repositório.

            //Cria uma lista nomeada listaClientes para receber os dados.
            List<ClienteDomain> listaClientes = _ClienteRepository.ListarTodos();

            //Retorna status code 200(OK) com a lista clientes no formato JSON
            return Ok(listaClientes);


        }

        /// <summary>
        /// Lista cliente buscado por id
        /// </summary>
        /// <param name="id">id do cliente que será buscado</param>
        /// <returns>retorna o cliente buscado pelo id</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            ClienteDomain clienteBuscado = _ClienteRepository.BuscarPorId(id);

            if(clienteBuscado == null) 
            {
                return NotFound("Nenhum cliente encontrado");
            }
            return Ok(clienteBuscado);
        }

        /// <summary>
        /// Cadastra um novo cliente
        /// </summary>
        /// <returns>Um status code 201 - Cread</returns>
        [HttpPost]
        public IActionResult Post(ClienteDomain novoCliente) 
        {

            //Faz a chamada para o método .cadastrar
            _ClienteRepository.Cadastrar(novoCliente);

            //Retorna um status code 201 - Created
            return StatusCode(201);


        }

        [HttpPut("{id}")]

        public IActionResult PutIdUrl(int id, ClienteDomain clienteAtulizado) 
        {

            ClienteDomain clienteBuscado = _ClienteRepository.BuscarPorId(id);

            if(clienteBuscado == null) 
            {

                return NotFound
                    (
                        new
                        {
                            mensagem = "Cliente não encontrado!",
                            erro = true
                        }
                    );
                 
            }

            try
            {
                _ClienteRepository.AtualizarIdUrl(id, clienteAtulizado);

                return NoContent();
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }

        [HttpPut]
        public IActionResult PutIdBody(ClienteDomain clienteAtualizado)
        {

            if (clienteAtualizado.nomeCLiente == null || clienteAtualizado.idCliente <= 0) 
            {
                return BadRequest
                    (
                        new
                        { 
                            mensagemErro = "Nome ou id do cliente não foi informado!"
                        }
                    );
            }
                
                ClienteDomain clienteBuscado = _ClienteRepository.BuscarPorId(clienteAtualizado.idCliente);

                if(clienteBuscado != null) 
                {

                    try
                    {
                        _ClienteRepository.AtualizarIdCorpo(clienteAtualizado);

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
                        mensagem = "Cliente não encontrado!",
                        erroStatus = true
                    }

                );
        }

        /// <summary>
        /// Deleta um cliente existente
        /// </summary>
        /// <param name="id">id do cliente que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// ex: http://localhost:5000/api/clientes/excluir/9
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Deletar()
            _ClienteRepository.Deletar(id);

            // Retorna um status code 204 - No Content
            return NoContent();
        }

    }
}
