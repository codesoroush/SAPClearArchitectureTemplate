using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedUserId",
                table: "TodoItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TodoProgress",
                table: "TodoItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConnectionId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_AssignedUserId",
                table: "TodoItems",
                column: "AssignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_AspNetUsers_AssignedUserId",
                table: "TodoItems",
                column: "AssignedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_AspNetUsers_AssignedUserId",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_AssignedUserId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "TodoProgress",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConnectionId",
                table: "AspNetUsers");
        }
    }
}
