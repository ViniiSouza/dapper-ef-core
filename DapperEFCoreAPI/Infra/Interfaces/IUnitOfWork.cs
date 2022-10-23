namespace DapperEFCoreAPI.Infra.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
