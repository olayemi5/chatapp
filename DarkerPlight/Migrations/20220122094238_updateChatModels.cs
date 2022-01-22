using Microsoft.EntityFrameworkCore.Migrations;

namespace DarkerPlight.Migrations
{
    public partial class updateChatModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "Chats_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsGroup",
                table: "Chats_tbl",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Chats_tbl");

            migrationBuilder.DropColumn(
                name: "IsGroup",
                table: "Chats_tbl");
        }
    }
}
