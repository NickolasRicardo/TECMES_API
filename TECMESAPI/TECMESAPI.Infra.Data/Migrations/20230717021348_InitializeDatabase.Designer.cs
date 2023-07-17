﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TECMESAPI.Infra.Data.Context;

#nullable disable

namespace TECMESAPI.Infra.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230717021348_InitializeDatabase")]
    partial class InitializeDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TECMESAPI.Domain.Entities.ClienteEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CLI_ID");

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CLI_CRIADO_EM")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("CLI_NOME");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.MaquinaEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("MAQ_ID");

                    b.Property<string>("CodigoSerie")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("MAQ_CODIGO_SERIE");

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("PRO_CRIADO_EM")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("Maquina", (string)null);
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.OrdemProducaoEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ORD_ID");

                    b.Property<long?>("ClienteId")
                        .HasColumnType("bigint")
                        .HasColumnName("Cliente_CLI_ID");

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("ORD_CRIADO_EM")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("NumeroOrdemProducao")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("ORD_NUMERO_ORDEM_PRODUCAO");

                    b.Property<long?>("ProdutoId")
                        .HasColumnType("bigint")
                        .HasColumnName("Produto_PRO_ID");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("ORD_QUANTIDADE");

                    b.Property<sbyte?>("Status")
                        .HasColumnType("tinyint")
                        .HasColumnName("ORD_STATUS");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ClienteId" }, "fk_OrdemProducao_Cliente_idx");

                    b.HasIndex(new[] { "ProdutoId" }, "fk_OrdemProducao_Produto1_idx");

                    b.ToTable("OrdemProducao", (string)null);
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.ProducaoEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("PRD_ID");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime")
                        .HasColumnName("PRD_CRIADO_EM");

                    b.Property<long?>("MaquinaId")
                        .HasColumnType("bigint")
                        .HasColumnName("Maquina_MAQ_ID");

                    b.Property<long?>("OrdemProducaoId")
                        .HasColumnType("bigint")
                        .HasColumnName("OrdemProducao_ORD_ID");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("PRD_QUANTIDADE");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "MaquinaId" }, "fk_Producao_Maquina1_idx");

                    b.HasIndex(new[] { "OrdemProducaoId" }, "fk_Producao_OrdemProducao1_idx");

                    b.ToTable("Producao", (string)null);
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.ProdutoEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("PRO_ID");

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("PRO_CRIADO_EM")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("PRO_NOME");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("Produto", (string)null);
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.VendaEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("VND_ID");

                    b.Property<long?>("ClienteId")
                        .HasColumnType("bigint")
                        .HasColumnName("Cliente_CLI_ID");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime")
                        .HasColumnName("VND_CRIADO_EM");

                    b.Property<long?>("OrdemProducaoId")
                        .HasColumnType("bigint")
                        .HasColumnName("OrdemProducao_ORD_ID");

                    b.Property<long?>("ProdutoId")
                        .HasColumnType("bigint")
                        .HasColumnName("Produto_PRO_ID");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("VND_QUANTIDADE");

                    b.Property<sbyte?>("Status")
                        .HasColumnType("tinyint")
                        .HasColumnName("VND_STATUS");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ClienteId" }, "fk_Venda_Cliente1_idx");

                    b.HasIndex(new[] { "OrdemProducaoId" }, "fk_Venda_OrdemProducao1_idx");

                    b.HasIndex(new[] { "ProdutoId" }, "fk_Venda_Produto1_idx");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.OrdemProducaoEntity", b =>
                {
                    b.HasOne("TECMESAPI.Domain.Entities.ClienteEntity", "Cliente")
                        .WithMany("OrdemProducaos")
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("fk_OrdemProducao_Cliente");

                    b.HasOne("TECMESAPI.Domain.Entities.ProdutoEntity", "Produto")
                        .WithMany("OrdemProducaos")
                        .HasForeignKey("ProdutoId")
                        .HasConstraintName("fk_OrdemProducao_Produto1");

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.ProducaoEntity", b =>
                {
                    b.HasOne("TECMESAPI.Domain.Entities.MaquinaEntity", "Maquina")
                        .WithMany("Producaos")
                        .HasForeignKey("MaquinaId")
                        .HasConstraintName("fk_Producao_Maquina1");

                    b.HasOne("TECMESAPI.Domain.Entities.OrdemProducaoEntity", "OrdemProducao")
                        .WithMany("Producao")
                        .HasForeignKey("OrdemProducaoId")
                        .HasConstraintName("fk_Producao_OrdemProducao1");

                    b.Navigation("Maquina");

                    b.Navigation("OrdemProducao");
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.VendaEntity", b =>
                {
                    b.HasOne("TECMESAPI.Domain.Entities.ClienteEntity", "Cliente")
                        .WithMany("Venda")
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("fk_Venda_Cliente1");

                    b.HasOne("TECMESAPI.Domain.Entities.OrdemProducaoEntity", "OrdemProducao")
                        .WithMany("Venda")
                        .HasForeignKey("OrdemProducaoId")
                        .HasConstraintName("fk_Venda_OrdemProducao1");

                    b.HasOne("TECMESAPI.Domain.Entities.ProdutoEntity", "Produto")
                        .WithMany("Venda")
                        .HasForeignKey("ProdutoId")
                        .HasConstraintName("fk_Venda_Produto1");

                    b.Navigation("Cliente");

                    b.Navigation("OrdemProducao");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.ClienteEntity", b =>
                {
                    b.Navigation("OrdemProducaos");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.MaquinaEntity", b =>
                {
                    b.Navigation("Producaos");
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.OrdemProducaoEntity", b =>
                {
                    b.Navigation("Producao");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("TECMESAPI.Domain.Entities.ProdutoEntity", b =>
                {
                    b.Navigation("OrdemProducaos");

                    b.Navigation("Venda");
                });
#pragma warning restore 612, 618
        }
    }
}
