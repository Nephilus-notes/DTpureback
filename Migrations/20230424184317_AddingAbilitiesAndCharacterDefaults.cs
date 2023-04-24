using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class AddingAbilitiesAndCharacterDefaults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Effect = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AffectedAttribute = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterDefault",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    Job = table.Column<string>(type: "text", nullable: false),
                    AbilityID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDefault", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "CharacterDefault");
        }
    }
}
