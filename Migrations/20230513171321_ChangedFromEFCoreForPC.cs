using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class ChangedFromEFCoreForPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacterAbilities_Ability_AbilityID",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacterAbilities_Ability_AbilityID1",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacterAbilities_Character_CharacterID",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacterAbilities_Character_CharacterID1",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropTable(
                name: "PlayerCharacterItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerCharacterAbilities",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropIndex(
                name: "IX_PlayerCharacterAbilities_AbilityID1",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropIndex(
                name: "IX_PlayerCharacterAbilities_CharacterID1",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropColumn(
                name: "AbilityID1",
                table: "PlayerCharacterAbilities");

            migrationBuilder.DropColumn(
                name: "CharacterID1",
                table: "PlayerCharacterAbilities");

            migrationBuilder.RenameTable(
                name: "PlayerCharacterAbilities",
                newName: "CharacterAbility");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerCharacterAbilities_CharacterID",
                table: "CharacterAbility",
                newName: "IX_CharacterAbility_CharacterID");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerCharacterAbilities_AbilityID",
                table: "CharacterAbility",
                newName: "IX_CharacterAbility_AbilityID");

            migrationBuilder.AddColumn<string>(
                name: "Abilities",
                table: "Character",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "Character",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterAbility",
                table: "CharacterAbility",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterAbility_Ability_AbilityID",
                table: "CharacterAbility",
                column: "AbilityID",
                principalTable: "Ability",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterAbility_Character_CharacterID",
                table: "CharacterAbility",
                column: "CharacterID",
                principalTable: "Character",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterAbility_Ability_AbilityID",
                table: "CharacterAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterAbility_Character_CharacterID",
                table: "CharacterAbility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterAbility",
                table: "CharacterAbility");

            migrationBuilder.DropColumn(
                name: "Abilities",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Items",
                table: "Character");

            migrationBuilder.RenameTable(
                name: "CharacterAbility",
                newName: "PlayerCharacterAbilities");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterAbility_CharacterID",
                table: "PlayerCharacterAbilities",
                newName: "IX_PlayerCharacterAbilities_CharacterID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterAbility_AbilityID",
                table: "PlayerCharacterAbilities",
                newName: "IX_PlayerCharacterAbilities_AbilityID");

            migrationBuilder.AddColumn<int>(
                name: "AbilityID1",
                table: "PlayerCharacterAbilities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterID1",
                table: "PlayerCharacterAbilities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerCharacterAbilities",
                table: "PlayerCharacterAbilities",
                column: "ID");

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
                name: "IX_PlayerCharacterAbilities_AbilityID1",
                table: "PlayerCharacterAbilities",
                column: "AbilityID1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacterAbilities_Ability_AbilityID",
                table: "PlayerCharacterAbilities",
                column: "AbilityID",
                principalTable: "Ability",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacterAbilities_Ability_AbilityID1",
                table: "PlayerCharacterAbilities",
                column: "AbilityID1",
                principalTable: "Ability",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacterAbilities_Character_CharacterID",
                table: "PlayerCharacterAbilities",
                column: "CharacterID",
                principalTable: "Character",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacterAbilities_Character_CharacterID1",
                table: "PlayerCharacterAbilities",
                column: "CharacterID1",
                principalTable: "Character",
                principalColumn: "ID");
        }
    }
}
