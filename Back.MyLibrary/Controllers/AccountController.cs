using Back.MyLibrary.Application.Interfaces;
using Back.MyLibrary.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Back.MyLibrary.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IAccountApplication _accountApplication;
        private readonly ITokenService _tokenService;

        public AccountController(IAccountApplication accountApplication, ITokenService tokenService)
        {
            _accountApplication = accountApplication;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("signup")]
        public async Task<ActionResult<dynamic>> CreateUser([FromBody] Account model)
        {
            var user = await _accountApplication.ValidateUser(model.username, model.apelido,model.email);

            if (user == null)
            {
                var result = await _accountApplication.CreateUser(model);

                if (result)
                {
                    var token = _tokenService.GenerateToken(model);
                    
                    return new
                    {
                        token = token,
                        message = "Usuario criado com sucesso!"
                    };
                }

                else
                {
                    return new
                    {
                        message = "Dados preenchidos incorretamente"
                    };
                }

            }
            return new 
            {
                message = "Usuario ja existe"
            };
        }
        [HttpPut]
        [Route("changepassword")]
        [Authorize]
        public async Task<ActionResult<dynamic>> ChangePassword(string oldPassword, string newPassword)
        {

            return new 
            {
                message = "Senha alterada com sucesso"
            };
        }

    }
}
