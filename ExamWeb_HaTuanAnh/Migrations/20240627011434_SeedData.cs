using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_HaTuanAnh.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phims",
                columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "TuaDe" },
                values: new object[,]
                {
                    { 1, "Huyền Lizzie, Mạnh Trường", 150000.0, 110, true, "Chúng ta của 8 năm sau" },
                    { 2, "Sam Worthington", 250000.0, 161, false, "Avatar" },
                    { 3, "Đình Tú, Anh Đào", 160000.0, 105, true, "Gặp em ngày nắng" },
                    { 4, "Hoàng Thùy Linh, Nhan Phúc Vinh", 120000.0, 150, true, "Không ngại cưới" },
                    { 5, "Đức Khuê, Nguyệt Hằng", 130000.0, 120, true, "Gia đình đại chiến" },
                    { 6, "Arnold Schwarzenegger", 210000.0, 107, false, "Kẻ Huỷ Diệt " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
