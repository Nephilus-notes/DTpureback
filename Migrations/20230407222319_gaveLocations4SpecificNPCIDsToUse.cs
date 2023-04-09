using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class gaveLocations4SpecificNPCIDsToUse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NPCOptions",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "CommonNPC",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RareNPC",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecretNPC",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UncommonNPC",
                table: "Locations",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommonNPC",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "RareNPC",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "SecretNPC",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "UncommonNPC",
                table: "Locations");

            migrationBuilder.AddColumn<string>(
                name: "NPCOptions",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
