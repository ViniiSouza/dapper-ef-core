using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DapperEFCoreAPI.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpGet]
        public async Task<List<Produto>> GetAll()
        {
            return await _produtoAppService.GetAllAsync();
        }

        [HttpGet("estoque")]
        public async Task<List<Produto>> GetAllByEstoque([FromQuery] int estoque, [FromQuery] bool maiorQue)
        {
            return await _produtoAppService.GetAllByEstoque(estoque, maiorQue);
        }

        [HttpGet("valor")]
        public async Task<List<Produto>> GetAllByValor([FromQuery] decimal valor, [FromQuery] bool maiorQue)
        {
            return await _produtoAppService.GetAllByValor(valor, maiorQue);
        }

        [HttpGet("{id}")]
        public async Task<Produto> GetById([FromRoute] int id)
        {
            return await _produtoAppService.GetByIdAsync(id);
        }

        [HttpGet("categoria/{categoriaId}")]
        public async Task<List<Produto>> GetAllByCategoria([FromRoute] int categoriaId)
        {
            return await _produtoAppService.GetAllByCategoria(categoriaId);
        }

        [HttpPost]
        public void Adicionar([FromBody] Produto categoria)
        {
            _produtoAppService.Add(categoria);
        }

        [HttpPut("{id}")]
        public void Alterar([FromBody] Produto categoria, [FromRoute] int id)
        {
            _produtoAppService.Update(categoria, id);
        }

        [HttpDelete("{id}")]
        public void Remover([FromRoute] int id)
        {
            _produtoAppService.Delete(id);
        }
    }
}
