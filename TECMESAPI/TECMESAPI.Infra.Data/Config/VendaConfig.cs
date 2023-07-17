using TECMESAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace TECMESAPI.Infra.Data.Config
{
    internal class VendaConfig : IEntityTypeConfiguration<VendaEntity>
    {
        public void Configure(EntityTypeBuilder<VendaEntity> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.HasIndex(e => e.ClienteId, "fk_Venda_Cliente1_idx");

            builder.HasIndex(e => e.OrdemProducaoId, "fk_Venda_OrdemProducao1_idx");

            builder.HasIndex(e => e.ProdutoId, "fk_Venda_Produto1_idx");

            builder.Property(e => e.Id).HasColumnName("VND_ID");
            builder.Property(e => e.ClienteId).HasColumnName("Cliente_CLI_ID");
            builder.Property(e => e.OrdemProducaoId).HasColumnName("OrdemProducao_ORD_ID");
            builder.Property(e => e.ProdutoId).HasColumnName("Produto_PRO_ID");
            builder
                .Property(e => e.CriadoEm)
                .HasColumnType("datetime")
                .HasColumnName("VND_CRIADO_EM");
            builder.Property(e => e.Quantidade).HasColumnName("VND_QUANTIDADE");
            builder.Property(e => e.Status).HasColumnName("VND_STATUS");

            builder
                .HasOne(d => d.Cliente)
                .WithMany(p => p.Venda)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("fk_Venda_Cliente1");

            builder
                .HasOne(d => d.OrdemProducao)
                .WithMany(p => p.Venda)
                .HasForeignKey(d => d.OrdemProducaoId)
                .HasConstraintName("fk_Venda_OrdemProducao1");

            builder
                .HasOne(d => d.Produto)
                .WithMany(p => p.Venda)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("fk_Venda_Produto1");
        }
    }
}
