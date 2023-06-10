using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnThucTap.Data.Migrations
{
    /// <inheritdoc />
    public partial class suapk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Test_Lesson_IdChapter",
                table: "Test");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 87, 120, 114, 199, 5, 69, 165, 13, 6, 5, 136, 53, 143, 93, 110, 142, 168, 95, 33, 131, 46, 46, 24, 216, 209, 183, 47, 82, 30, 173, 207, 41, 47, 224, 49, 148, 158, 181, 226, 122, 94, 242, 208, 235, 250, 143, 172, 56, 144, 219, 206, 195, 244, 171, 221, 25, 207, 166, 12, 178, 64, 70, 209 }, new byte[] { 85, 143, 117, 0, 157, 141, 222, 119, 242, 171, 24, 103, 203, 84, 139, 124, 45, 48, 187, 63, 241, 99, 51, 171, 25, 106, 164, 110, 238, 60, 51, 190, 181, 170, 16, 34, 189, 135, 24, 11, 24, 172, 220, 228, 234, 133, 145, 220, 34, 255, 171, 138, 32, 24, 0, 67, 254, 27, 39, 34, 240, 147, 151, 133, 111, 79, 52, 119, 134, 151, 100, 49, 19, 167, 148, 46, 84, 31, 166, 111, 185, 132, 134, 55, 196, 4, 232, 38, 238, 10, 94, 71, 129, 32, 159, 34, 52, 81, 60, 90, 31, 109, 242, 206, 25, 18, 82, 75, 172, 99, 111, 161, 84, 74, 78, 22, 109, 100, 5, 219, 119, 220, 169, 200, 207, 10, 40, 213 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Chapter_IdChapter",
                table: "Test",
                column: "IdChapter",
                principalTable: "Chapter",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Test_Chapter_IdChapter",
                table: "Test");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 52, 122, 2, 176, 165, 143, 145, 99, 216, 193, 93, 93, 202, 72, 89, 175, 76, 42, 19, 168, 65, 207, 108, 105, 219, 195, 134, 245, 78, 44, 70, 137, 36, 97, 140, 182, 247, 77, 167, 37, 96, 169, 38, 77, 2, 110, 179, 177, 207, 170, 208, 30, 193, 109, 199, 89, 62, 87, 78, 170, 187, 129, 130, 68 }, new byte[] { 220, 200, 145, 158, 27, 10, 30, 223, 251, 194, 81, 187, 7, 238, 251, 117, 220, 77, 186, 84, 169, 138, 219, 46, 253, 117, 122, 190, 94, 183, 92, 12, 220, 39, 254, 237, 111, 110, 235, 156, 212, 148, 79, 208, 203, 101, 129, 206, 53, 240, 195, 40, 231, 164, 168, 133, 92, 230, 27, 177, 25, 0, 181, 207, 21, 9, 157, 78, 121, 192, 78, 222, 165, 133, 9, 243, 161, 76, 190, 121, 209, 234, 205, 111, 145, 197, 93, 155, 146, 187, 60, 143, 129, 66, 128, 137, 224, 127, 236, 168, 86, 178, 243, 167, 189, 42, 226, 104, 153, 224, 137, 56, 35, 94, 50, 104, 187, 99, 247, 190, 22, 146, 214, 214, 62, 90, 248, 249 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Lesson_IdChapter",
                table: "Test",
                column: "IdChapter",
                principalTable: "Lesson",
                principalColumn: "Id");
        }
    }
}
