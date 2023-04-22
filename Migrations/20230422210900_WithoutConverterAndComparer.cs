using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class WithoutConverterAndComparer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Items",
                table: "PlayerCharacters");

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

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "PlayerCharacters",
                type: "text",
                nullable: true);
        }
    }
}
