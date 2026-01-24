using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Updater.Migrations
{
    /// <inheritdoc />
    public partial class UserAndLoadConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Team",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_UserId",
                table: "Team",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_AspNetUsers_UserId",
                table: "Team",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_AspNetUsers_UserId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_UserId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Team");
        }
    }
}
