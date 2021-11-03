using Microsoft.AspNetCore.Mvc;
using senai_wishlist_webAPI.Domains;
using senai_wishlist_webAPI.Intefaces;
using senai_wishlist_webAPI.Repositories;

namespace senai_wishlist_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository srRepository { get; set; }
        public UsuariosController()
        {
            srRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(srRepository.ListarTodos());
        }

        [HttpGet("{îd}")]
        public IActionResult BuscarID(int id)
        {
            return Ok(srRepository.BuscarPorID(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            srRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarURL(int id, Usuario usuarioAtualizado)
        {
            srRepository.AtualizarURL(id, usuarioAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            srRepository.Remover(id);

            return StatusCode(204);
        }
    }
}
