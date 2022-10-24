namespace DapperEFCoreAPI.Domain
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }

        public string? Descricao { get; set; }

        public decimal Valor { get; set; }

        public int Estoque { get; set; }

        public Categoria? Categoria { get; set; }

        public int CategoriaId { get; set; }
    }
}
