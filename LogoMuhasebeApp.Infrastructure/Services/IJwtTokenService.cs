using LogoMuhasebeApp.Domain.Entities;

namespace LogoMuhasebeApp.Infrastructure.Services
{
    public interface ITokenService
    {
        string GenerateToken(Login user);
    }
}
