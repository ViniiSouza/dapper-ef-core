using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Application.Services;
using DapperEFCoreAPI.Infra;
using DapperEFCoreAPI.Infra.Interfaces;
using DapperEFCoreAPI.Infra.Repositories;

namespace DapperEFCoreAPI.Security
{
    public static class DependencyResolver
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            service.AddScoped<DapperEFCoreDbContext>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<DbSession>();
            service.AddTransient<ICategoriaRepository, CategoriaRepository>();
            service.AddTransient<IProdutoRepository, ProdutoRepository>();
            service.AddTransient<ICategoriaAppService, CategoriaAppService>();
            service.AddTransient<IProdutoAppService, ProdutoAppService>();
        }
    }
}
