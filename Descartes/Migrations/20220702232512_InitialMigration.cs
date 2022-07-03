using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Descartes.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataInserts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Position = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataInserts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataPairs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstId = table.Column<int>(type: "int", nullable: false),
                    SecondId = table.Column<int>(type: "int", nullable: false),
                    PairingResult = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPairs_DataInserts_FirstId",
                        column: x => x.FirstId,
                        principalTable: "DataInserts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DataPairs_DataInserts_SecondId",
                        column: x => x.SecondId,
                        principalTable: "DataInserts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataPairs_FirstId",
                table: "DataPairs",
                column: "FirstId");

            migrationBuilder.CreateIndex(
                name: "IX_DataPairs_SecondId",
                table: "DataPairs",
                column: "SecondId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataPairs");

            migrationBuilder.DropTable(
                name: "DataInserts");
        }
    }
}
