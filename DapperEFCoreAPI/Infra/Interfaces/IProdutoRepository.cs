using DapperEFCoreAPI.Domain;

namespace DapperEFCoreAPI.Infra.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        /// <summary>
        /// Método que retorna todos os produtos com a condição especificada de valor
        /// </summary>
        /// <param name="valor">Valor de comparação</param>
        /// <param name="maiorQue">Caso true, retorna os itens maiores que o valor, se não, retorna os menores</param>
        Task<List<Produto>> GetAllByValor(decimal valor, bool maiorQue);

        /// <summary>
        /// Método que retorna todos os produtos com a condição especificada de estoque
        /// </summary>
        /// <param name="estoque">Valor de estoque de comparação</param>
        /// <param name="maiorQue">Caso true, retorna os itens com estoque maiores que o fornecido, se não, retorna os menores</param>
        Task<List<Produto>> GetAllByEstoque(int estoque, bool maiorQue);

        /// <summary>
        /// Método que retorna todos os produtos que têm vínculo com a categoria de id <paramref name="categoriaId"/>
        /// </summary>
        /// <param name="categoriaId">Id da categoria a ser filtrada</param>
        Task<List<Produto>> GetAllByCategoria(int categoriaId);
    }
}
