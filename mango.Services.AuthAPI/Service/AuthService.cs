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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthService(AppDbContext db,
            UserManager<ApplicationUser>userManager,RoleManager<IdentityRole>roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> Register(RegistrationRequestDto registrationRequestDto)
        {
            ApplicationUser user = new()
            {

                UserName = registrationRequestDto.Email,
                Email = registrationRequestDto.Email,
                NormalizedEmail = registrationRequestDto.Email.ToUpper(),
                Name = registrationRequestDto.Name,
                PhoneNumber = registrationRequestDto.PhoneNumber
            };
            try
            {
                var result =await _userManager.CreateAsync(user,registrationRequestDto.Password);
                if(result.Succeeded)
                {
                    var userToReturn = _db.ApplicationUsers.
                        First(u => u.UserName == registrationRequestDto.Email);
                    UserDTO userDto = new()
                    {
                        Email = userToReturn.Email,
                        ID = userToReturn.Id,
                        Name = userToReturn.Name,
                        PhoneNumber = userToReturn.PhoneNumber
                    };
                    return userDto;
                }
            }
            catch (Exception ex)
            {

            }
            return new UserDTO();
        }
    }
}
