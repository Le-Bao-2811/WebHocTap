using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnThucTap.Data.Migrations
{
    /// <inheritdoc />
    public partial class suabangkiemtra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Test_Lesson_IdLesson",
                table: "Test");

            migrationBuilder.RenameColumn(
                name: "IdLesson",
                table: "Test",
                newName: "IdChapter");

            migrationBuilder.RenameIndex(
                name: "IX_Test_IdLesson",
                table: "Test",
                newName: "IX_Test_IdChapter");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Test_Lesson_IdChapter",
                table: "Test");

            migrationBuilder.RenameColumn(
                name: "IdChapter",
                table: "Test",
                newName: "IdLesson");

            migrationBuilder.RenameIndex(
                name: "IX_Test_IdChapter",
                table: "Test",
                newName: "IX_Test_IdLesson");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 116, 104, 109, 69, 36, 154, 35, 226, 10, 68, 217, 197, 222, 220, 161, 57, 129, 51, 181, 23, 168, 215, 224, 142, 76, 181, 53, 146, 145, 155, 36, 115, 142, 125, 108, 208, 35, 17, 204, 186, 118, 251, 239, 94, 201, 216, 223, 87, 109, 67, 122, 120, 184, 214, 81, 147, 8, 116, 218, 110, 196, 177, 13 }, new byte[] { 255, 118, 163, 26, 214, 65, 59, 91, 106, 130, 93, 253, 238, 26, 45, 106, 50, 134, 147, 34, 21, 73, 91, 10, 241, 76, 197, 7, 118, 206, 208, 116, 113, 91, 202, 101, 223, 34, 202, 245, 49, 210, 136, 202, 207, 31, 130, 48, 122, 158, 147, 53, 191, 247, 238, 52, 240, 151, 164, 116, 169, 195, 107, 235, 157, 7, 113, 59, 105, 14, 105, 100, 197, 44, 175, 33, 136, 24, 254, 15, 64, 17, 126, 194, 180, 30, 239, 38, 163, 92, 98, 140, 118, 11, 18, 134, 194, 67, 77, 3, 254, 218, 170, 165, 161, 171, 231, 131, 16, 252, 142, 247, 221, 50, 201, 255, 83, 142, 38, 42, 22, 221, 219, 3, 67, 231, 109, 91 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Lesson_IdLesson",
                table: "Test",
                column: "IdLesson",
                principalTable: "Lesson",
                principalColumn: "Id");
        }
    }
}
