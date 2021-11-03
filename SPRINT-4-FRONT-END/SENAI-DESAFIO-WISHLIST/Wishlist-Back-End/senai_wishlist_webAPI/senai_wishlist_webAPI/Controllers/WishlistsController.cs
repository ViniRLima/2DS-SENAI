using Microsoft.AspNetCore.Mvc;
using senai_wishlist_webAPI.Domains;
using senai_wishlist_webAPI.Intefaces;
using senai_wishlist_webAPI.Repositories;

namespace senai_wishlist_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistsController : ControllerBase
    {
        private IWishlistRepository wshlstRepository { get; set; }
        public WishlistsController()
        {
            wshlstRepository = new WishlistRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(wshlstRepository.ListarTodos());
        }

        [HttpGet("{îd}")]
        public IActionResult BuscarID(int id)
        {
            return Ok(wshlstRepository.BuscarPorID(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Wishlist novoDesejo)
        {
            wshlstRepository.Cadastrar(novoDesejo);

            return StatusCode(201);
        }
    }
}
