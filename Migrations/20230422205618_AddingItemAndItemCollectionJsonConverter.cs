using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class AddingItemAndItemCollectionJsonConverter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacters_Items_ItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropIndex(
                name: "IX_PlayerCharacters_ItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "BodyItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "HandItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "HeadItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PlayerCharacters");

            migrationBuilder.RenameColumn(
                name: "ItemIDs",
                table: "PlayerCharacters",
                newName: "Items");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Items",
                table: "PlayerCharacters",
                newName: "ItemIDs");

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

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_ItemID",
                table: "PlayerCharacters",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacters_Items_ItemID",
                table: "PlayerCharacters",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "ID");
        }
    }
}
