using Dapper;
using DapperEFCoreAPI.Domain;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Infra.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DbSession session, DapperEFCoreDbContext dbContext) : base(session, dbContext)
        {
        }

        public async Task<List<Produto>> GetAllByValor(decimal valor, bool maiorQue)
        {
            using (var connection = _session.Connection)
            {
                var condicao = maiorQue ? ">" : "<";
                string query = "SELECT * FROM Produto" +
                                $"WHERE Valor {condicao} @valor";
                return (await connection.QueryAsync<Produto>(query, valor)).ToList();
            }
        }

        public async Task<List<Produto>> GetAllByEstoque(int estoque, bool maiorQue)
        {
            using (var connection = _session.Connection)
            {
                var condicao = maiorQue ? ">" : "<";
                string query = "SELECT * FROM Produto" +
                                $"WHERE Estoque {condicao} @estoque";
                return (await connection.QueryAsync<Produto>(query, estoque)).ToList();
            }
        }

        public async Task<List<Produto>> GetAllByCategoria(int categoriaId)
        {
            using (var connection = _session.Connection)
            {
                string query = "SELECT * FROM Produto" +
                                "WHERE CategoriaId = @categoriaId";
                return (await connection.QueryAsync<Produto>(query, categoriaId)).ToList();
            }
        }
    }
}
