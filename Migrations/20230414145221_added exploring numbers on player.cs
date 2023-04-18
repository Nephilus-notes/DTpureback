using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTpureback.Migrations
{
    /// <inheritdoc />
    public partial class addedexploringnumbersonplayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrippingDeathExplored",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GraithQueensLairExplored",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GraithsGrottoExplored",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KratabsFollyExplored",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayersRespiteExplored",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TailOfTheDragonExplored",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThagragsHopeExplored",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WebOfDepthsExplored",
                table: "Characters",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrippingDeathExplored",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "GraithQueensLairExplored",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "GraithsGrottoExplored",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "KratabsFollyExplored",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PlayersRespiteExplored",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "TailOfTheDragonExplored",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ThagragsHopeExplored",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "WebOfDepthsExplored",
                table: "Characters");
        }
    }
}
