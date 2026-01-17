using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Application.Migrations
{
    /// <inheritdoc />
    public partial class BlogFirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "blg");

            migrationBuilder.CreateTable(
                name: "About",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Communication",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstame = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    BlogImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    AdminsId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blog_Admin_AdminsId",
                        column: x => x.AdminsId,
                        principalSchema: "blg",
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommentSubject = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    MembersId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Members_MembersId",
                        column: x => x.MembersId,
                        principalSchema: "blg",
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Admin",
                columns: new[] { "Id", "CreatedDate", "Password", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 15, 5, 18, 59, 976, DateTimeKind.Local).AddTicks(3459), "sG7p18vO", null, "Anil56" },
                    { 2, new DateTime(2024, 5, 6, 8, 50, 32, 714, DateTimeKind.Local).AddTicks(8097), "n2fd9Wu1", null, "Bulan.Aclan" },
                    { 3, new DateTime(2024, 10, 11, 13, 39, 45, 974, DateTimeKind.Local).AddTicks(2211), "R2pY1fcv", null, "Baykal.Yildirim83" }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Members",
                columns: new[] { "Id", "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "34", new DateTime(2025, 6, 14, 21, 55, 38, 55, DateTimeKind.Local).AddTicks(307), "Baymunke.Sinanoglu88@hotmail.com", "Bulmuş", "Barbarosoğlu", "EKT1tm6QYr", 2802150, null },
                    { 2, "53", new DateTime(2025, 10, 3, 0, 43, 57, 845, DateTimeKind.Local).AddTicks(7745), "Alpertunga_Velioglu@gmail.com", "Aladoğan", "Aclan", "pzCyvMv_G5", 4793339, null },
                    { 3, "23", new DateTime(2025, 5, 5, 5, 5, 16, 856, DateTimeKind.Local).AddTicks(5267), "Baldu78@yahoo.com", "Işığ", "Ertepınar", "oCf3y6SDt0", 1771156, null },
                    { 4, "58", new DateTime(2025, 4, 21, 14, 49, 34, 941, DateTimeKind.Local).AddTicks(2220), "Barlibay_Akgul60@hotmail.com", "Beçkem", "Pektemek", "kUbr1_BjNS", 7835622, null },
                    { 5, "29", new DateTime(2025, 12, 31, 16, 0, 22, 59, DateTimeKind.Local).AddTicks(5408), "Dururbunsuz62@hotmail.com", "Ceyhun", "Çatalbaş", "aZczRi5KTr", 9225076, null },
                    { 6, "64", new DateTime(2025, 3, 5, 0, 15, 33, 635, DateTimeKind.Local).AddTicks(2379), "Beg39@yahoo.com", "Bozkurt", "Çetiner", "Ns_LYNToqa", 9122321, null },
                    { 7, "49", new DateTime(2025, 3, 8, 15, 40, 36, 377, DateTimeKind.Local).AddTicks(5284), "Alpbilge.Tekelioglu88@yahoo.com", "Bulut", "Yalçın", "ondrJeTbaP", 3475922, null },
                    { 8, "49", new DateTime(2025, 5, 12, 14, 44, 1, 110, DateTimeKind.Local).AddTicks(9450), "Balkik93@gmail.com", "Etil", "Tunçeri", "IYk7dVLj8I", 2233570, null },
                    { 9, "45", new DateTime(2025, 11, 8, 20, 4, 55, 35, DateTimeKind.Local).AddTicks(8489), "Azban.Daglaroglu@gmail.com", "Aşan", "Çetin", "SypE3B2R9P", 5697001, null },
                    { 10, "35", new DateTime(2025, 12, 21, 14, 7, 16, 163, DateTimeKind.Local).AddTicks(7678), "Adli.Cagiran@gmail.com", "Alparslan", "Tazegül", "AVO3xqtRoe", 3692632, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AdminsId",
                schema: "blg",
                table: "Blog",
                column: "AdminsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MembersId",
                schema: "blg",
                table: "Comment",
                column: "MembersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Blog",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Comment",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Communication",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Admin",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Members",
                schema: "blg");
        }
    }
}
