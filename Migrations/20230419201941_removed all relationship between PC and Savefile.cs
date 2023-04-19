using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class removedallrelationshipbetweenPCandSavefile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaveFiles_Characters_PlayerCharacterID",
                table: "SaveFiles");

            migrationBuilder.DropIndex(
                name: "IX_SaveFiles_PlayerCharacterID",
                table: "SaveFiles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SaveFiles_PlayerCharacterID",
                table: "SaveFiles",
                column: "PlayerCharacterID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SaveFiles_Characters_PlayerCharacterID",
                table: "SaveFiles",
                column: "PlayerCharacterID",
                principalTable: "Characters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
