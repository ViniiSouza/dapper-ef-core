using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public DapperEFCoreDbContext dbContext { get; private set; }

        public UnitOfWork(DapperEFCoreDbContext context)
        {
            dbContext = context;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
