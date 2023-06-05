using nanatsu.Models;

namespace nanatsu.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(Guid id);
        Task<User> AddUser(User post);
        Task<User> UpdateUser(User post);
        Task<User> DeleteUser(Guid id);

    }
}