using YardManagement.API.DTO;
using YardManagement.Core.Entities;

namespace YardManagement.API.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
