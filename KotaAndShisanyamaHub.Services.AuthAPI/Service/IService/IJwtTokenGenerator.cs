using KotaAndShisanyamaHub.Services.AuthAPI.Models;

namespace KotaAndShisanyamaHub.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
