using DapperEFCoreAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DapperEFCoreAPI.Infra.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasMaxLength(50);

            builder.Property(prop => prop.Descricao)
                .HasMaxLength(250);

            builder.HasMany(prop => prop.Produtos)
                .WithOne(prop => prop.Categoria);
        }
    }
}
