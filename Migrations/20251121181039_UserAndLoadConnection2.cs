using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Updater.Migrations
{
    /// <inheritdoc />
    public partial class UserAndLoadConnection2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Load_Team_TeamId",
                table: "Load");

            migrationBuilder.DropIndex(
                name: "IX_Load_TeamId",
                table: "Load");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Load");

            migrationBuilder.AddColumn<string>(
                name: "BookedById",
                table: "Load",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Load_BookedById",
                table: "Load",
                column: "BookedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Load_AspNetUsers_BookedById",
                table: "Load",
                column: "BookedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Load_AspNetUsers_BookedById",
                table: "Load");

            migrationBuilder.DropIndex(
                name: "IX_Load_BookedById",
                table: "Load");

            migrationBuilder.DropColumn(
                name: "BookedById",
                table: "Load");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Load",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Load_TeamId",
                table: "Load",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Load_Team_TeamId",
                table: "Load",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id");
        }
    }
}
