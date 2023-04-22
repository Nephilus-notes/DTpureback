using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class FunWithJSon : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "PlayerCharacters",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
