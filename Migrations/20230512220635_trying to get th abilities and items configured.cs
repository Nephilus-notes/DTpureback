using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class tryingtogetthabilitiesanditemsconfigured : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ability_NPC_NPCID",
                table: "Ability");

            migrationBuilder.DropForeignKey(
                name: "FK_Ability_PlayerCharacters_PlayerCharacterID",
                table: "Ability");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropTable(
                name: "NPC");

            migrationBuilder.DropIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Ability_NPCID",
                table: "Ability");

            migrationBuilder.DropIndex(
                name: "IX_Ability_PlayerCharacterID",
                table: "Ability");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerCharacters",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "NPCID",
                table: "Ability");

            migrationBuilder.DropColumn(
                name: "PlayerCharacterID",
                table: "Ability");

            migrationBuilder.RenameTable(
                name: "PlayerCharacters",
                newName: "Character");

            migrationBuilder.AlterColumn<int>(
                name: "WebOfDepthsExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ThagragsHopeExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "TailOfTheDragonExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "StrengthXP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "PlayersRespiteExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MaxMP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MaxHP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "LifeTimeCurrency",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "KratabsFollyExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "IntelligenceXP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "GraithsGrottoExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "GraithQueensLairExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "EquippedItems",
                table: "Character",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "DrippingDeathExplored",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DexterityXP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentMP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentHP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ConstitutionXP",
                table: "Character",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Character",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Character",
                table: "Character",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "PlayerCharacterAbilities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CharacterID = table.Column<int>(type: "integer", nullable: false),
                    AbilityID = table.Column<int>(type: "integer", nullable: false),
                    AbilityID1 = table.Column<int>(type: "integer", nullable: true),
                    CharacterID1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacterAbilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlayerCharacterAbilities_Ability_AbilityID",
                        column: x => x.AbilityID,
                        principalTable: "Ability",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCharacterAbilities_Ability_AbilityID1",
                        column: x => x.AbilityID1,
                        principalTable: "Ability",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PlayerCharacterAbilities_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCharacterAbilities_Character_CharacterID1",
                        column: x => x.CharacterID1,
                        principalTable: "Character",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PlayerCharacterItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CharacterID = table.Column<int>(type: "integer", nullable: false),
                    ItemID = table.Column<int>(type: "integer", nullable: false),
                    CharacterID1 = table.Column<int>(type: "integer", nullable: true),
                    ItemID1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacterItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlayerCharacterItems_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCharacterItems_Character_CharacterID1",
                        column: x => x.CharacterID1,
                        principalTable: "Character",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PlayerCharacterItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCharacterItems_Items_ItemID1",
                        column: x => x.ItemID1,
                        principalTable: "Items",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterAbilities_AbilityID",
                table: "PlayerCharacterAbilities",
                column: "AbilityID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterAbilities_AbilityID1",
                table: "PlayerCharacterAbilities",
                column: "AbilityID1");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterAbilities_CharacterID",
                table: "PlayerCharacterAbilities",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterAbilities_CharacterID1",
                table: "PlayerCharacterAbilities",
                column: "CharacterID1");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterItems_CharacterID",
                table: "PlayerCharacterItems",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterItems_CharacterID1",
                table: "PlayerCharacterItems",
                column: "CharacterID1");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterItems_ItemID",
                table: "PlayerCharacterItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacterItems_ItemID1",
                table: "PlayerCharacterItems",
                column: "ItemID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerCharacterAbilities");

            migrationBuilder.DropTable(
                name: "PlayerCharacterItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Character",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Character");

            migrationBuilder.RenameTable(
                name: "Character",
                newName: "PlayerCharacters");

            migrationBuilder.AddColumn<int>(
                name: "PlayerCharacterID",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NPCID",
                table: "Ability",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerCharacterID",
                table: "Ability",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WebOfDepthsExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ThagragsHopeExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TailOfTheDragonExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StrengthXP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlayersRespiteExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxMP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxHP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LifeTimeCurrency",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KratabsFollyExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IntelligenceXP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GraithsGrottoExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GraithQueensLairExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EquippedItems",
                table: "PlayerCharacters",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrippingDeathExplored",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DexterityXP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentMP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentHP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConstitutionXP",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerCharacters",
                table: "PlayerCharacters",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "NPC",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Armor = table.Column<int>(type: "integer", nullable: false),
                    ArmorValue = table.Column<int>(type: "integer", nullable: false),
                    Burning = table.Column<bool>(type: "boolean", nullable: false),
                    BurningBlades = table.Column<bool>(type: "boolean", nullable: false),
                    BurningBladesRounds = table.Column<int>(type: "integer", nullable: false),
                    BurningRounds = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    CurrentCurrency = table.Column<int>(type: "integer", nullable: false),
                    DamageValue = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Defended = table.Column<bool>(type: "boolean", nullable: false),
                    DefendingRounds = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    DoubleArmed = table.Column<bool>(type: "boolean", nullable: false),
                    DoubleArmedRounds = table.Column<int>(type: "integer", nullable: false),
                    EvadePercentage = table.Column<int>(type: "integer", nullable: false),
                    Evading = table.Column<bool>(type: "boolean", nullable: false),
                    EvadingRounds = table.Column<int>(type: "integer", nullable: false),
                    Fleeing = table.Column<bool>(type: "boolean", nullable: false),
                    FleeingRounds = table.Column<int>(type: "integer", nullable: false),
                    Focusing = table.Column<bool>(type: "boolean", nullable: false),
                    FocusingRounds = table.Column<int>(type: "integer", nullable: false),
                    HitByWind = table.Column<bool>(type: "boolean", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Poisoned = table.Column<bool>(type: "boolean", nullable: false),
                    PoisonedRounds = table.Column<int>(type: "integer", nullable: false),
                    Resistance = table.Column<int>(type: "integer", nullable: false),
                    Slowed = table.Column<bool>(type: "boolean", nullable: false),
                    SlowedRounds = table.Column<int>(type: "integer", nullable: false),
                    StoneArmored = table.Column<bool>(type: "boolean", nullable: false),
                    StoneArmoredRounds = table.Column<int>(type: "integer", nullable: false),
                    StoneFists = table.Column<bool>(type: "boolean", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Stunned = table.Column<bool>(type: "boolean", nullable: false),
                    Vulnerable = table.Column<bool>(type: "boolean", nullable: false),
                    VulnerableRounds = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPC", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_NPCID",
                table: "Ability",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_PlayerCharacterID",
                table: "Ability",
                column: "PlayerCharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ability_NPC_NPCID",
                table: "Ability",
                column: "NPCID",
                principalTable: "NPC",
                principalColumn: "ID");

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
    }
}
