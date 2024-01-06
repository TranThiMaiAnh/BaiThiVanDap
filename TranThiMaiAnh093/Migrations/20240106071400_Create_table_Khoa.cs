using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranThiMaiAnh093.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Khoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    MaKhoa = table.Column<string>(type: "TEXT", nullable: false),
                    TenKhoa = table.Column<string>(type: "TEXT", nullable: false),
                    SoDienThoai = table.Column<string>(type: "TEXT", nullable: false),
                    Hovaten = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.MaKhoa);
                    table.ForeignKey(
                        name: "FK_Khoa_TranThiMaiAnh_Hovaten",
                        column: x => x.Hovaten,
                        principalTable: "TranThiMaiAnh",
                        principalColumn: "Hovaten",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Khoa_Hovaten",
                table: "Khoa",
                column: "Hovaten");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
