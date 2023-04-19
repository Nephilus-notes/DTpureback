using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class changedsavesbacktophoforeignkeywithPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_SaveFiles_ID",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Characters",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_SaveFiles_PlayerCharacterID",
                table: "SaveFiles",
                column: "PlayerCharacterID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SaveFiles_Characters_PlayerCharacterID",
                table: "SaveFiles",
                column: "PlayerCharacterID",
                principalTable: "Characters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaveFiles_Characters_PlayerCharacterID",
                table: "SaveFiles");

            migrationBuilder.DropIndex(
                name: "IX_SaveFiles_PlayerCharacterID",
                table: "SaveFiles");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Characters",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_SaveFiles_ID",
                table: "Characters",
                column: "ID",
                principalTable: "SaveFiles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
