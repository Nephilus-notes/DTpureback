using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class CleanedSlate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EnterText = table.Column<string>(type: "text", nullable: false),
                    ExitText = table.Column<string>(type: "text", nullable: false),
                    MoveOptions = table.Column<string>(type: "text", nullable: true),
                    CommonNPC = table.Column<int>(type: "integer", nullable: true),
                    UncommonNPC = table.Column<int>(type: "integer", nullable: true),
                    RareNPC = table.Column<int>(type: "integer", nullable: true),
                    SecretNPC = table.Column<int>(type: "integer", nullable: true),
                    Next = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NPC",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CurrentCurrency = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Armor = table.Column<int>(type: "integer", nullable: false),
                    Resistance = table.Column<int>(type: "integer", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    ArmorValue = table.Column<int>(type: "integer", nullable: false),
                    EvadePercentage = table.Column<int>(type: "integer", nullable: false),
                    DamageValue = table.Column<int>(type: "integer", nullable: false),
                    Defended = table.Column<bool>(type: "boolean", nullable: false),
                    Evading = table.Column<bool>(type: "boolean", nullable: false),
                    Fleeing = table.Column<bool>(type: "boolean", nullable: false),
                    StoneArmored = table.Column<bool>(type: "boolean", nullable: false),
                    Slowed = table.Column<bool>(type: "boolean", nullable: false),
                    Vulnerable = table.Column<bool>(type: "boolean", nullable: false),
                    DoubleArmed = table.Column<bool>(type: "boolean", nullable: false),
                    BurningBlades = table.Column<bool>(type: "boolean", nullable: false),
                    StoneFists = table.Column<bool>(type: "boolean", nullable: false),
                    Poisoned = table.Column<bool>(type: "boolean", nullable: false),
                    Burning = table.Column<bool>(type: "boolean", nullable: false),
                    Focusing = table.Column<bool>(type: "boolean", nullable: false),
                    HitByWind = table.Column<bool>(type: "boolean", nullable: false),
                    Stunned = table.Column<bool>(type: "boolean", nullable: false),
                    DefendingFounds = table.Column<int>(type: "integer", nullable: false),
                    EvadingRounds = table.Column<int>(type: "integer", nullable: false),
                    FleeingRounds = table.Column<int>(type: "integer", nullable: false),
                    SlowedRounds = table.Column<int>(type: "integer", nullable: false),
                    VulnerableRounds = table.Column<int>(type: "integer", nullable: false),
                    StoneArmoredRounds = table.Column<int>(type: "integer", nullable: false),
                    DoubledArmedRounds = table.Column<int>(type: "integer", nullable: false),
                    BurningBladesRounds = table.Column<int>(type: "integer", nullable: false),
                    BurningRounds = table.Column<int>(type: "integer", nullable: false),
                    PoisonedRounds = table.Column<int>(type: "integer", nullable: false),
                    FocusingRounds = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPC", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LifeTimeCurrency = table.Column<int>(type: "integer", nullable: false),
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
                    GraithQueensLairExplored = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CurrentCurrency = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Armor = table.Column<int>(type: "integer", nullable: false),
                    Resistance = table.Column<int>(type: "integer", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    ArmorValue = table.Column<int>(type: "integer", nullable: false),
                    EvadePercentage = table.Column<int>(type: "integer", nullable: false),
                    DamageValue = table.Column<int>(type: "integer", nullable: false),
                    Defended = table.Column<bool>(type: "boolean", nullable: false),
                    Evading = table.Column<bool>(type: "boolean", nullable: false),
                    Fleeing = table.Column<bool>(type: "boolean", nullable: false),
                    StoneArmored = table.Column<bool>(type: "boolean", nullable: false),
                    Slowed = table.Column<bool>(type: "boolean", nullable: false),
                    Vulnerable = table.Column<bool>(type: "boolean", nullable: false),
                    DoubleArmed = table.Column<bool>(type: "boolean", nullable: false),
                    BurningBlades = table.Column<bool>(type: "boolean", nullable: false),
                    StoneFists = table.Column<bool>(type: "boolean", nullable: false),
                    Poisoned = table.Column<bool>(type: "boolean", nullable: false),
                    Burning = table.Column<bool>(type: "boolean", nullable: false),
                    Focusing = table.Column<bool>(type: "boolean", nullable: false),
                    HitByWind = table.Column<bool>(type: "boolean", nullable: false),
                    Stunned = table.Column<bool>(type: "boolean", nullable: false),
                    DefendingFounds = table.Column<int>(type: "integer", nullable: false),
                    EvadingRounds = table.Column<int>(type: "integer", nullable: false),
                    FleeingRounds = table.Column<int>(type: "integer", nullable: false),
                    SlowedRounds = table.Column<int>(type: "integer", nullable: false),
                    VulnerableRounds = table.Column<int>(type: "integer", nullable: false),
                    StoneArmoredRounds = table.Column<int>(type: "integer", nullable: false),
                    DoubledArmedRounds = table.Column<int>(type: "integer", nullable: false),
                    BurningBladesRounds = table.Column<int>(type: "integer", nullable: false),
                    BurningRounds = table.Column<int>(type: "integer", nullable: false),
                    PoisonedRounds = table.Column<int>(type: "integer", nullable: false),
                    FocusingRounds = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    ItemStat = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Slot = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PlayerCharacterID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                        column: x => x.PlayerCharacterID,
                        principalTable: "PlayerCharacters",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SaveFiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<int>(type: "integer", nullable: false),
                    PlayerCharacterID = table.Column<int>(type: "integer", nullable: false),
                    LocationID = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveFiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SaveFiles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_SaveFiles_UserID",
                table: "SaveFiles",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "NPC");

            migrationBuilder.DropTable(
                name: "SaveFiles");

            migrationBuilder.DropTable(
                name: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
