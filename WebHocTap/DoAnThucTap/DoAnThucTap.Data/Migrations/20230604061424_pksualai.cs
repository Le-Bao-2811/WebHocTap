using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnThucTap.Data.Migrations
{
    /// <inheritdoc />
    public partial class pksualai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedCourse_Subject_IdSub",
                table: "PurchasedCourse");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 210, 205, 190, 34, 128, 0, 242, 181, 246, 108, 135, 147, 46, 86, 41, 241, 68, 207, 90, 77, 255, 23, 233, 215, 166, 163, 143, 248, 184, 167, 220, 7, 132, 3, 253, 96, 130, 108, 254, 59, 82, 174, 126, 74, 72, 23, 56, 180, 124, 87, 12, 62, 180, 33, 223, 57, 191, 86, 135, 83, 239, 149, 225, 242 }, new byte[] { 26, 248, 208, 104, 70, 180, 235, 111, 199, 190, 5, 4, 116, 154, 153, 40, 68, 125, 13, 40, 237, 234, 76, 76, 195, 7, 133, 54, 240, 134, 68, 53, 82, 38, 69, 244, 143, 76, 239, 76, 183, 32, 63, 220, 119, 40, 199, 161, 247, 96, 223, 127, 36, 62, 29, 254, 166, 49, 128, 195, 122, 185, 65, 86, 166, 181, 236, 144, 244, 131, 46, 8, 156, 34, 240, 205, 67, 35, 218, 36, 58, 107, 139, 78, 55, 169, 211, 165, 76, 16, 121, 133, 122, 10, 55, 81, 88, 17, 234, 92, 95, 122, 34, 143, 155, 113, 82, 17, 94, 59, 165, 140, 166, 134, 10, 66, 104, 190, 100, 239, 79, 159, 226, 248, 78, 59, 62, 68 } });

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedCourse_CategorySub_IdSub",
                table: "PurchasedCourse",
                column: "IdSub",
                principalTable: "CategorySub",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedCourse_CategorySub_IdSub",
                table: "PurchasedCourse");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 87, 120, 114, 199, 5, 69, 165, 13, 6, 5, 136, 53, 143, 93, 110, 142, 168, 95, 33, 131, 46, 46, 24, 216, 209, 183, 47, 82, 30, 173, 207, 41, 47, 224, 49, 148, 158, 181, 226, 122, 94, 242, 208, 235, 250, 143, 172, 56, 144, 219, 206, 195, 244, 171, 221, 25, 207, 166, 12, 178, 64, 70, 209 }, new byte[] { 85, 143, 117, 0, 157, 141, 222, 119, 242, 171, 24, 103, 203, 84, 139, 124, 45, 48, 187, 63, 241, 99, 51, 171, 25, 106, 164, 110, 238, 60, 51, 190, 181, 170, 16, 34, 189, 135, 24, 11, 24, 172, 220, 228, 234, 133, 145, 220, 34, 255, 171, 138, 32, 24, 0, 67, 254, 27, 39, 34, 240, 147, 151, 133, 111, 79, 52, 119, 134, 151, 100, 49, 19, 167, 148, 46, 84, 31, 166, 111, 185, 132, 134, 55, 196, 4, 232, 38, 238, 10, 94, 71, 129, 32, 159, 34, 52, 81, 60, 90, 31, 109, 242, 206, 25, 18, 82, 75, 172, 99, 111, 161, 84, 74, 78, 22, 109, 100, 5, 219, 119, 220, 169, 200, 207, 10, 40, 213 } });

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedCourse_Subject_IdSub",
                table: "PurchasedCourse",
                column: "IdSub",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
