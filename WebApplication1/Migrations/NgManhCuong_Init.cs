using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhomHang",
                columns: table => new
                {
                    NhomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhom = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NhomHangEntityNhomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomHang", x => x.NhomId);
                    table.ForeignKey(
                        name: "FK_NhomHang_NhomHang_NhomHangEntityNhomId",
                        column: x => x.NhomHangEntityNhomId,
                        principalTable: "NhomHang",
                        principalColumn: "NhomId");
                });

            migrationBuilder.CreateTable(
                name: "HangHoa",
                columns: table => new
                {
                    HangHoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhomHangId = table.Column<int>(type: "int", nullable: false),
                    TenHangHoa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHoa", x => x.HangHoaId);
                    table.ForeignKey(
                        name: "FK_HangHoa_NhomHang_NhomHangId",
                        column: x => x.NhomHangId,
                        principalTable: "NhomHang",
                        principalColumn: "NhomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HangHoa_NhomHangId",
                table: "HangHoa",
                column: "NhomHangId");

            migrationBuilder.CreateIndex(
                name: "IX_NhomHang_NhomHangEntityNhomId",
                table: "NhomHang",
                column: "NhomHangEntityNhomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HangHoa");

            migrationBuilder.DropTable(
                name: "NhomHang");
        }
    }
}
