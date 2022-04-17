using Microsoft.EntityFrameworkCore.Migrations;

namespace Dropdown.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "emp1s");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "emp1s",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
