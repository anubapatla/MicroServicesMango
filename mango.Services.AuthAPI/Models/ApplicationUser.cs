using Microsoft.AspNetCore.Identity;

namespace mango.Services.AuthAPI.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string Name { get; set; }

    }
}
