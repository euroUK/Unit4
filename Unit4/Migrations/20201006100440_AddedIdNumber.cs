using Microsoft.EntityFrameworkCore.Migrations;

namespace Unit4.Migrations
{
    public partial class AddedIdNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                schema: "dbo",
                table: "Student",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdNumber",
                schema: "dbo",
                table: "Student");
        }
    }
}
