using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestShop.Migrations
{
    public partial class UserQuestFluentApiRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersQuests_AspNetUsers_UserId",
                table: "UsersQuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersQuests",
                table: "UsersQuests");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UsersQuests",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "UserQuestId",
                table: "UsersQuests",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersQuests",
                table: "UsersQuests",
                column: "UserQuestId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersQuests_UserId",
                table: "UsersQuests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersQuests_AspNetUsers_UserId",
                table: "UsersQuests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersQuests_AspNetUsers_UserId",
                table: "UsersQuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersQuests",
                table: "UsersQuests");

            migrationBuilder.DropIndex(
                name: "IX_UsersQuests_UserId",
                table: "UsersQuests");

            migrationBuilder.DropColumn(
                name: "UserQuestId",
                table: "UsersQuests");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UsersQuests",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersQuests",
                table: "UsersQuests",
                columns: new[] { "UserId", "QuestId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersQuests_AspNetUsers_UserId",
                table: "UsersQuests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
