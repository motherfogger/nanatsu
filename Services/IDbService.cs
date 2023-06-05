namespace nanatsu.Services
{
    // implement the interface
    public interface IDbService
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null);
        Task<T> QueryFirstOrDefaultAsync<T>(string sql, object? param = null);
        Task<T> QuerySingleAsync<T>(string sql, object? param = null);
        Task<T> QuerySingleOrDefaultAsync<T>(string sql, object? param = null);
        Task<int> ExecuteAsync(string sql, object? param = null);
        Task<T> ExecuteScalarAsync<T>(string sql, object? param = null);

        // Task<T> GetAsync<T>(string command, object parms);
        // Task<List<T>> GetAll<T>(string command, object parms);
        // Task<int> EditData(string command, object parms);
    }

}