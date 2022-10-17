using DapperEFCoreAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperEFCoreAPI.Infra.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasMaxLength(50);

            builder.Property(prop => prop.Descricao)
                .HasMaxLength(250);

            builder.Property(prop => prop.Valor)
                .HasColumnType("decimal(8,2)");

            builder.HasOne(prop => prop.Categoria)
                .WithMany(prop => prop.Produtos)
                .HasForeignKey(prop => prop.CategoriaId);
        }
    }
}
