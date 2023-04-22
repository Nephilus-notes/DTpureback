using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class AdjustedPCforDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacters_Items_WeaponID",
                table: "PlayerCharacters");

            migrationBuilder.DropIndex(
                name: "IX_PlayerCharacters_WeaponID",
                table: "PlayerCharacters");

            migrationBuilder.DropIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WeaponID",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "PlayerCharacterID",
                table: "Items");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPlayerCharacter");

            migrationBuilder.AddColumn<int>(
                name: "WeaponID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerCharacterID",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_WeaponID",
                table: "PlayerCharacters",
                column: "WeaponID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacters_Items_WeaponID",
                table: "PlayerCharacters",
                column: "WeaponID",
                principalTable: "Items",
                principalColumn: "ID");
        }
    }
}
