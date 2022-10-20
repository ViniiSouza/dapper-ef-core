using DapperEFCoreAPI.Domain;

namespace DapperEFCoreAPI.Infra.Seeds
{
    public static class CategoriaSeed
    {
        public static List<Categoria> Seed => new List<Categoria>
        {
            new Categoria()
            {
                Id = 1,
                Nome = "Carnes",
                DataCadastro = new DateTime(2022, 10,19)
            },
            new Categoria()
            {
                Id = 2,
                Nome = "Produtos lácteos",
                DataCadastro = new DateTime(2022, 10,19)
            },
            new Categoria()
            {
                Id = 3,
                Nome = "Produtos de limpeza",
                DataCadastro = new DateTime(2022, 10,19)
            },
        };
    }
}
