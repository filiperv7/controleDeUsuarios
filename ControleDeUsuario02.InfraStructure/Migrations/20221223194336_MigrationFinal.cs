using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeUsuario02.InfraStructure.Migrations
{
    public partial class MigrationFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReembolsosDeslocamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoInicial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoFinal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KmDeslocado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReembolsosDeslocamento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReembolsosDeslocamento");
        }
    }
}
