using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class init27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_AspNetUsers_ApplicationUserId",
                table: "Absences");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyLeaves_Absences_AbsenceId",
                table: "DailyLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_EnterInfo_Absences_AbsenceId",
                table: "EnterInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Todoes_AspNetUsers_ApplicationUserId",
                table: "Todoes");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_TodoItemCategory_TodoItemCategoryId",
                table: "TodoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_Todoes_TodoListId",
                table: "TodoItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoItems",
                table: "TodoItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Todoes",
                table: "Todoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absences",
                table: "Absences");

            migrationBuilder.RenameTable(
                name: "TodoItems",
                newName: "TodoItem");

            migrationBuilder.RenameTable(
                name: "Todoes",
                newName: "TodoList");

            migrationBuilder.RenameTable(
                name: "Absences",
                newName: "Absence");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItems_TodoListId",
                table: "TodoItem",
                newName: "IX_TodoItem_TodoListId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItems_TodoItemCategoryId",
                table: "TodoItem",
                newName: "IX_TodoItem_TodoItemCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Todoes_ApplicationUserId",
                table: "TodoList",
                newName: "IX_TodoList_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Absences_ApplicationUserId",
                table: "Absence",
                newName: "IX_Absence_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoItem",
                table: "TodoItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoList",
                table: "TodoList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absence",
                table: "Absence",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Absence_AspNetUsers_ApplicationUserId",
                table: "Absence",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyLeaves_Absence_AbsenceId",
                table: "DailyLeaves",
                column: "AbsenceId",
                principalTable: "Absence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnterInfo_Absence_AbsenceId",
                table: "EnterInfo",
                column: "AbsenceId",
                principalTable: "Absence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_TodoItemCategory_TodoItemCategoryId",
                table: "TodoItem",
                column: "TodoItemCategoryId",
                principalTable: "TodoItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_TodoList_TodoListId",
                table: "TodoItem",
                column: "TodoListId",
                principalTable: "TodoList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoList_AspNetUsers_ApplicationUserId",
                table: "TodoList",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absence_AspNetUsers_ApplicationUserId",
                table: "Absence");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyLeaves_Absence_AbsenceId",
                table: "DailyLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_EnterInfo_Absence_AbsenceId",
                table: "EnterInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_TodoItemCategory_TodoItemCategoryId",
                table: "TodoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_TodoList_TodoListId",
                table: "TodoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoList_AspNetUsers_ApplicationUserId",
                table: "TodoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoList",
                table: "TodoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoItem",
                table: "TodoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absence",
                table: "Absence");

            migrationBuilder.RenameTable(
                name: "TodoList",
                newName: "Todoes");

            migrationBuilder.RenameTable(
                name: "TodoItem",
                newName: "TodoItems");

            migrationBuilder.RenameTable(
                name: "Absence",
                newName: "Absences");

            migrationBuilder.RenameIndex(
                name: "IX_TodoList_ApplicationUserId",
                table: "Todoes",
                newName: "IX_Todoes_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItem_TodoListId",
                table: "TodoItems",
                newName: "IX_TodoItems_TodoListId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItem_TodoItemCategoryId",
                table: "TodoItems",
                newName: "IX_TodoItems_TodoItemCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Absence_ApplicationUserId",
                table: "Absences",
                newName: "IX_Absences_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todoes",
                table: "Todoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoItems",
                table: "TodoItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absences",
                table: "Absences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_AspNetUsers_ApplicationUserId",
                table: "Absences",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyLeaves_Absences_AbsenceId",
                table: "DailyLeaves",
                column: "AbsenceId",
                principalTable: "Absences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnterInfo_Absences_AbsenceId",
                table: "EnterInfo",
                column: "AbsenceId",
                principalTable: "Absences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Todoes_AspNetUsers_ApplicationUserId",
                table: "Todoes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_TodoItemCategory_TodoItemCategoryId",
                table: "TodoItems",
                column: "TodoItemCategoryId",
                principalTable: "TodoItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_Todoes_TodoListId",
                table: "TodoItems",
                column: "TodoListId",
                principalTable: "Todoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
