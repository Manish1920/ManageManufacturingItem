using Microsoft.Data.SqlClient;
using System.Data;

namespace ManufacturingAPI.Context
{
    public class DBContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("ManufacturingDB");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
