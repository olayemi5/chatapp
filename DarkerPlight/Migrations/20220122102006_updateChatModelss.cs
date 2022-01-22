using Microsoft.EntityFrameworkCore.Migrations;

namespace DarkerPlight.Migrations
{
    public partial class updateChatModelss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Group",
                table: "Chats_tbl",
                newName: "GroupNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupNumber",
                table: "Chats_tbl",
                newName: "Group");
        }
    }
}
