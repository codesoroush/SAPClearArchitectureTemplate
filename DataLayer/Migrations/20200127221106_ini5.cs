using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class ini5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_AspNetUsers_ApplicationUserId1",
                table: "Absences");

            migrationBuilder.DropIndex(
                name: "IX_Absences_ApplicationUserId1",
                table: "Absences");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Absences");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Entry",
                table: "Absences",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Absences",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_ApplicationUserId",
                table: "Absences",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_AspNetUsers_ApplicationUserId",
                table: "Absences",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_AspNetUsers_ApplicationUserId",
                table: "Absences");

            migrationBuilder.DropIndex(
                name: "IX_Absences_ApplicationUserId",
                table: "Absences");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Entry",
                table: "Absences",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Absences",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Absences",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Absences_ApplicationUserId1",
                table: "Absences",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_AspNetUsers_ApplicationUserId1",
                table: "Absences",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
