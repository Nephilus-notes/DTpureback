using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPCItemstoIEnumerableInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPlayerCharacter");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemIDs",
                table: "PlayerCharacters",
                type: "text",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacters_Items_ItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropIndex(
                name: "IX_PlayerCharacters_ItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "ItemIDs",
                table: "PlayerCharacters");

            migrationBuilder.CreateTable(
                name: "ItemPlayerCharacter",
                columns: table => new
                {
                    CharacterID = table.Column<int>(type: "integer", nullable: false),
                    ItemsID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPlayerCharacter", x => new { x.CharacterID, x.ItemsID });
                    table.ForeignKey(
                        name: "FK_ItemPlayerCharacter_Items_ItemsID",
                        column: x => x.ItemsID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPlayerCharacter_PlayerCharacters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "PlayerCharacters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPlayerCharacter_ItemsID",
                table: "ItemPlayerCharacter",
                column: "ItemsID");
        }
    }
}
