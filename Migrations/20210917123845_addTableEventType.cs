using Microsoft.EntityFrameworkCore.Migrations;

namespace SduCyberForm.Migrations
{
    public partial class addTableEventType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventTypeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ddos = table.Column<bool>(type: "bit", nullable: false),
                    BilgiSizdirma = table.Column<bool>(type: "bit", nullable: false),
                    Dolandırıcılık = table.Column<bool>(type: "bit", nullable: false),
                    PortTarama = table.Column<bool>(type: "bit", nullable: false),
                    VeriSaldırı = table.Column<bool>(type: "bit", nullable: false),
                    WebGuvenlik = table.Column<bool>(type: "bit", nullable: false),
                    SosyalMuh = table.Column<bool>(type: "bit", nullable: false),
                    VeriKaybı = table.Column<bool>(type: "bit", nullable: false),
                    Spam = table.Column<bool>(type: "bit", nullable: false),
                    ParolaEleGec = table.Column<bool>(type: "bit", nullable: false),
                    CihazKaybı = table.Column<bool>(type: "bit", nullable: false),
                    KimlikTaklidi = table.Column<bool>(type: "bit", nullable: false),
                    Oltalama = table.Column<bool>(type: "bit", nullable: false),
                    KisiselKotuKullanım = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypeModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventTypeModel");
        }
    }
}
