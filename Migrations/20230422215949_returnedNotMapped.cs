using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class returnedNotMapped : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SaveFiles");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "NPC");

            migrationBuilder.AddColumn<int>(
                name: "PlayerCharacterID",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID",
                principalTable: "PlayerCharacters",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "PlayerCharacterID",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SaveFiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
