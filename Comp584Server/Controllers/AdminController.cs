using Microsoft.AspNetCore.Mvc;
using Comp584Server.Data.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using WorldModel;
using NuGet.Common;

namespace Comp584Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController(UserManager<WorldModelUser> userManager, JwtHandler jwtHandler) : ControllerBase  
    {
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginrequest)
        {
            WorldModelUser? worldUser = await userManager.FindByNameAsync(userName: loginrequest.UserName);
            if (worldUser == null)
            {
                return Unauthorized("Invalid username.");
            }

            bool loginStatus = await userManager.CheckPasswordAsync(worldUser, loginrequest.Password);

            if(!loginStatus)
            {
                return Unauthorized("Invalid password.");
            }

            JwtSecurityToken jwtToken = await jwtHandler.GenerateTokenAsnyc(worldUser);
            var stringToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return Ok(new LoginResponse {
                Success = true,
                Message = "Mom loves me!",
                Token = stringToken
            });

        }
    }
}
