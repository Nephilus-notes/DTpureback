using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class DbFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnterText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExitText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Next = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SaveFiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PlayerCharacterID = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveFiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SaveFiles_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentCurrency = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    Resistance = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    MaxHP = table.Column<int>(type: "int", nullable: false),
                    MaxMP = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    WeaponDamage = table.Column<int>(type: "int", nullable: false),
                    CurrentHP = table.Column<int>(type: "int", nullable: false),
                    CurrentMP = table.Column<int>(type: "int", nullable: false),
                    ArmorValue = table.Column<int>(type: "int", nullable: false),
                    ResistanceValue = table.Column<int>(type: "int", nullable: false),
                    EvadePercentage = table.Column<int>(type: "int", nullable: false),
                    AttackValue = table.Column<int>(type: "int", nullable: false),
                    DamageValue = table.Column<int>(type: "int", nullable: false),
                    Defended = table.Column<bool>(type: "bit", nullable: false),
                    Evading = table.Column<bool>(type: "bit", nullable: false),
                    Fleeing = table.Column<bool>(type: "bit", nullable: false),
                    StoneArmored = table.Column<bool>(type: "bit", nullable: false),
                    Slowed = table.Column<bool>(type: "bit", nullable: false),
                    Vulnerable = table.Column<bool>(type: "bit", nullable: false),
                    DoubleArmed = table.Column<bool>(type: "bit", nullable: false),
                    BurningBlades = table.Column<bool>(type: "bit", nullable: false),
                    StoneFists = table.Column<bool>(type: "bit", nullable: false),
                    Poisoned = table.Column<bool>(type: "bit", nullable: false),
                    Burning = table.Column<bool>(type: "bit", nullable: false),
                    Focusing = table.Column<bool>(type: "bit", nullable: false),
                    HitByWind = table.Column<bool>(type: "bit", nullable: false),
                    Stunned = table.Column<bool>(type: "bit", nullable: false),
                    DefendingFounds = table.Column<int>(type: "int", nullable: false),
                    EvadingRounds = table.Column<int>(type: "int", nullable: false),
                    FleeingRounds = table.Column<int>(type: "int", nullable: false),
                    SlowedRounds = table.Column<int>(type: "int", nullable: false),
                    VulnerableRounds = table.Column<int>(type: "int", nullable: false),
                    StoneArmoredRounds = table.Column<int>(type: "int", nullable: false),
                    DoubledArmedRounds = table.Column<int>(type: "int", nullable: false),
                    BurningBladesRounds = table.Column<int>(type: "int", nullable: false),
                    BurningRounds = table.Column<int>(type: "int", nullable: false),
                    PoisonedRounds = table.Column<int>(type: "int", nullable: false),
                    FocusingRounds = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LifeTimeCurrency = table.Column<int>(type: "int", nullable: true),
                    WeaponID = table.Column<int>(type: "int", nullable: true),
                    StrengthXP = table.Column<int>(type: "int", nullable: true),
                    DexterityXP = table.Column<int>(type: "int", nullable: true),
                    IntelligenceXP = table.Column<int>(type: "int", nullable: true),
                    ConstitutionXP = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemStat = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Slot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerCharacterID = table.Column<int>(type: "int", nullable: true)
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
                name: "User");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
