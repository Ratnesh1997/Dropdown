using Microsoft.EntityFrameworkCore.Migrations;

namespace Dropdown.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "registrations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmPassword",
                table: "registrations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "c_id",
                table: "emp1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "s_id",
                table: "emp1s",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    c_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.c_id);
                });

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    s_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    s_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryc_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.s_id);
                    table.ForeignKey(
                        name: "FK_states_countries_countryc_id",
                        column: x => x.countryc_id,
                        principalTable: "countries",
                        principalColumn: "c_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emp1s_c_id",
                table: "emp1s",
                column: "c_id");

            migrationBuilder.CreateIndex(
                name: "IX_emp1s_s_id",
                table: "emp1s",
                column: "s_id");

            migrationBuilder.CreateIndex(
                name: "IX_states_countryc_id",
                table: "states",
                column: "countryc_id");

            migrationBuilder.AddForeignKey(
                name: "FK_emp1s_countries_c_id",
                table: "emp1s",
                column: "c_id",
                principalTable: "countries",
                principalColumn: "c_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_emp1s_states_s_id",
                table: "emp1s",
                column: "s_id",
                principalTable: "states",
                principalColumn: "s_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emp1s_countries_c_id",
                table: "emp1s");

            migrationBuilder.DropForeignKey(
                name: "FK_emp1s_states_s_id",
                table: "emp1s");

            migrationBuilder.DropTable(
                name: "states");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropIndex(
                name: "IX_emp1s_c_id",
                table: "emp1s");

            migrationBuilder.DropIndex(
                name: "IX_emp1s_s_id",
                table: "emp1s");

            migrationBuilder.DropColumn(
                name: "c_id",
                table: "emp1s");

            migrationBuilder.DropColumn(
                name: "s_id",
                table: "emp1s");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "registrations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmPassword",
                table: "registrations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
