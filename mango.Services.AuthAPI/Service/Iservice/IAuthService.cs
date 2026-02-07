using mango.Services.AuthAPI.Models.DTO;

namespace mango.Services.AuthAPI.Service.Iservice
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto);
    }
}
