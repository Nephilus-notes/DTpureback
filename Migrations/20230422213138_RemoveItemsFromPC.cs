using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class RemoveItemsFromPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
