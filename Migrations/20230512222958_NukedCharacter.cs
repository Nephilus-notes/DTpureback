using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class NukedCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArmorValue",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Burning",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "BurningBlades",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "BurningBladesRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "BurningRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "DamageValue",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Defended",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "DefendingRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "DoubleArmed",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "DoubleArmedRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "EvadePercentage",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Evading",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "EvadingRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Fleeing",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "FleeingRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Focusing",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "FocusingRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "HitByWind",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Poisoned",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "PoisonedRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Slowed",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "SlowedRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "StoneArmored",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "StoneArmoredRounds",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "StoneFists",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Stunned",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Vulnerable",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "VulnerableRounds",
                table: "Character");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmorValue",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Burning",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BurningBlades",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BurningBladesRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BurningRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DamageValue",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Defended",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DefendingRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DoubleArmed",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DoubleArmedRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EvadePercentage",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Evading",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EvadingRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Fleeing",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "FleeingRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Focusing",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "FocusingRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HitByWind",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Poisoned",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PoisonedRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Slowed",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SlowedRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "StoneArmored",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StoneArmoredRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "StoneFists",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Stunned",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vulnerable",
                table: "Character",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VulnerableRounds",
                table: "Character",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
