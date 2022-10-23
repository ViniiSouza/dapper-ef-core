using DapperEFCoreAPI.Domain;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Infra.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IRepository<Produto>
    {
        public ProdutoRepository(DbSession session) : base(session)
        {
        }
    }
}
