using SmartRegistrationAPI.Models; // important
using System.Threading.Tasks;

namespace SmartRegistrationAPI.Services
{
    public interface IUserService
    {
        Task<User?> AuthenticateAsync(string username, string password);
        Task<User> RegisterAsync(User user, string password);
    }
}
