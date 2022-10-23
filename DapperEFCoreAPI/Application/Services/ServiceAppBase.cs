using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Application.Services
{
    public class ServiceAppBase<TEntity> : IServiceAppBase<TEntity> where TEntity : class
    {
        private IRepository<TEntity> _repository;

        public ServiceAppBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
