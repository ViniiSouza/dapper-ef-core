using Dapper;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbSession _session;
        protected DapperEFCoreDbContext _dbContext;

        public Repository(DbSession session, DapperEFCoreDbContext dbContext)
        {
            _session = session;
            _dbContext = dbContext;
        }

        public virtual List<TEntity> GetAll()
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name}";
                List<TEntity> itens = connection.Query<TEntity>(query).ToList();
                return itens;
            }
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name}";
                List<TEntity> itens = (await connection.QueryAsync<TEntity>(query)).ToList();
                return itens;
            }
        }

        public virtual TEntity GetById(int id)
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name} WHERE Id = @id";
                TEntity entity = connection.QueryFirstOrDefault<TEntity>(query, new { id });

                return entity;
            }
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name} WHERE Id = @id";
                TEntity entity = await connection.QueryFirstOrDefaultAsync<TEntity>(query, new { id });

                return entity;
            }
        }

        public virtual void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
