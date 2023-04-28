using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class FixedDoubleArmedRoundsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoubledArmedRounds",
                table: "PlayerCharacters",
                newName: "DoubleArmedRounds");

            migrationBuilder.RenameColumn(
                name: "DoubledArmedRounds",
                table: "NPC",
                newName: "DoubleArmedRounds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoubleArmedRounds",
                table: "PlayerCharacters",
                newName: "DoubledArmedRounds");

            migrationBuilder.RenameColumn(
                name: "DoubleArmedRounds",
                table: "NPC",
                newName: "DoubledArmedRounds");
        }
    }
}
