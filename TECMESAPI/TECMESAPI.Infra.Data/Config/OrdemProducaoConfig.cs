using TECMESAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace TECMESAPI.Infra.Data.Config
{
    internal class OrdemProducaoConfig : IEntityTypeConfiguration<OrdemProducaoEntity>
    {
        public void Configure(EntityTypeBuilder<OrdemProducaoEntity> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("OrdemProducao");

            builder.HasIndex(e => e.ClienteId, "fk_OrdemProducao_Cliente_idx");

            builder.HasIndex(e => e.ProdutoId, "fk_OrdemProducao_Produto1_idx");

            builder.Property(e => e.Id).HasColumnName("ORD_ID");
            builder.Property(e => e.ClienteId).HasColumnName("Cliente_CLI_ID");
            builder
                .Property(e => e.CriadoEm)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("ORD_CRIADO_EM");

            builder
                .Property(e => e.NumeroOrdemProducao)
                .HasMaxLength(45)
                .HasColumnName("ORD_NUMERO_ORDEM_PRODUCAO");
            builder.Property(e => e.Quantidade).HasColumnName("ORD_QUANTIDADE");
            builder.Property(e => e.Status).HasColumnName("ORD_STATUS");
            builder.Property(e => e.ProdutoId).HasColumnName("Produto_PRO_ID");

            builder
                .HasOne(d => d.Cliente)
                .WithMany(p => p.OrdemProducaos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("fk_OrdemProducao_Cliente");

            builder
                .HasOne(d => d.Produto)
                .WithMany(p => p.OrdemProducaos)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("fk_OrdemProducao_Produto1");

            builder.Navigation(e => e.Cliente).AutoInclude();
            builder.Navigation(e => e.Produto).AutoInclude();
            builder.Navigation(e => e.Producao).AutoInclude();
        }
    }
}
