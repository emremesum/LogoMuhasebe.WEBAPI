using LogoMuhasebeApp.Domain.Entities;
using LogoMuhasebeApp.Infrastructure.Repositories;
using LogoMuhasebeApp.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace LogoMuhasebeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly LoginRepository _userRepository;
        private readonly ITokenService _tokenService;
        public AuthController(LoginRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }
      
        [HttpPost("login")]
        public IActionResult Login([FromBody] Login request)
        {
            var user = _userRepository.GetUser(request.Username, request.Password,request.FirmNr,request.PeriodNr);
            if (user == null)
            {
                return Unauthorized(new { message = "Kullanıcı adı veya parola yanlış." });
            }
            var token = _tokenService.GenerateToken(user);
            return Ok(new { token });
        }
    }
}
