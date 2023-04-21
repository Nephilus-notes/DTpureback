using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class droppedcharactertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Items_WeaponID",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Characters_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "PlayerCharacters");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_WeaponID",
                table: "PlayerCharacters",
                newName: "IX_PlayerCharacters_WeaponID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID",
                principalTable: "PlayerCharacters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacters_Items_WeaponID",
                table: "PlayerCharacters",
                column: "WeaponID",
                principalTable: "Items",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_PlayerCharacters_PlayerCharacterID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacters_Items_WeaponID",
                table: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "NPC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerCharacters",
                table: "PlayerCharacters");

            migrationBuilder.RenameTable(
                name: "PlayerCharacters",
                newName: "Characters");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerCharacters_WeaponID",
                table: "Characters",
                newName: "IX_Characters_WeaponID");

            migrationBuilder.AlterColumn<int>(
                name: "WebOfDepthsExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ThagragsHopeExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "TailOfTheDragonExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "StrengthXP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "PlayersRespiteExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MaxMP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MaxHP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "LifeTimeCurrency",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "KratabsFollyExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "IntelligenceXP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "GraithsGrottoExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "GraithQueensLairExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DrippingDeathExplored",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DexterityXP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentMP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentHP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ConstitutionXP",
                table: "Characters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Characters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Items_WeaponID",
                table: "Characters",
                column: "WeaponID",
                principalTable: "Items",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Characters_PlayerCharacterID",
                table: "Items",
                column: "PlayerCharacterID",
                principalTable: "Characters",
                principalColumn: "ID");
        }
    }
}
