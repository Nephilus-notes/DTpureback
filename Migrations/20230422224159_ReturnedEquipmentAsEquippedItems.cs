using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class ReturnedEquipmentAsEquippedItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyItem",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "HandItem",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "HeadItem",
                table: "PlayerCharacters");

            migrationBuilder.AddColumn<string>(
                name: "EquippedItems",
                table: "PlayerCharacters",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquippedItems",
                table: "PlayerCharacters");

            migrationBuilder.AddColumn<string>(
                name: "BodyItem",
                table: "PlayerCharacters",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandItem",
                table: "PlayerCharacters",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadItem",
                table: "PlayerCharacters",
                type: "text",
                nullable: true);
        }
    }
}
