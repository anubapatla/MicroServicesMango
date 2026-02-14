using mango.web.Models;
using Mango.Web.Models;

namespace Mango.Web.Services.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> RegisterAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
    }
}
