using Back.MyLibrary.Application.DTO;
using Back.MyLibrary.Application.Interfaces;
using Back.MyLibrary.Application.Services;
using Back.MyLibrary.Domain.Interface;
using Back.MyLibrary.Domain.Models;
using Back.MyLibrary.Infra.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Back.MyLibrary.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IAccountApplication _accountApplication;

        public HomeController(ITokenService tokenService, IAccountApplication accountApplication)
        {
            _tokenService = tokenService;
            _accountApplication = accountApplication;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Account model)
        {
            var user = await _accountApplication.Get(model.username, model.password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = _tokenService.GenerateToken(user);

            user.password = "";

            return new
            {
                username = user.username,
                password = user.password,
                role = user.role,
                apelido = user.apelido,
                email = user.email,
                token = token
            };
        }

        [HttpGet]
        [Route("users")]
        [Authorize(Roles = "manager")]
        public async Task<List<Account>> UsersList()
        {
            var users = await _accountApplication.UsersList();
            return users;
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("player")]
        [Authorize(Roles = "player,manager")]
        public string Player() => "Jogador";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}
