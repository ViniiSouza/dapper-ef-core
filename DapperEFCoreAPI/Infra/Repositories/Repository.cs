using Dapper;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSession _session;
        private DapperEFCoreDbContext _dbContext;

        public Repository(DbSession session)
        {
            _session = session;
        }

        public List<TEntity> GetAll()
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name}";
                List<TEntity> itens = connection.Query<TEntity>(query).ToList();
                return itens;
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name}";
                List<TEntity> itens = (await connection.QueryAsync<TEntity>(query)).ToList();
                return itens;
            }
        }

        public TEntity GetById(int id)
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name} WHERE Id = @id";
                TEntity entity = connection.QueryFirstOrDefault<TEntity>(query, new { id });

                return entity;
            }
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            using (var connection = _session.Connection)
            {
                string query = $"SELECT * FROM {typeof(TEntity).Name} WHERE Id = @id";
                TEntity entity = await connection.QueryFirstOrDefaultAsync<TEntity>(query, new { id });

                return entity;
            }
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
