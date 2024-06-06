using Prattle.App.Models;

namespace Prattle.App.Data.Interfaces
{
    public interface IAuthService
    {
        Task<UserDTO> Login(string username, string password);
    }
}
