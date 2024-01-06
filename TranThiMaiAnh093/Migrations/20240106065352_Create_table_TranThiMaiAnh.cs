using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranThiMaiAnh093.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_TranThiMaiAnh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TranThiMaiAnh",
                columns: table => new
                {
                    Hovaten = table.Column<string>(type: "TEXT", nullable: false),
                    Tuoi = table.Column<int>(type: "INTEGER", nullable: false),
                    Diem = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranThiMaiAnh", x => x.Hovaten);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranThiMaiAnh");
        }
    }
}
