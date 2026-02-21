using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YardManagement.API.DTO;
using YardManagement.API.Services;
using YardManagement.Core.Entities;

namespace YardManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController (IAuthService AuthService) : ControllerBase
    {

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register (UserDto request)
        {
            var user = await AuthService.RegisterAsync(request);
            if(user is null)
                return BadRequest("User Already Exists");
            
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            var token = await AuthService.LoginAsync(request);
            if(token is null)
                return BadRequest("Invalid Username or Password");
            
            return Ok(token);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AuthenticatedOnlyEndpoint()
        {
            return Ok("You are authorized");
        }
    }
}
