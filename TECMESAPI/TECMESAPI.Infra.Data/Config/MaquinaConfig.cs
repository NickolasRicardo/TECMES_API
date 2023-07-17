using TECMESAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TECMESAPI.Infra.Data.Config
{
    internal class MaquinaConfig : IEntityTypeConfiguration<MaquinaEntity>
    {
        public void Configure(EntityTypeBuilder<MaquinaEntity> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("Maquina");

            builder.Property(e => e.Id).HasColumnName("MAQ_ID");

            builder.Property(e => e.CodigoSerie).HasMaxLength(45).HasColumnName("MAQ_CODIGO_SERIE");

            builder
                .Property(e => e.CriadoEm)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("PRO_CRIADO_EM");
        }
    }
}
