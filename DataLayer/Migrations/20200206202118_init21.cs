using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class init21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TodoItemCategoryId",
                table: "TodoItems",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TodoItemCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ColorCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItemCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_TodoItemCategoryId",
                table: "TodoItems",
                column: "TodoItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_TodoItemCategory_TodoItemCategoryId",
                table: "TodoItems",
                column: "TodoItemCategoryId",
                principalTable: "TodoItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_TodoItemCategory_TodoItemCategoryId",
                table: "TodoItems");

            migrationBuilder.DropTable(
                name: "TodoItemCategory");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_TodoItemCategoryId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "TodoItemCategoryId",
                table: "TodoItems");
        }
    }
}
