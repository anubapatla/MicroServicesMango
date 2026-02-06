using mango.Services.AuthAPI.Models.DTO;

namespace mango.Services.AuthAPI.Service.Iservice
{
    public interface IAuthService
    {
        Task<UserDTO> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto);
    }
}
