using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnThucTap.Data.Migrations
{
    /// <inheritdoc />
    public partial class themcot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripstion",
                table: "CategorySub",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 240, 47, 155, 37, 186, 33, 165, 71, 242, 235, 248, 67, 88, 125, 232, 222, 206, 119, 242, 212, 219, 132, 39, 120, 89, 227, 215, 140, 202, 127, 70, 172, 194, 19, 91, 35, 155, 63, 221, 36, 252, 63, 112, 137, 75, 172, 129, 152, 110, 207, 45, 192, 29, 67, 56, 119, 158, 214, 27, 147, 235, 158, 4, 192 }, new byte[] { 34, 73, 132, 192, 33, 185, 189, 253, 171, 211, 105, 103, 140, 135, 14, 155, 22, 49, 4, 135, 69, 100, 153, 235, 214, 70, 240, 215, 31, 25, 243, 50, 3, 83, 52, 46, 167, 132, 131, 151, 226, 240, 200, 122, 239, 6, 58, 53, 3, 112, 253, 119, 188, 64, 146, 27, 227, 31, 174, 92, 185, 89, 159, 200, 46, 206, 206, 108, 213, 2, 83, 241, 105, 229, 131, 144, 201, 221, 212, 57, 176, 73, 25, 108, 135, 148, 218, 207, 171, 36, 59, 118, 24, 89, 132, 252, 99, 66, 186, 124, 56, 5, 223, 226, 93, 13, 155, 68, 162, 24, 5, 23, 37, 167, 7, 56, 206, 187, 53, 147, 173, 232, 48, 216, 161, 9, 190, 177 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripstion",
                table: "CategorySub");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 55, 200, 154, 214, 255, 58, 227, 18, 136, 26, 246, 81, 103, 216, 64, 221, 219, 107, 105, 17, 220, 190, 38, 88, 51, 229, 93, 89, 190, 156, 91, 140, 226, 196, 186, 91, 103, 119, 76, 157, 0, 93, 57, 12, 220, 14, 48, 26, 99, 2, 190, 244, 203, 95, 251, 127, 142, 62, 153, 43, 155, 121, 154 }, new byte[] { 84, 87, 182, 11, 214, 150, 221, 158, 185, 107, 12, 181, 60, 75, 132, 212, 119, 28, 193, 78, 57, 90, 163, 177, 63, 246, 104, 254, 90, 112, 203, 124, 230, 171, 108, 228, 105, 94, 231, 190, 110, 158, 100, 220, 115, 126, 157, 10, 42, 87, 51, 202, 93, 245, 240, 55, 16, 169, 203, 45, 185, 28, 255, 172, 28, 124, 79, 247, 125, 75, 13, 62, 235, 123, 11, 132, 34, 164, 68, 254, 186, 159, 8, 180, 221, 166, 186, 64, 111, 53, 236, 237, 156, 124, 182, 137, 196, 171, 235, 4, 58, 35, 94, 43, 88, 110, 23, 39, 82, 215, 158, 46, 200, 235, 48, 243, 205, 31, 83, 95, 222, 158, 115, 47, 92, 138, 46, 246 } });
        }
    }
}
