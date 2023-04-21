using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class newRelationshipswithSaveFileanduser : Migration
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
                        name: "FK_User_SaveFile",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    FocusingRounds = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    LifeTimeCurrency = table.Column<int>(type: "integer", nullable: true),
                    WeaponID = table.Column<int>(type: "integer", nullable: true),
                    StrengthXP = table.Column<int>(type: "integer", nullable: true),
                    DexterityXP = table.Column<int>(type: "integer", nullable: true),
                    IntelligenceXP = table.Column<int>(type: "integer", nullable: true),
                    ConstitutionXP = table.Column<int>(type: "integer", nullable: true),
                    MaxHP = table.Column<int>(type: "integer", nullable: true),
                    MaxMP = table.Column<int>(type: "integer", nullable: true),
                    CurrentHP = table.Column<int>(type: "integer", nullable: true),
                    CurrentMP = table.Column<int>(type: "integer", nullable: true),
                    CurrentLocation = table.Column<string>(type: "text", nullable: true),
                    KratabsFollyExplored = table.Column<int>(type: "integer", nullable: true),
                    DrippingDeathExplored = table.Column<int>(type: "integer", nullable: true),
                    PlayersRespiteExplored = table.Column<int>(type: "integer", nullable: true),
                    TailOfTheDragonExplored = table.Column<int>(type: "integer", nullable: true),
                    ThagragsHopeExplored = table.Column<int>(type: "integer", nullable: true),
                    WebOfDepthsExplored = table.Column<int>(type: "integer", nullable: true),
                    GraithsGrottoExplored = table.Column<int>(type: "integer", nullable: true),
                    GraithQueensLairExplored = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.ID);
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
                        name: "FK_Items_Characters_PlayerCharacterID",
                        column: x => x.PlayerCharacterID,
                        principalTable: "Characters",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_WeaponID",
                table: "Characters",
                column: "WeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_SaveFiles_UserID",
                table: "SaveFiles",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Items_WeaponID",
                table: "Characters",
                column: "WeaponID",
                principalTable: "Items",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Items_WeaponID",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "SaveFiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
