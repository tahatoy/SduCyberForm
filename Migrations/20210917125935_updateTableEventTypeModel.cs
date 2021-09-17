using Microsoft.EntityFrameworkCore.Migrations;

namespace SduCyberForm.Migrations
{
    public partial class updateTableEventTypeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VeriSaldırı",
                table: "EventTypeModel",
                newName: "VeriSaldiri");

            migrationBuilder.RenameColumn(
                name: "VeriKaybı",
                table: "EventTypeModel",
                newName: "VeriKaybi");

            migrationBuilder.RenameColumn(
                name: "KisiselKotuKullanım",
                table: "EventTypeModel",
                newName: "KisiselKotuKullanim");

            migrationBuilder.RenameColumn(
                name: "Dolandırıcılık",
                table: "EventTypeModel",
                newName: "Dolandiricilik");

            migrationBuilder.RenameColumn(
                name: "CihazKaybı",
                table: "EventTypeModel",
                newName: "CihazKaybi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VeriSaldiri",
                table: "EventTypeModel",
                newName: "VeriSaldırı");

            migrationBuilder.RenameColumn(
                name: "VeriKaybi",
                table: "EventTypeModel",
                newName: "VeriKaybı");

            migrationBuilder.RenameColumn(
                name: "KisiselKotuKullanim",
                table: "EventTypeModel",
                newName: "KisiselKotuKullanım");

            migrationBuilder.RenameColumn(
                name: "Dolandiricilik",
                table: "EventTypeModel",
                newName: "Dolandırıcılık");

            migrationBuilder.RenameColumn(
                name: "CihazKaybi",
                table: "EventTypeModel",
                newName: "CihazKaybı");
        }
    }
}
