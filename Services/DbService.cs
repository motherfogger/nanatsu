

using Dapper;
using System.Data;
using Npgsql;

namespace nanatsu.Services
{
    public class DbService : IDbService
    {
        private readonly IDbConnection _dbConnection;
        public DbService(IConfiguration configuration)
        {
            _dbConnection = new NpgsqlConnection(configuration.GetConnectionString("POSTGRESQL"));
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null)
        {
            return await _dbConnection.QueryAsync<T>(sql, param);
        }
        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object? param = null)
        {
            return await _dbConnection.QueryFirstOrDefaultAsync<T>(sql, param);
        }
        public async Task<T> QuerySingleAsync<T>(string sql, object? param = null)
        {
            return await _dbConnection.QuerySingleAsync<T>(sql, param);
        }
        public async Task<T> QuerySingleOrDefaultAsync<T>(string sql, object? param = null)
        {
            return await _dbConnection.QuerySingleOrDefaultAsync<T>(sql, param);
        }
        public async Task<int> ExecuteAsync(string sql, object? param = null)
        {
            return await _dbConnection.ExecuteAsync(sql, param);
        }
        public async Task<T> ExecuteScalarAsync<T>(string sql, object? param = null)
        {
            return await _dbConnection.ExecuteScalarAsync<T>(sql, param);
        }

        public void Dispose()
        {
            // TODO: when to use dispose?
            _dbConnection.Close();
            _dbConnection.Dispose();
        }
    }
    
}