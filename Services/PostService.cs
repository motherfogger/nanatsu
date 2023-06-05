using nanatsu.Models;

namespace nanatsu.Services
{
    public class PostService : IPostService
    {
        private readonly IDbService _dbService;

        public PostService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var sql = "SELECT * FROM posts LIMIT 10";
            return await _dbService.QueryAsync<Post>(sql);
        }

        public async Task<Post> GetPost(Guid id)
        {
            var sql = "SELECT * FROM posts WHERE id = @id";
            return await _dbService.QueryFirstOrDefaultAsync<Post>(sql, new { id });
        }

        public async Task<Post> AddPost(Post post)
        {
            var sql = "INSERT INTO posts (title, content) VALUES (@title, @content) RETURNING *";
            return await _dbService.QueryFirstOrDefaultAsync<Post>(sql, post);
        }

        public async Task<Post> UpdatePost(Post post)
        {
            var sql = "UPDATE posts SET title = @title, content = @content WHERE id = @id RETURNING *";
            return await _dbService.QueryFirstOrDefaultAsync<Post>(sql, post);
        }

        public async Task<Post> DeletePost(Guid id)
        {
            var sql = "DELETE FROM posts WHERE id = @id RETURNING *";
            return await _dbService.QueryFirstOrDefaultAsync<Post>(sql, new { id });
        }

        
    }
}