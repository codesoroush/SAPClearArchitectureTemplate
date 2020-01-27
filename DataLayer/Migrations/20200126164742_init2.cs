using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todoes_AspNetUsers_ApplicationUserId1",
                table: "Todoes");

            migrationBuilder.DropIndex(
                name: "IX_Todoes_ApplicationUserId1",
                table: "Todoes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Todoes");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Todoes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Todoes_ApplicationUserId",
                table: "Todoes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todoes_AspNetUsers_ApplicationUserId",
                table: "Todoes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todoes_AspNetUsers_ApplicationUserId",
                table: "Todoes");

            migrationBuilder.DropIndex(
                name: "IX_Todoes_ApplicationUserId",
                table: "Todoes");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Todoes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Todoes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todoes_ApplicationUserId1",
                table: "Todoes",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Todoes_AspNetUsers_ApplicationUserId1",
                table: "Todoes",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
