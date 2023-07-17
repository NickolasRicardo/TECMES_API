using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TECMESAPI.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitializeDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    CLI_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CLI_NOME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CLI_CRIADO_EM = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.CLI_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Maquina",
                columns: table => new
                {
                    MAQ_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MAQ_CODIGO_SERIE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRO_CRIADO_EM = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.MAQ_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    PRO_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PRO_NOME = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRO_CRIADO_EM = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.PRO_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdemProducao",
                columns: table => new
                {
                    ORD_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ORD_NUMERO_ORDEM_PRODUCAO = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ORD_QUANTIDADE = table.Column<int>(type: "int", nullable: true),
                    ORD_STATUS = table.Column<sbyte>(type: "tinyint", nullable: true),
                    Cliente_CLI_ID = table.Column<long>(type: "bigint", nullable: true),
                    Produto_PRO_ID = table.Column<long>(type: "bigint", nullable: true),
                    ORD_CRIADO_EM = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ORD_ID);
                    table.ForeignKey(
                        name: "fk_OrdemProducao_Cliente",
                        column: x => x.Cliente_CLI_ID,
                        principalTable: "Cliente",
                        principalColumn: "CLI_ID");
                    table.ForeignKey(
                        name: "fk_OrdemProducao_Produto1",
                        column: x => x.Produto_PRO_ID,
                        principalTable: "Produto",
                        principalColumn: "PRO_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Producao",
                columns: table => new
                {
                    PRD_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PRD_QUANTIDADE = table.Column<int>(type: "int", nullable: true),
                    Maquina_MAQ_ID = table.Column<long>(type: "bigint", nullable: true),
                    OrdemProducao_ORD_ID = table.Column<long>(type: "bigint", nullable: true),
                    PRD_CRIADO_EM = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.PRD_ID);
                    table.ForeignKey(
                        name: "fk_Producao_Maquina1",
                        column: x => x.Maquina_MAQ_ID,
                        principalTable: "Maquina",
                        principalColumn: "MAQ_ID");
                    table.ForeignKey(
                        name: "fk_Producao_OrdemProducao1",
                        column: x => x.OrdemProducao_ORD_ID,
                        principalTable: "OrdemProducao",
                        principalColumn: "ORD_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    VND_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VND_QUANTIDADE = table.Column<int>(type: "int", nullable: true),
                    VND_STATUS = table.Column<sbyte>(type: "tinyint", nullable: true),
                    OrdemProducao_ORD_ID = table.Column<long>(type: "bigint", nullable: true),
                    Produto_PRO_ID = table.Column<long>(type: "bigint", nullable: true),
                    Cliente_CLI_ID = table.Column<long>(type: "bigint", nullable: true),
                    VND_CRIADO_EM = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.VND_ID);
                    table.ForeignKey(
                        name: "fk_Venda_Cliente1",
                        column: x => x.Cliente_CLI_ID,
                        principalTable: "Cliente",
                        principalColumn: "CLI_ID");
                    table.ForeignKey(
                        name: "fk_Venda_OrdemProducao1",
                        column: x => x.OrdemProducao_ORD_ID,
                        principalTable: "OrdemProducao",
                        principalColumn: "ORD_ID");
                    table.ForeignKey(
                        name: "fk_Venda_Produto1",
                        column: x => x.Produto_PRO_ID,
                        principalTable: "Produto",
                        principalColumn: "PRO_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_OrdemProducao_Cliente_idx",
                table: "OrdemProducao",
                column: "Cliente_CLI_ID");

            migrationBuilder.CreateIndex(
                name: "fk_OrdemProducao_Produto1_idx",
                table: "OrdemProducao",
                column: "Produto_PRO_ID");

            migrationBuilder.CreateIndex(
                name: "fk_Producao_Maquina1_idx",
                table: "Producao",
                column: "Maquina_MAQ_ID");

            migrationBuilder.CreateIndex(
                name: "fk_Producao_OrdemProducao1_idx",
                table: "Producao",
                column: "OrdemProducao_ORD_ID");

            migrationBuilder.CreateIndex(
                name: "fk_Venda_Cliente1_idx",
                table: "Venda",
                column: "Cliente_CLI_ID");

            migrationBuilder.CreateIndex(
                name: "fk_Venda_OrdemProducao1_idx",
                table: "Venda",
                column: "OrdemProducao_ORD_ID");

            migrationBuilder.CreateIndex(
                name: "fk_Venda_Produto1_idx",
                table: "Venda",
                column: "Produto_PRO_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producao");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Maquina");

            migrationBuilder.DropTable(
                name: "OrdemProducao");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
