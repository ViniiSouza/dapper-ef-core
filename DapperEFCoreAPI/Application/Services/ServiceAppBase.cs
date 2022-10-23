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

        public virtual List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
