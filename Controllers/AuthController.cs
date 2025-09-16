using Microsoft.AspNetCore.Mvc;
using SmartRegistrationAPI.Models;
using SmartRegistrationAPI.Services;
using SmartRegistrationAPI;
using SmartRegistrationAPI.DTOs;
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
    }
}
