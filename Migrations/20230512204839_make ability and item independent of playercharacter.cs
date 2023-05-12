using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class makeabilityanditemindependentofplayercharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ability_PlayerCharacters_ID",
                table: "Ability");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_PlayerCharacters_ID",
                table: "Items");

            migrationBuilder.AddForeignKey(
                name: "FK_Ability_PlayerCharacters_ID",
                table: "Ability",
                column: "ID",
                principalTable: "PlayerCharacters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PlayerCharacters_ID",
                table: "Items",
                column: "ID",
                principalTable: "PlayerCharacters",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ability_PlayerCharacters_ID",
                table: "Ability");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_PlayerCharacters_ID",
                table: "Items");

            migrationBuilder.AddForeignKey(
                name: "FK_Ability_PlayerCharacters_ID",
                table: "Ability",
                column: "ID",
                principalTable: "PlayerCharacters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PlayerCharacters_ID",
                table: "Items",
                column: "ID",
                principalTable: "PlayerCharacters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
