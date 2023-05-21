using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoAnThucTap.Data.Migrations
{
    /// <inheritdoc />
    public partial class taobang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategoryNew = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryNew", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategorySub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategorySub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPayment = table.Column<bool>(type: "bit", nullable: false),
                    pathImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySub", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MstPerMission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Table = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstPerMission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pathImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCategoryNew = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_CategoryNew_IdCategoryNew",
                        column: x => x.IdCategoryNew,
                        principalTable: "CategoryNew",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCategorySub = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_CategorySub_IdCategorySub",
                        column: x => x.IdCategorySub,
                        principalTable: "CategorySub",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    MStPermissionId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermission_MstPerMission_MStPermissionId",
                        column: x => x.MStPermissionId,
                        principalTable: "MstPerMission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameChapter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapter_Subject_IdSubject",
                        column: x => x.IdSubject,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "purchasedCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSub = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchasedCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchasedCourses_Subject_IdSub",
                        column: x => x.IdSub,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchasedCourses_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdChapter = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_Chapter_IdChapter",
                        column: x => x.IdChapter,
                        principalTable: "Chapter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Coment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    IdLesson = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coment_Lesson_IdLesson",
                        column: x => x.IdLesson,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdLesson = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Test_Lesson_IdLesson",
                        column: x => x.IdLesson,
                        principalTable: "Lesson",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSucces = table.Column<bool>(type: "bit", nullable: false),
                    IdQues = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<int>(type: "int", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetleteBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DislayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Test_IdQues",
                        column: x => x.IdQues,
                        principalTable: "Test",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "MstPerMission",
                columns: new[] { "Id", "Code", "CreateAt", "CreateBy", "DeleteAt", "Desc", "DetleteBy", "DislayOrder", "GroupName", "Table", "UpdateAt" },
                values: new object[,]
                {
                    { 1001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 1002, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 1003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 1004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 1005, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Đổi mật khẩu tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 1006, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "khóa tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 1007, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mở khóa tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 1008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa tài khoản", null, null, "Quản lý tài khoản", "User", null },
                    { 2001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách câu hỏi", null, null, "Quản lý câu hỏi", "Answer", null },
                    { 2002, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết câu hỏi", null, null, "Quản lý câu hỏi", "Answer", null },
                    { 2003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm câu hỏi", null, null, "Quản lý câu hỏi", "Answer", null },
                    { 2004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa câu hỏi", null, null, "Quản lý câu hỏi", "Answer", null },
                    { 2008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa câu hỏi", null, null, "Quản lý câu hỏi", "Answer", null },
                    { 3001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách thể loại tin tức", null, null, "Quản lý thể loại tin tức", "CategoryNew", null },
                    { 3003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm thể loại tin tức", null, null, "Quản lý thể loại tin tức", "CategoryNew", null },
                    { 3004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa thể loại tin tức", null, null, "Quản lý thể loại tin tức", "CategoryNew", null },
                    { 3008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa thể loại tin tức", null, null, "Quản lý thể loại tin tức", "CategoryNew", null },
                    { 4001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách danh mục", null, null, "Quản lý danh mục", "CategorySub", null },
                    { 4003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm danh mục", null, null, "Quản lý danh mục", "CategorySub", null },
                    { 4004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa danh mục", null, null, "Quản lý danh mục", "CategorySub", null },
                    { 4008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa danh mục", null, null, "Quản lý danh mục", "CategorySub", null },
                    { 5001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách chương của bài học", null, null, "Quản lý chương của bài học", "Chapter", null },
                    { 5002, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết chương của bài học", null, null, "Quản lý chương của bài học", "Chapter", null },
                    { 5003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm chương của bài học", null, null, "Quản lý chương của bài học", "Chapter", null },
                    { 5004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa chương của bài học", null, null, "Quản lý chương của bài học", "Chapter", null },
                    { 5008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa chương của bài học", null, null, "Quản lý chương của bài học", "Chapter", null },
                    { 6001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách bài học", null, null, "Quản lý bài học", "Lesson", null },
                    { 6002, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết bài học", null, null, "Quản lý bài học", "Lesson", null },
                    { 6003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm bài học", null, null, "Quản lý bài học", "Lesson", null },
                    { 6004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa bài học", null, null, "Quản lý bài học", "Lesson", null },
                    { 6008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa bài học", null, null, "Quản lý bài học", "Lesson", null },
                    { 7001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách phản hồi", null, null, "Quản lý phản hồi", "Report", null },
                    { 7002, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết phản hồi", null, null, "Quản lý phản hồi", "Report", null },
                    { 7008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa phản hồi", null, null, "Quản lý phản hồi", "Report", null },
                    { 8001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách môn học", null, null, "Quản lý môn học ", "Subject", null },
                    { 8002, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết môn học", null, null, "Quản lý môn học ", "Subject", null },
                    { 8003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm môn học", null, null, "Quản lý môn học ", "Subject", null },
                    { 8004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa môn học", null, null, "Quản lý môn học ", "Subject", null },
                    { 8008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa môn học", null, null, "Quản lý môn học ", "Subject", null },
                    { 9001, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách tin tức", null, null, "Quản lý tin tức", "News", null },
                    { 9002, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết tin tức", null, null, "Quản lý tin tức", "News", null },
                    { 9003, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm tin tức", null, null, "Quản lý tin tức", "News", null },
                    { 9004, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa tin tức", null, null, "Quản lý tin tức", "News", null },
                    { 9008, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa tin tức", null, null, "Quản lý tin tức", "News", null },
                    { 9101, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách bài kiểm tra", null, null, "Quản lý bài kiểm tra", "Test", null },
                    { 9102, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết bài kiểm tra", null, null, "Quản lý bài kiểm tra", "Test", null },
                    { 9103, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm bài kiểm tra", null, null, "Quản lý bài kiểm tra", "Test", null },
                    { 9104, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa bài kiểm tra", null, null, "Quản lý bài kiểm tra", "Test", null },
                    { 9108, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa bài kiểm tra", null, null, "Quản lý bài kiểm tra", "Test", null },
                    { 9201, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem danh sách quyền", null, null, "Quản lý phân quyền", "Role", null },
                    { 9202, "VIEW_DETAIL", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xem chi tiết quyền", null, null, "Quản lý phân quyền", "Role", null },
                    { 9203, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Thêm quyền", null, null, "Quản lý phân quyền", "Role", null },
                    { 9204, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Sửa quyền", null, null, "Quản lý phân quyền", "Role", null },
                    { 9208, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Xóa quyền", null, null, "Quản lý phân quyền", "Role", null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreateAt", "CreateBy", "DeleteAt", "Description", "DetleteBy", "DislayOrder", "RoleName", "UpdateAt" },
                values: new object[] { 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Quản trị toàn bộ hệ thống", null, null, "Quản trị hệ thống", new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "Id", "CreateAt", "CreateBy", "DeleteAt", "DetleteBy", "DislayOrder", "MStPermissionId", "RoleId", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1002, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1005, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1006, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1007, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2002, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 3001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 3003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 3004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 3008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 4001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 4003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 4004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 4008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5002, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 5008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 6002, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 6001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 6003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 6004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 6008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 7001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 7002, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 7008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8002, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 8008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9001, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9002, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9003, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9004, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9008, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9101, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9102, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9103, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9104, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9108, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9201, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9202, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9203, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9204, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 9208, 1, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "CreateBy", "DeleteAt", "DetleteBy", "DislayOrder", "Gmail", "IdRole", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdateAt", "UserName" },
                values: new object[] { 1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, null, null, null, "admin_test@gmail.com", 1, new byte[] { 16, 142, 120, 174, 155, 37, 2, 146, 184, 244, 208, 73, 44, 47, 125, 34, 209, 123, 194, 53, 21, 4, 201, 198, 252, 245, 166, 22, 98, 120, 0, 32, 32, 215, 229, 1, 143, 116, 62, 213, 56, 244, 94, 64, 82, 63, 42, 120, 140, 238, 93, 186, 78, 65, 6, 113, 13, 21, 14, 73, 172, 65, 195, 102 }, new byte[] { 134, 17, 32, 76, 121, 140, 71, 142, 166, 190, 238, 251, 107, 119, 97, 58, 149, 80, 142, 154, 225, 123, 56, 58, 92, 32, 211, 139, 236, 145, 50, 13, 108, 166, 53, 129, 41, 39, 243, 138, 152, 118, 152, 238, 2, 223, 86, 209, 210, 137, 218, 6, 168, 125, 100, 231, 174, 94, 58, 190, 52, 36, 68, 127, 117, 241, 124, 156, 174, 197, 201, 184, 18, 118, 88, 73, 163, 233, 61, 98, 135, 111, 226, 113, 76, 34, 207, 127, 93, 165, 145, 48, 255, 249, 202, 105, 75, 131, 168, 188, 213, 99, 35, 1, 11, 125, 74, 18, 143, 17, 83, 61, 231, 54, 157, 224, 7, 163, 172, 75, 148, 25, 171, 164, 143, 31, 231, 95 }, "0928666158", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_IdQues",
                table: "Answer",
                column: "IdQues");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_IdSubject",
                table: "Chapter",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_Coment_IdLesson",
                table: "Coment",
                column: "IdLesson");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_IdChapter",
                table: "Lesson",
                column: "IdChapter");

            migrationBuilder.CreateIndex(
                name: "IX_News_IdCategoryNew",
                table: "News",
                column: "IdCategoryNew");

            migrationBuilder.CreateIndex(
                name: "IX_purchasedCourses_IdSub",
                table: "purchasedCourses",
                column: "IdSub");

            migrationBuilder.CreateIndex(
                name: "IX_purchasedCourses_IdUser",
                table: "purchasedCourses",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_MStPermissionId",
                table: "RolePermission",
                column: "MStPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_RoleId",
                table: "RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_IdCategorySub",
                table: "Subject",
                column: "IdCategorySub");

            migrationBuilder.CreateIndex(
                name: "IX_Test_IdLesson",
                table: "Test",
                column: "IdLesson");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdRole",
                table: "User",
                column: "IdRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Coment");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "purchasedCourses");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "CategoryNew");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "MstPerMission");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "CategorySub");
        }
    }
}
