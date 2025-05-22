using LogoMuhasebeApp.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace LogoMuhasebeApp.Infrastructure.Services
{
    public class JwtTokenService : ITokenService
    {
        private readonly string _secretKey;

        public JwtTokenService(IConfiguration configuration)
        {
            _secretKey = configuration["Jwt:Key"];
        }
        public string GenerateToken(Login user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(ClaimTypes.Name, user.Username),
                
            };
            var token = new JwtSecurityToken(
                issuer: "LogoMuhasebeApp",
                audience: "LogoMuhasebeAppUsers",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

