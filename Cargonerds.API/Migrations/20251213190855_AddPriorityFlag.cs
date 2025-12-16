using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cargonerds.API.Migrations
{
    /// <inheritdoc />
    public partial class AddPriorityFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPriority",
                table: "Shipments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPriority",
                table: "Shipments");
        }
    }
}
