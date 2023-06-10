using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnThucTap.Data.Migrations
{
    /// <inheritdoc />
    public partial class suacot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "CategorySub",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 62, 109, 129, 59, 183, 85, 156, 134, 63, 183, 169, 29, 242, 19, 103, 102, 77, 180, 191, 53, 68, 59, 181, 41, 92, 159, 213, 110, 94, 252, 72, 38, 240, 117, 186, 152, 255, 252, 112, 162, 112, 0, 124, 53, 31, 121, 84, 237, 173, 212, 199, 255, 147, 242, 91, 52, 89, 252, 228, 27, 48, 37, 16, 188 }, new byte[] { 43, 77, 140, 34, 162, 55, 151, 131, 75, 174, 115, 133, 210, 77, 2, 99, 163, 163, 216, 49, 224, 95, 139, 123, 247, 174, 95, 189, 115, 173, 121, 130, 21, 82, 126, 5, 23, 222, 182, 54, 53, 205, 127, 246, 106, 130, 217, 130, 12, 153, 171, 241, 81, 109, 135, 43, 2, 245, 2, 26, 151, 17, 99, 43, 2, 177, 100, 108, 73, 223, 213, 113, 64, 37, 170, 46, 122, 154, 1, 237, 75, 168, 55, 248, 237, 5, 26, 93, 173, 3, 0, 104, 38, 247, 116, 98, 55, 174, 176, 208, 35, 119, 16, 225, 107, 153, 29, 116, 175, 96, 152, 125, 45, 9, 112, 136, 118, 152, 99, 203, 250, 249, 230, 229, 20, 159, 75, 255 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "CategorySub",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 240, 47, 155, 37, 186, 33, 165, 71, 242, 235, 248, 67, 88, 125, 232, 222, 206, 119, 242, 212, 219, 132, 39, 120, 89, 227, 215, 140, 202, 127, 70, 172, 194, 19, 91, 35, 155, 63, 221, 36, 252, 63, 112, 137, 75, 172, 129, 152, 110, 207, 45, 192, 29, 67, 56, 119, 158, 214, 27, 147, 235, 158, 4, 192 }, new byte[] { 34, 73, 132, 192, 33, 185, 189, 253, 171, 211, 105, 103, 140, 135, 14, 155, 22, 49, 4, 135, 69, 100, 153, 235, 214, 70, 240, 215, 31, 25, 243, 50, 3, 83, 52, 46, 167, 132, 131, 151, 226, 240, 200, 122, 239, 6, 58, 53, 3, 112, 253, 119, 188, 64, 146, 27, 227, 31, 174, 92, 185, 89, 159, 200, 46, 206, 206, 108, 213, 2, 83, 241, 105, 229, 131, 144, 201, 221, 212, 57, 176, 73, 25, 108, 135, 148, 218, 207, 171, 36, 59, 118, 24, 89, 132, 252, 99, 66, 186, 124, 56, 5, 223, 226, 93, 13, 155, 68, 162, 24, 5, 23, 37, 167, 7, 56, 206, 187, 53, 147, 173, 232, 48, 216, 161, 9, 190, 177 } });
        }
    }
}
