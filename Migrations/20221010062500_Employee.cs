using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThaoNguyen_BTH2.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaNV = table.Column<string>(type: "TEXT", nullable: true),
                    MaPhongBan = table.Column<int>(type: "INTEGER", nullable: false),
                    TenNv = table.Column<string>(type: "TEXT", nullable: true),
                    diachi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
