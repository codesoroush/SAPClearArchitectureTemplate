using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class init33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "TodoItemCategory",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartWorkTime",
                table: "Company",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndWorkTime",
                table: "Company",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CompanyUserName",
                table: "Company",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoItemCategory_CompanyId",
                table: "TodoItemCategory",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                unique: true,
                filter: "[CompanyId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItemCategory_Company_CompanyId",
                table: "TodoItemCategory",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItemCategory_Company_CompanyId",
                table: "TodoItemCategory");

            migrationBuilder.DropIndex(
                name: "IX_TodoItemCategory_CompanyId",
                table: "TodoItemCategory");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "TodoItemCategory");

            migrationBuilder.DropColumn(
                name: "CompanyUserName",
                table: "Company");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartWorkTime",
                table: "Company",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndWorkTime",
                table: "Company",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");
        }
    }
}
