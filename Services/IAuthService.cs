using WebApi.Models;

namespace WebApi.Services
{
    public interface IAuthService
    {
        Task<(int, string)> Registeration(RegistrationModel model);
        Task<(int, string)> Login(LoginModel model);
    }
}
