using DapperEFCoreAPI.Domain;
using DapperEFCoreAPI.Infra.Seeds;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DapperEFCoreAPI.Infra
{
    public class DapperEFCoreDbContext : DbContext
    {
        private const string Mapping_Path = "DapperEFCoreAPI.Infra.Mappings";
        private readonly string _connectionString;

        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }

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

            modelBuilder.Entity<Produto>().HasData(ProdutoSeed.Seed);

            modelBuilder.Entity<Categoria>().HasData(CategoriaSeed.Seed);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
