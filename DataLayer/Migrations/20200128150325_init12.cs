using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Assigned",
                table: "Todoes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assigned",
                table: "Todoes");

            migrationBuilder.AddColumn<string>(
                name: "AssignedUserId",
                table: "TodoItems",
                type: "nvarchar(450)",
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
    }
}
