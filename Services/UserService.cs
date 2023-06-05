using nanatsu.Models;

namespace nanatsu.Services
{
    public class UserService : IUserService
    {
        private readonly IDbService _dbService;

        public UserService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var sql = "SELECT * FROM users LIMIT 10";
            return await _dbService.QueryAsync<User>(sql);
        }

        public async Task<User> GetUser(Guid id)
        {
            var sql = "SELECT * FROM users WHERE id = @id";
            return await _dbService.QueryFirstOrDefaultAsync<User>(sql, new { id });
        }

        public async Task<User> AddUser(User user)
        {
            var sql = "INSERT INTO users (name, email) VALUES (@name, @email)";
            return await _dbService.QueryFirstOrDefaultAsync<User>(sql, user);
        }

        public async Task<User> UpdateUser(User user)
        {
            var sql = "UPDATE users SET name = @name, email = @email";
            return await _dbService.QueryFirstOrDefaultAsync<User>(sql, user);
        }

        public async Task<User> DeleteUser(Guid user)
        {
            var sql = "UPDATE users SET status = 6, email = @email";
            return await _dbService.QueryFirstOrDefaultAsync<User>(sql, user);
        }
        
    }
}

