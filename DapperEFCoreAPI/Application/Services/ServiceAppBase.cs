using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Domain;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Application.Services
{
    public class ServiceAppBase<TEntity> : IServiceAppBase<TEntity> where TEntity : EntidadeBase
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public ServiceAppBase(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
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
            _unitOfWork.Commit();
        }

        public virtual void Update(TEntity entity, int id)
        {
            entity.Id = id;
            _repository.Update(entity);
            _unitOfWork.Commit();
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
            _unitOfWork.Commit();
        }
    }
}
