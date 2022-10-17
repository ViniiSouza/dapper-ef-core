using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DapperEFCoreAPI.Infra
{
    public class DapperEFCoreDbContext : DbContext
    {
        private const string Mapping_Path = "DapperEFCoreAPI.Infra.Mappings";
        private readonly string _connectionString;

        public DapperEFCoreDbContext(IConfiguration configuration) : base() 
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.Namespace != null && type.IsPublic && type.Namespace.StartsWith(Mapping_Path))
                .ToList()
                .ForEach(type =>
                {
                    dynamic instance = Activator.CreateInstance(type);
                    modelBuilder.ApplyConfiguration(instance);
                });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
