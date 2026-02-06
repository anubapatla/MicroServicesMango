using mango.Services.AuthAPI.Data;
using mango.Services.AuthAPI.Models;
using mango.Services.AuthAPI.Models.DTO;
using mango.Services.AuthAPI.Service.Iservice;
using Microsoft.AspNetCore.Identity;

namespace mango.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthService()
        {

        }
        public Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> Register(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
