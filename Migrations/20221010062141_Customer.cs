using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThaoNguyen_BTH2.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaKH = table.Column<string>(type: "TEXT", nullable: true),
                    CoQuan = table.Column<string>(type: "TEXT", nullable: true),
                    Diachi = table.Column<string>(type: "TEXT", nullable: true),
                    Sđt = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
