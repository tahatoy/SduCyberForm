using Microsoft.EntityFrameworkCore.Migrations;

namespace SduCyberForm.Migrations
{
    public partial class addTableNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "CyberForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "CyberForm",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "CyberForm");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "CyberForm");
        }
    }
}
