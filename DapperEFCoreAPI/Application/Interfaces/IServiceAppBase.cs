namespace DapperEFCoreAPI.Application.Interfaces
{
    public interface IServiceAppBase<TEntity>
    {
        /// <summary>
        /// Método de busca síncrono que retorna todos os registros da entidade
        /// </summary>
        List<TEntity> GetAll();

        /// <summary>
        /// Método de busca assíncrono que retorna todos os registros da entidade
        /// </summary>
        Task<List<TEntity>> GetAllAsync();

        /// <summary>
        /// Método de busca síncrono que retorna a entidade do id informado
        /// </summary>
        /// <param name="id">Id da entidade desejada</param>
        TEntity GetById(int id);

        /// <summary>
        /// Método de busca assíncrono que retorna a entidade do id informado
        /// </summary>
        /// <param name="id">Id da entidade desejada</param>
        Task<TEntity> GetByIdAsync(int id);

        /// <summary>
        /// Método de adição de entidade no banco
        /// </summary>
        /// <param name="entity">Entidade a ser adicionada</param>
        void Add(TEntity entity);

        /// <summary>
        /// Método de atualização de entidade no banco
        /// </summary>
        /// <param name="entity">Entidade a ser atualizada</param>
        void Update(TEntity entity);

        /// <summary>
        /// Método de deleção de entidade do banco
        /// </summary>
        /// <param name="id">Id da entidade a ser deletada</param>
        void Delete(int id);
    }
}
