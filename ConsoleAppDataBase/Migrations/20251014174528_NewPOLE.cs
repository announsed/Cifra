using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppDataBase.Migrations
{
    /// <inheritdoc />
    public partial class NewPOLE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Parrents",
                table: "person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parrents",
                table: "person");
        }
    }
}
