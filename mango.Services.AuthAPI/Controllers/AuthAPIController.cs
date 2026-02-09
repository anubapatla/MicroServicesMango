using Json.Schema;
using mango.Services.AuthAPI.Models.DTO;
using mango.Services.AuthAPI.Service.Iservice;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace mango.Services.AuthAPI.Controllers
{
    public class AuthAPIController : Controller
    {
        private readonly IAuthService _authService;
        protected ResponseDto _response;
        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }



        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto model)
        {
            var errorMessage = await _authService.Register(model);
              if(!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
              return Ok(_response);
                
                }
        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok(_response);
        }

    }
}