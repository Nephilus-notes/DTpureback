using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class removedFKfromModelBuilderForItemAndAbility : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Items",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "PlayerCharacterID",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Ability",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "PlayerCharacterID",
                table: "Ability",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_PlayerCharacterID",
                table: "Ability",
                column: "PlayerCharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ability_PlayerCharacters_PlayerCharacterID",
                table: "Ability",
                column: "PlayerCharacterID",
                principalTable: "PlayerCharacters",
                principalColumn: "ID");

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
                name: "FK_Ability_PlayerCharacters_PlayerCharacterID",
                table: "Ability");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Ability_PlayerCharacterID",
                table: "Ability");

            migrationBuilder.DropColumn(
                name: "PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "PlayerCharacterID",
                table: "Ability");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Items",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Ability",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
    }
}
