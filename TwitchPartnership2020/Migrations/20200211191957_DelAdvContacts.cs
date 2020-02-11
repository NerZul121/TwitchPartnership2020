using Microsoft.EntityFrameworkCore.Migrations;

namespace TwitchPartnership2020.Migrations
{
    public partial class DelAdvContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Advertiser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Advertiser",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
