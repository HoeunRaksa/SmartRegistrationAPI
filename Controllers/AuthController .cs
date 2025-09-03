using Microsoft.AspNetCore.Mvc;
using SmartRegistrationAPI.Models;
using SmartRegistrationAPI.Services;

namespace SmartRegistrationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;

        public AuthController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _userService.AuthenticateAsync(request.Username, request.Password);

            if (user != null)
            {
                var token = _tokenService.GenerateToken(user.Username, user.Role);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
    }
}
