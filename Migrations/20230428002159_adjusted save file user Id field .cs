using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class adjustedsavefileuserIdfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaveFiles_Users_UserID",
                table: "SaveFiles");

            migrationBuilder.DropIndex(
                name: "IX_SaveFiles_UserID",
                table: "SaveFiles");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "SaveFiles",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "SaveFiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SaveFiles_UserID1",
                table: "SaveFiles",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_SaveFiles_Users_UserID1",
                table: "SaveFiles",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaveFiles_Users_UserID1",
                table: "SaveFiles");

            migrationBuilder.DropIndex(
                name: "IX_SaveFiles_UserID1",
                table: "SaveFiles");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "SaveFiles");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "SaveFiles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_SaveFiles_UserID",
                table: "SaveFiles",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_SaveFiles_Users_UserID",
                table: "SaveFiles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
