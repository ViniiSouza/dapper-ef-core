using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Domain;
using DapperEFCoreAPI.Infra.Interfaces;

namespace DapperEFCoreAPI.Application.Services
{
    public class ProdutoAppService : ServiceAppBase<Produto>, IProdutoAppService
    {
        public ProdutoAppService(IProdutoRepository repository) : base(repository)
        {
        }

        public async Task<List<Produto>> GetAllByEstoque(int estoque, bool maiorQue)
        {
            return await ((IProdutoRepository)_repository).GetAllByEstoque(estoque, maiorQue);
        }

        public async Task<List<Produto>> GetAllByValor(decimal valor, bool maiorQue)
        {
            return await ((IProdutoRepository)_repository).GetAllByValor(valor, maiorQue);
        }
    }
}
