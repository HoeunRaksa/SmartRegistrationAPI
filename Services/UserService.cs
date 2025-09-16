using SmartRegistrationAPI.Models;
using SmartRegistrationAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace SmartRegistrationAPI.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null) return null;

            // Verify password
            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash) ? user : null;
        }

        public async Task<User> RegisterAsync(User user, string password)
        {
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
