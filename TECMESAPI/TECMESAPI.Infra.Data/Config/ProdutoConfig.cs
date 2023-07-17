using TECMESAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TECMESAPI.Infra.Data.Config
{
    internal class ProdutoConfig : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("Produto");

            builder.Property(e => e.Id).HasColumnName("PRO_ID");
            builder
                .Property(e => e.CriadoEm)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("PRO_CRIADO_EM");
            builder.Property(e => e.Nome).HasMaxLength(45).HasColumnName("PRO_NOME");
        }
    }
}
