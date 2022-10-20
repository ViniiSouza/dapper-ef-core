using DapperEFCoreAPI.Domain;

namespace DapperEFCoreAPI.Infra.Seeds
{
    public static class ProdutoSeed
    {
        public static List<Produto> Seed => new List<Produto>()
        {
            new Produto() {
                Id = 1,
                Nome = "Filé Simples",
                CategoriaId = 1,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Filé Bovino Simples à vácuo",
                Estoque = 500,
                Valor = 24.99M
            },
            new Produto() {
                Id = 2,
                Nome = "Filé duplo",
                CategoriaId = 1,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Filé Bovino duplo à vácuo",
                Estoque = 350,
                Valor = 38.99M
            },
            new Produto() {
                Id = 3,
                Nome = "Leite Integral",
                CategoriaId = 2,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Leite integral 1L",
                Estoque = 2000,
                Valor = 3.69M
            },
            new Produto() {
                Id = 4,
                Nome = "Água sanitária",
                CategoriaId = 3,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Água sanitária 5L",
                Estoque = 1500,
                Valor = 22.69M
            },
            new Produto() {
                Id = 5,
                Nome = "Sabão em pó",
                CategoriaId = 3,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Sabão em pó 1.6kg",
                Estoque = 850,
                Valor = 23.99M
            },
            new Produto() {
                Id = 6,
                Nome = "Limpador multiuso",
                CategoriaId = 3,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Limpador multiuso 5L",
                Estoque = 500,
                Valor = 31.99M
            },
            new Produto() {
                Id = 7,
                Nome = "Margarina",
                CategoriaId = 2,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Margarina 500g",
                Estoque = 1000,
                Valor = 5.99M
            },
            new Produto() {
                Id = 8,
                Nome = "Iogurte integral",
                CategoriaId = 2,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Iogurte integral 170g",
                Estoque = 1000,
                Valor = 2.99M
            },
            new Produto() {
                Id = 9,
                Nome = "Carne bovina moída de contra filé",
                CategoriaId = 1,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Carne bovina moída de contra filé resfriada",
                Estoque = 350,
                Valor = 36.29M
            },
            new Produto() {
                Id = 10,
                Nome = "Lava-Roupas em Pó",
                CategoriaId = 3,
                DataCadastro = new DateTime(2022, 10,19),
                Descricao = "Lava-Rouaps em Pó 1,6Kg",
                Estoque = 1000,
                Valor = 21.90M
            },
        };

    }
}
