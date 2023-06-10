using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoAnThucTap.Data.Migrations
{
    /// <inheritdoc />
    public partial class themkhachhang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_purchasedCourses_Subject_IdSub",
                table: "purchasedCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_purchasedCourses_User_IdUser",
                table: "purchasedCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_purchasedCourses",
                table: "purchasedCourses");

            migrationBuilder.RenameTable(
                name: "purchasedCourses",
                newName: "PurchasedCourse");

            migrationBuilder.RenameIndex(
                name: "IX_purchasedCourses_IdUser",
                table: "PurchasedCourse",
                newName: "IX_PurchasedCourse_IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_purchasedCourses_IdSub",
                table: "PurchasedCourse",
                newName: "IX_PurchasedCourse_IdSub");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasedCourse",
                table: "PurchasedCourse",
                column: "Id");

            migrationBuilder.InsertData(
                table: "MstPerMission",
                columns: new[] { "Id", "Code", "CreateAt", "CreateBy", "DeleteAt", "Desc", "DetleteBy", "DislayOrder", "GroupName", "Table", "UpdateAt" },
                values: new object[,]
                {
                    { 9301, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách khóa học", null, null, "Quản lý mua khóa học", "PurchasedCourse", null },
                    { 9302, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết khóa học", null, null, "Quản lý mua khóa học", "PurchasedCourse", null },
                    { 9303, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mua khóa học", null, null, "Quản lý mua khóa học", "PurchasedCourse", null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreateAt", "CreateBy", "DeleteAt", "Description", "DetleteBy", "DislayOrder", "RoleName", "UpdateAt" },
                values: new object[] { 2, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tài khoản do khách hàng tạo ngoài trang client", null, null, "Khách hàng", new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 116, 104, 109, 69, 36, 154, 35, 226, 10, 68, 217, 197, 222, 220, 161, 57, 129, 51, 181, 23, 168, 215, 224, 142, 76, 181, 53, 146, 145, 155, 36, 115, 142, 125, 108, 208, 35, 17, 204, 186, 118, 251, 239, 94, 201, 216, 223, 87, 109, 67, 122, 120, 184, 214, 81, 147, 8, 116, 218, 110, 196, 177, 13 }, new byte[] { 255, 118, 163, 26, 214, 65, 59, 91, 106, 130, 93, 253, 238, 26, 45, 106, 50, 134, 147, 34, 21, 73, 91, 10, 241, 76, 197, 7, 118, 206, 208, 116, 113, 91, 202, 101, 223, 34, 202, 245, 49, 210, 136, 202, 207, 31, 130, 48, 122, 158, 147, 53, 191, 247, 238, 52, 240, 151, 164, 116, 169, 195, 107, 235, 157, 7, 113, 59, 105, 14, 105, 100, 197, 44, 175, 33, 136, 24, 254, 15, 64, 17, 126, 194, 180, 30, 239, 38, 163, 92, 98, 140, 118, 11, 18, 134, 194, 67, 77, 3, 254, 218, 170, 165, 161, 171, 231, 131, 16, 252, 142, 247, 221, 50, 201, 255, 83, 142, 38, 42, 22, 221, 219, 3, 67, 231, 109, 91 } });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "Id", "CreateAt", "CreateBy", "DeleteAt", "DetleteBy", "DislayOrder", "MStPermissionId", "RoleId", "UpdateAt" },
                values: new object[,]
                {
                    { 55, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9301, 2, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9302, 2, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9303, 2, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedCourse_Subject_IdSub",
                table: "PurchasedCourse",
                column: "IdSub",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedCourse_User_IdUser",
                table: "PurchasedCourse",
                column: "IdUser",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedCourse_Subject_IdSub",
                table: "PurchasedCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedCourse_User_IdUser",
                table: "PurchasedCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasedCourse",
                table: "PurchasedCourse");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MstPerMission",
                keyColumn: "Id",
                keyValue: 9301);

            migrationBuilder.DeleteData(
                table: "MstPerMission",
                keyColumn: "Id",
                keyValue: 9302);

            migrationBuilder.DeleteData(
                table: "MstPerMission",
                keyColumn: "Id",
                keyValue: 9303);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "PurchasedCourse",
                newName: "purchasedCourses");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasedCourse_IdUser",
                table: "purchasedCourses",
                newName: "IX_purchasedCourses_IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasedCourse_IdSub",
                table: "purchasedCourses",
                newName: "IX_purchasedCourses_IdSub");

            migrationBuilder.AddPrimaryKey(
                name: "PK_purchasedCourses",
                table: "purchasedCourses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 62, 109, 129, 59, 183, 85, 156, 134, 63, 183, 169, 29, 242, 19, 103, 102, 77, 180, 191, 53, 68, 59, 181, 41, 92, 159, 213, 110, 94, 252, 72, 38, 240, 117, 186, 152, 255, 252, 112, 162, 112, 0, 124, 53, 31, 121, 84, 237, 173, 212, 199, 255, 147, 242, 91, 52, 89, 252, 228, 27, 48, 37, 16, 188 }, new byte[] { 43, 77, 140, 34, 162, 55, 151, 131, 75, 174, 115, 133, 210, 77, 2, 99, 163, 163, 216, 49, 224, 95, 139, 123, 247, 174, 95, 189, 115, 173, 121, 130, 21, 82, 126, 5, 23, 222, 182, 54, 53, 205, 127, 246, 106, 130, 217, 130, 12, 153, 171, 241, 81, 109, 135, 43, 2, 245, 2, 26, 151, 17, 99, 43, 2, 177, 100, 108, 73, 223, 213, 113, 64, 37, 170, 46, 122, 154, 1, 237, 75, 168, 55, 248, 237, 5, 26, 93, 173, 3, 0, 104, 38, 247, 116, 98, 55, 174, 176, 208, 35, 119, 16, 225, 107, 153, 29, 116, 175, 96, 152, 125, 45, 9, 112, 136, 118, 152, 99, 203, 250, 249, 230, 229, 20, 159, 75, 255 } });

            migrationBuilder.AddForeignKey(
                name: "FK_purchasedCourses_Subject_IdSub",
                table: "purchasedCourses",
                column: "IdSub",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_purchasedCourses_User_IdUser",
                table: "purchasedCourses",
                column: "IdUser",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
