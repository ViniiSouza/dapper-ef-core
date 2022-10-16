using Microsoft.EntityFrameworkCore;

namespace DapperEFCoreAPI.Infra
{
    public class DapperEFCoreDbContext : DbContext
    {
        private readonly string _connectionString;

        public DapperEFCoreDbContext(IConfiguration configuration) : base() 
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
