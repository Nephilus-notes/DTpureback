using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class MakingSureWeAreUpToDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_Character_ID",
                table: "NPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacters_Character_ID",
                table: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NPCs",
                table: "NPCs");

            migrationBuilder.RenameTable(
                name: "NPCs",
                newName: "NPC");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Abilities",
                table: "PlayerCharacters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Armor",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constitution",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentCurrency",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "PlayerCharacters",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "PlayerCharacters",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Dexterity",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "PlayerCharacters",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PlayerCharacters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Resistance",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "NPC",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Abilities",
                table: "NPC",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Armor",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constitution",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentCurrency",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "NPC",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "NPC",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Dexterity",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "NPC",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "NPC",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Resistance",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "NPC",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NPC",
                table: "NPC",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NPC",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Abilities",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Armor",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Constitution",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "CurrentCurrency",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Dexterity",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Items",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Resistance",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Abilities",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Armor",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Constitution",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "CurrentCurrency",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Dexterity",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Items",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Resistance",
                table: "NPC");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "NPC");

            migrationBuilder.RenameTable(
                name: "NPC",
                newName: "NPCs");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "PlayerCharacters",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "NPCs",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NPCs",
                table: "NPCs",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Abilities = table.Column<string>(type: "text", nullable: false),
                    Armor = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    CurrentCurrency = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Items = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Resistance = table.Column<int>(type: "integer", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_Character_ID",
                table: "NPCs",
                column: "ID",
                principalTable: "Character",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacters_Character_ID",
                table: "PlayerCharacters",
                column: "ID",
                principalTable: "Character",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
