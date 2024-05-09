using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicStoreMVC.Migrations
{
    /// <inheritdoc />
    public partial class TabelaMusicaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "duracao",
                table: "Musica",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "titulo",
                table: "Musica",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "duracao",
                table: "Musica");

            migrationBuilder.DropColumn(
                name: "titulo",
                table: "Musica");
        }
    }
}
