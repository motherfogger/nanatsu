using nanatsu.Models;

namespace nanatsu.Services
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost(Guid id);
        Task<Post> AddPost(Post post);
        Task<Post> UpdatePost(Post post);
        Task<Post> DeletePost(Guid id);

        // Task<bool> CreateEmployee(Employee employee);
        // Task<Employee> GetEmployee(int id);
        // Task<List<Employee>> GetEmployeeList();
        // Task<Employee> UpdateEmployee(Employee employee);
        // Task<bool> DeleteEmployee(int key);
    }
}