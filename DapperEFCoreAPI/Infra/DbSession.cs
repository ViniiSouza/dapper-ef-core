using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperEFCoreAPI.Infra
{
    public class DbSession : IDisposable
    {
        public IDbConnection Connection { get; set; }

        public DbSession(IConfiguration configuration)
        {
            Connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));

            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}
