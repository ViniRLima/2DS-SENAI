using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using roman_mobileAPI.Domains;
using roman_mobileAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

/// <summary>
/// Controller responsavel pelos endpoints referentes aos Usuarios.
/// </summary>
namespace roman_mobileAPI.Controllers
{
    
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato domino/api/nomeController.
    // ex: http://localhost:5000/api/usuarios
    [Route("api/[controller]")]

    //Define que é um controlador de API.
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        
        
         /// <summary>
        /// Objeto _usuarioRepository que irá receber todos os metodos definidor na interface IUsuarioRepository
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia um objeto _usuarioRepository para que haja a referencia aos metodos no repositorio.
        /// </summary>
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista todos os Usuarios
        /// </summary>
        /// <returns>Uma lista Usuarios e um status code.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_usuarioRepository.Listar());
        }

        /// <summary>
        ///  Busca um Usuario por Id
        /// </summary>
        /// <returns>O id buscado um status code.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "1")]
        [HttpGet("{idTipoUsuario}")]
        public IActionResult BuscarPorId(int idUsuario)
        {
            return Ok(_usuarioRepository.BuscarPorId(idUsuario));
        }

        /// <summary>
        /// Cadastrar um novo Usuario
        /// </summary>
        /// <returns>Um status code de que foi cadastrado o novo usuario.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(UsuarioDomain novoUsuario)
        {
            _usuarioRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um Tipo de Usuario através do seu id
        /// </summary>
        /// <returns>Status code que foi deletado o usuario escolhido pelo id.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "1")]
        [HttpDelete("{idUsuario}")]
        public IActionResult Deletar(int idUsuario)
        {
            _usuarioRepository.Deletar(idUsuario);

            return StatusCode(204);
        }

        /// <summary>
        /// Atualizar um Usuario existente através do seu id
        /// </summary>
        /// <returns>Status code que foi atualizado com sucesso.</returns>
        /// Authorize - Autorização de quem pode te acesso
        /// Roles - Os Autorizados (ADMINISTRADOR)
        [Authorize(Roles = "1")]
        [HttpPut("{idUsuario}")]
        public IActionResult Atualizar(int idTipoUsuario, UsuarioDomain usuarioAtualizado)
        {
            _usuarioRepository.Atualizar(idTipoUsuario, usuarioAtualizado);

            return StatusCode(204);
        }

        
        /// <summary>
        /// Gera um token para email cadastrados no sistema do banco de dados
        /// </summary>
        /// <param name="login">Objeto login utilizado para alocar os dados recebidos</param>
        /// <returns>retorna um token</returns>
        [HttpPost("login")]

        public IActionResult Login(UsuarioDomain login)
        {
            UsuarioDomain usuarioBuscado = _usuarioRepository.BuscarPorEmailSenha(login.Email, login.Senha);

            if (usuarioBuscado == null)
            {
                return NotFound("E-mail ou senha invalidos");
            }

            // Definição das claims de acesso
            var minhasClaims = new[]
            {

                new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
               // new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuarioNavigation.TipoUsuario1),
               new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString()),
            };
            //Define a chave de acesso ao token
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Chave-autenticacao-API-MedGroup"));

            // Define as credenciais do token - signature
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Composição do Token
            var meuToken = new JwtSecurityToken(
                    issuer: "Senai.Roman", //emissor do token
                    audience: "Senai.Roman", // destinatario do token
                    claims: minhasClaims, //    dados definidos acima
                    expires: DateTime.Now.AddMinutes(30), // Tempo limite de duração do token
                    signingCredentials: creds // Credenciais

                );
            // Retorna o token criado apartir dos usuarios cadastrados
            return Ok(new
            {
               token = new JwtSecurityTokenHandler().WriteToken(meuToken)
            });

        }



    }
}
