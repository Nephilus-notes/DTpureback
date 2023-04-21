using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class simplifiedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_SaveFile",
                table: "SaveFiles");

            migrationBuilder.AddForeignKey(
                name: "FK_SaveFiles_Users_UserID",
                table: "SaveFiles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaveFiles_Users_UserID",
                table: "SaveFiles");

            migrationBuilder.AddForeignKey(
                name: "FK_User_SaveFile",
                table: "SaveFiles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
