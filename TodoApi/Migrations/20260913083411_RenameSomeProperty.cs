using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.Migrations
{
    /// <inheritdoc />
    public partial class RenameSomeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAT",
                table: "Todos",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "IsCompleated",
                table: "Todos",
                newName: "IsCompleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Todos",
                newName: "CreatedAT");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Todos",
                newName: "IsCompleated");
        }
    }
}
