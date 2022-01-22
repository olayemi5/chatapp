using Microsoft.EntityFrameworkCore.Migrations;

namespace DarkerPlight.Migrations
{
    public partial class updateChatModelsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SentBy",
                table: "Chats_tbl",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SentBy",
                table: "Chats_tbl");
        }
    }
}
