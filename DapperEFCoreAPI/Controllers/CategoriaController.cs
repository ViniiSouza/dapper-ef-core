using DapperEFCoreAPI.Application.Interfaces;
using DapperEFCoreAPI.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DapperEFCoreAPI.Controllers
{
    [ApiController]
    [Route("api/categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriaController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        [HttpGet]
        public async Task<List<Categoria>> GetAll()
        {
            return await _categoriaAppService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Categoria> GetById([FromRoute] int id)
        {
            return await _categoriaAppService.GetByIdAsync(id);
        }

        [HttpPost]
        public void Adicionar([FromBody] Categoria categoria)
        {
            _categoriaAppService.Add(categoria);
        }

        [HttpPut("{id}")]
        public void Alterar([FromBody] Categoria categoria, [FromRoute] int id)
        {
            _categoriaAppService.Update(categoria, id);
        }

        [HttpDelete("{id}")]
        public void Remover([FromRoute] int id)
        {
            _categoriaAppService.Delete(id);
        }
    }
}
