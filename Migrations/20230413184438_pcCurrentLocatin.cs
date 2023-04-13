using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class pcCurrentLocatin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "currentLocation",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "currentLocation",
                table: "Characters");
        }
    }
}
