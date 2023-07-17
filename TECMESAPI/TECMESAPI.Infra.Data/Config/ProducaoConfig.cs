using TECMESAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace TECMESAPI.Infra.Data.Config
{
    internal class ProducaoConfig : IEntityTypeConfiguration<ProducaoEntity>
    {
        public void Configure(EntityTypeBuilder<ProducaoEntity> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("Producao");

            builder.HasIndex(e => e.MaquinaId, "fk_Producao_Maquina1_idx");

            builder.HasIndex(e => e.OrdemProducaoId, "fk_Producao_OrdemProducao1_idx");

            builder.Property(e => e.Id).HasColumnName("PRD_ID");
            builder.Property(e => e.MaquinaId).HasColumnName("Maquina_MAQ_ID");
            builder.Property(e => e.OrdemProducaoId).HasColumnName("OrdemProducao_ORD_ID");
            builder
                .Property(e => e.CriadoEm)
                .HasColumnType("datetime")
                .HasColumnName("PRD_CRIADO_EM");
            builder.Property(e => e.Quantidade).HasColumnName("PRD_QUANTIDADE");

            builder
                .HasOne(d => d.Maquina)
                .WithMany(p => p.Producaos)
                .HasForeignKey(d => d.MaquinaId)
                .HasConstraintName("fk_Producao_Maquina1");

            builder
                .HasOne(d => d.OrdemProducao)
                .WithMany(p => p.Producao)
                .HasForeignKey(d => d.OrdemProducaoId)
                .HasConstraintName("fk_Producao_OrdemProducao1");
        }
    }
}
