using Dapper;
using ManufacturingAPI.Context;
using ManufacturingAPI.Interfaces;
using System.Data;

namespace ManufacturingAPI.Repository
{
    public class DataAccessRepository: IDataAccessRepository
    {
        private readonly DBContext _dbcontext;
        private readonly IConfiguration _configuration;

        public DataAccessRepository(DBContext dbcontext, IConfiguration configuration)
        {
            _dbcontext = dbcontext;
            _configuration = configuration;
        }
        public async Task<IEnumerable<T>> GetAll<T, P>(string query, P parameters)
        {
            using (var connection = _dbcontext.CreateConnection())
            {
                try
                {
                    return await connection.QueryAsync<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: Convert.ToInt32(_configuration["ConnectionStrings:ConnectionTimeout"]));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
       

        
        public async Task<T> GetSingle<T, P>(string query, P parameters)
        {
            T result;
            using (var connection = _dbcontext.CreateConnection())
            {
                try
                {
                    result = (await connection.QueryAsync<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: Convert.ToInt32(_configuration["ConnectionStrings:ConnectionTimeout"])).ConfigureAwait(false)).FirstOrDefault();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        
        public async Task<Int32> Insert<P>(string query, P parameters)
        {
            using (var connection = _dbcontext.CreateConnection())
            {
                try
                {
                    return await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: Convert.ToInt32(_configuration["ConnectionStrings:ConnectionTimeout"]));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    
        public async Task<Int32> Update<P>(string query, P parameters)
        {
            using (var connection = _dbcontext.CreateConnection())
            {
                try
                {
                    return await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: Convert.ToInt32(_configuration["ConnectionStrings:ConnectionTimeout"]));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async Task<Int32> Delete<P>(string query, P parameters)
        {
            using (var connection = _dbcontext.CreateConnection())
            {
                try
                {
                    return await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: Convert.ToInt32(_configuration["ConnectionStrings:ConnectionTimeout"]));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        
    }
}
