using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class EquipmentToFKIDs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BodyItemID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HandItemID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeadItemID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "HandItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "HeadItemID",
                table: "PlayerCharacters");
        }
    }
}
