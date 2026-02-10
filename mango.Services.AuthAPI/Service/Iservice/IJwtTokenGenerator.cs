using mango.Services.AuthAPI.Models;

namespace mango.Services.AuthAPI.Service.Iservice
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationuser);
    }
}
