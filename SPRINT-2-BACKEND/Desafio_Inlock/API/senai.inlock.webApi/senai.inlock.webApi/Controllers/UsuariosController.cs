using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        /// <summary>
        /// Objeto _UsuarioRepository que irá receber todos os metodos definidor na interface IUsuarioRepository
        /// </summary>
        private IUsuarioRepository _UsuarioRepository { get; set; } 

        /// <summary>
        /// Instancia um objeto _UsuarioRepository para que haja a referencia aos metodos no repositorio.
        /// </summary>
        public UsuariosController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }


        /// <summary>
        /// Gera um token para email cadastrados no sistema do banco de dados
        /// </summary>
        /// <param name="login">Objeto login utilizado para alocar os dados recebidos</param>
        /// <returns>retorna um token</returns>
        [HttpPost("login")]

    public IActionResult Login(UsuarioDomain login)
    {
        UsuarioDomain usuarioBuscado =  _UsuarioRepository.BuscarPorEmailSenha(login.email, login.senha);

            if (usuarioBuscado == null) 
            {
                return NotFound("E-mail ou senha invalidos");
            }

            // Definição das claims de acesso
            var minhasClaims = new[]
            {

                new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.email),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.idUsuario.ToString()),
                new Claim(ClaimTypes.Role, usuarioBuscado.idTipoUsuario.titulo),
            };
            //Define a chave de acesso ao token
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Chave-autenticacao-API-Inlock"));

            // Define as credenciais do token - signature
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Composição do Token
            var meuToken = new JwtSecurityToken(
                    issuer: "Senai.Inlock", //emissor do token
                    audience: "Senai.Inlock", // destinatario do token
                    claims: minhasClaims, //    dados definidos acima
                    expires: DateTime.Now.AddMinutes(30), // Tempo limite de duração do token
                    signingCredentials: creds // Credenciais

                );
            // Retorna o token criado apartir dos usuarios cadastrados
            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(meuToken)
            }) ;
        
    }
    
    }


}
