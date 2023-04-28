using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class FixedDefendingRoundsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefendingFounds",
                table: "PlayerCharacters",
                newName: "DefendingRounds");

            migrationBuilder.RenameColumn(
                name: "DefendingFounds",
                table: "NPC",
                newName: "DefendingRounds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefendingRounds",
                table: "PlayerCharacters",
                newName: "DefendingFounds");

            migrationBuilder.RenameColumn(
                name: "DefendingRounds",
                table: "NPC",
                newName: "DefendingFounds");
        }
    }
}
