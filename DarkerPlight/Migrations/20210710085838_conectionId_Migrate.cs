using Microsoft.EntityFrameworkCore.Migrations;

namespace DarkerPlight.Migrations
{
    public partial class conectionId_Migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastConnectionId",
                table: "users_tbl",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastConnectionId",
                table: "users_tbl");
        }
    }
}
