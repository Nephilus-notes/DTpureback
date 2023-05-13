using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class ChangedAbilityToAbilityIDOnNPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterDefault_Ability_AbilityID",
                table: "CharacterDefault");

            migrationBuilder.DropTable(
                name: "CharacterAbility");

            migrationBuilder.DropIndex(
                name: "IX_CharacterDefault_AbilityID",
                table: "CharacterDefault");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterAbility",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AbilityID = table.Column<int>(type: "integer", nullable: false),
                    CharacterID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAbility", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Ability_AbilityID",
                        column: x => x.AbilityID,
                        principalTable: "Ability",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDefault_AbilityID",
                table: "CharacterDefault",
                column: "AbilityID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_AbilityID",
                table: "CharacterAbility",
                column: "AbilityID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_CharacterID",
                table: "CharacterAbility",
                column: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterDefault_Ability_AbilityID",
                table: "CharacterDefault",
                column: "AbilityID",
                principalTable: "Ability",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
