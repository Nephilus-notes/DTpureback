using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class removednotmappedaddedtotablefornpcandpc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConstitutionXP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "CurrentHP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "CurrentMP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "DexterityXP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "DrippingDeathExplored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "EquippedItems",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "GraithQueensLairExplored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "GraithsGrottoExplored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "IntelligenceXP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "KratabsFollyExplored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "LifeTimeCurrency",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "MaxHP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "MaxMP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "PlayersRespiteExplored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "StrengthXP",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "TailOfTheDragonExplored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "ThagragsHopeExplored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "WebOfDepthsExplored",
                table: "Character");

            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NPCs_Character_ID",
                        column: x => x.ID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false),
                    LifeTimeCurrency = table.Column<int>(type: "integer", nullable: false),
                    EquippedItems = table.Column<string>(type: "text", nullable: false),
                    StrengthXP = table.Column<int>(type: "integer", nullable: false),
                    DexterityXP = table.Column<int>(type: "integer", nullable: false),
                    IntelligenceXP = table.Column<int>(type: "integer", nullable: false),
                    ConstitutionXP = table.Column<int>(type: "integer", nullable: false),
                    MaxHP = table.Column<int>(type: "integer", nullable: false),
                    MaxMP = table.Column<int>(type: "integer", nullable: false),
                    CurrentHP = table.Column<int>(type: "integer", nullable: false),
                    CurrentMP = table.Column<int>(type: "integer", nullable: false),
                    CurrentLocation = table.Column<string>(type: "text", nullable: true),
                    KratabsFollyExplored = table.Column<int>(type: "integer", nullable: false),
                    DrippingDeathExplored = table.Column<int>(type: "integer", nullable: false),
                    PlayersRespiteExplored = table.Column<int>(type: "integer", nullable: false),
                    TailOfTheDragonExplored = table.Column<int>(type: "integer", nullable: false),
                    ThagragsHopeExplored = table.Column<int>(type: "integer", nullable: false),
                    WebOfDepthsExplored = table.Column<int>(type: "integer", nullable: false),
                    GraithsGrottoExplored = table.Column<int>(type: "integer", nullable: false),
                    GraithQueensLairExplored = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Character_ID",
                        column: x => x.ID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NPCs");

            migrationBuilder.DropTable(
                name: "PlayerCharacters");

            migrationBuilder.AddColumn<int>(
                name: "ConstitutionXP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentHP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "Character",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentMP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DexterityXP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Character",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DrippingDeathExplored",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquippedItems",
                table: "Character",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GraithQueensLairExplored",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GraithsGrottoExplored",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceXP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KratabsFollyExplored",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LifeTimeCurrency",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxHP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxMP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayersRespiteExplored",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StrengthXP",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TailOfTheDragonExplored",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThagragsHopeExplored",
                table: "Character",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WebOfDepthsExplored",
                table: "Character",
                type: "integer",
                nullable: true);
        }
    }
}
