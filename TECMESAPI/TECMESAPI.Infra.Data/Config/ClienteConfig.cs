using TECMESAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace TECMESAPI.Infra.Data.Config
{
    internal class ClienteConfig : IEntityTypeConfiguration<ClienteEntity>
    {
        public void Configure(EntityTypeBuilder<ClienteEntity> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.Property(e => e.Id).HasColumnName("CLI_ID");

            builder
                .Property(e => e.CriadoEm)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("CLI_CRIADO_EM");

            builder.Property(e => e.Nome).HasMaxLength(45).HasColumnName("CLI_NOME");
        }
    }
}
