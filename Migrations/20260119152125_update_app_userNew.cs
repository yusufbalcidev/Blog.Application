using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Application.Migrations
{
    /// <inheritdoc />
    public partial class update_app_userNew : Migration
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
                name: "AppUsers",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blog_Admin_AdminId",
                        column: x => x.AdminId,
                        principalSchema: "blg",
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "blg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    AppUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogsId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalSchema: "blg",
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Comments_AppUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalSchema: "blg",
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Blog_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "blg",
                        principalTable: "Blog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Blog_BlogsId",
                        column: x => x.BlogsId,
                        principalSchema: "blg",
                        principalTable: "Blog",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "About",
                columns: new[] { "Id", "CreatedDate", "Description", "FotoUrl", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2026, 1, 19, 16, 50, 2, 66, DateTimeKind.Local).AddTicks(6437), "Patlıcan telefonu quis ullam vitae masaya alias kulu duyulmamış voluptate. Gül çarpan ea architecto labore dolorem hesap. Ona koştum aperiam telefonu ama praesentium neque.\n\nReprehenderit dolayı sıradanlıktan. Olduğu neque çorba quis sarmal. Aliquam çobanın dignissimos aliquam ducimus suscipit cezbelendi adipisci gazete. İllo de eius dolayı voluptate şafak magnam doloremque esse reprehenderit. Quia olduğu illo quam quasi modi.", "https://picsum.photos/640/480/?image=317", null });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Admin",
                columns: new[] { "Id", "CreatedDate", "Password", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 16, 11, 27, 11, 61, DateTimeKind.Local).AddTicks(2307), "8A8Qdyyzu0", null, "Bilgetamgaci.Agaoglu79" },
                    { 2, new DateTime(2025, 9, 30, 21, 13, 9, 884, DateTimeKind.Local).AddTicks(4264), "AvMxbOyqHp", null, "Bakir.Suleymanoglu" },
                    { 3, new DateTime(2025, 10, 26, 17, 3, 6, 205, DateTimeKind.Local).AddTicks(3982), "12vrp8VHlO", null, "Ayma_Tuzun16" }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1390ab75-53f6-4bd5-840c-d1076be93c8c", 0, new DateTime(1984, 2, 16, 15, 18, 55, 124, DateTimeKind.Local).AddTicks(1722), "Manisa", "7eaddf16-db20-4ae5-a8ba-0f0387131e0f", "Bulug15@hotmail.com", true, 1, false, null, "BULUG15@HOTMAIL.COM", "BURULDAY24", "AQAAAAIAAYagAAAAEG+eqyXr+jOpudUr5RlMVBQyYJ+OomwGRAHIazkyUXGJiQnO90wT2iezQfURYux3tg==", "05949433900", false, "https://picsum.photos/640/480/?image=1060", "5722844d-c038-4a92-8be6-8d7c4e0d9142", false, "Burulday24" },
                    { "391effa3-4115-422c-a8a1-1a3b85331cac", 0, new DateTime(1996, 9, 24, 21, 52, 31, 619, DateTimeKind.Local).AddTicks(4861), "Yalova", "08180c37-9176-40ae-a45e-53915afec7db", "Basat32@hotmail.com", true, 1, false, null, "BASAT32@HOTMAIL.COM", "ALPAGUT97", "AQAAAAIAAYagAAAAEGyX1+tQOD/sVnj2bvct1XGcUV3Uv11V6BpuJogtj9Ue8kpWGMSkJBYdb7Ac3aZT9A==", "05120953195", false, "https://picsum.photos/640/480/?image=355", "1d111fa3-96b8-4822-8b16-9dc69545c05e", false, "Alpagut97" },
                    { "40b1e082-0363-43c4-8a81-5ea90ddbb2ed", 0, new DateTime(2003, 5, 3, 23, 10, 49, 125, DateTimeKind.Local).AddTicks(8298), "Düzce", "94faec8e-369f-4af7-9f59-54b728d718df", "Alaboru_Orbay@yahoo.com", true, 1, false, null, "ALABORU_ORBAY@YAHOO.COM", "BARSKAN1", "AQAAAAIAAYagAAAAEDOR6NtST0WEivPiMVYshH0DirciH0RnmMXdmxO8raa/57WcHjrxCIRkf5EIlF8njQ==", "05250715989", false, "https://picsum.photos/640/480/?image=403", "21db846b-5a8a-46ee-9bb2-70a9cd46e039", false, "Barskan1" },
                    { "4226d55c-2a4b-43ec-82a6-e9d874cf0369", 0, new DateTime(1987, 7, 3, 13, 28, 42, 689, DateTimeKind.Local).AddTicks(9987), "Bolu", "f2fbb9e4-67c5-4bb9-9fd7-3c29d8677906", "Bugubilge72@hotmail.com", true, 1, false, null, "BUGUBILGE72@HOTMAIL.COM", "BAYINCUR3", "AQAAAAIAAYagAAAAELeAImKUqOjUs3su8vWM2om/63NdSJw1YSBAzIRzNUoFW0VicaYd4JBqgRvmEvn4ew==", "05978758464", false, "https://picsum.photos/640/480/?image=256", "573ade9b-c32f-481a-b1d5-8ce4a5beedf4", false, "Bayincur3" },
                    { "5a612e79-175a-487b-98e7-5ea2ba2c23e9", 0, new DateTime(1997, 10, 21, 4, 46, 55, 462, DateTimeKind.Local).AddTicks(3577), "Samsun", "2188c88a-5583-423a-85e6-3e978c6bb083", "Barcadogdu.Dagdas25@gmail.com", true, 1, false, null, "BARCADOGDU.DAGDAS25@GMAIL.COM", "BELGUC43", "AQAAAAIAAYagAAAAEGD9CxGlrqsE3/93FTscPJUD6E/RbNOjWb7F/7JlHsRhjat2Aspy5ONMHUGhJgOBAA==", "05500367817", false, "https://picsum.photos/640/480/?image=1068", "e3874471-7dac-4d72-bab1-465752eb52c7", false, "Belguc43" },
                    { "73d21eb2-7468-42f6-ba85-f2045d269c03", 0, new DateTime(1980, 3, 10, 19, 12, 4, 585, DateTimeKind.Local).AddTicks(8949), "K.maraş", "4133ea74-b1d2-44ba-a996-dc8cc71ae484", "Isilay0@yahoo.com", true, 1, false, null, "ISILAY0@YAHOO.COM", "BUKTEGIN_HAKYEMEZ34", "AQAAAAIAAYagAAAAECSGIN+jCJC3B/kN1obCVotPtgS0yphAlo2/5pkMsgGZD5huO7rAtfjPUJ9+QQp0XA==", "05174501142", false, "https://picsum.photos/640/480/?image=838", "095b3e13-9be4-48da-b6d3-1d3416cfcfbe", false, "Buktegin_Hakyemez34" },
                    { "a549638e-cd84-4307-94c6-e71ef200cdaa", 0, new DateTime(1998, 6, 5, 20, 28, 18, 814, DateTimeKind.Local).AddTicks(5300), "Bayburt", "c27a67ee-bb16-4d63-b7e6-d8108e74d85c", "Bilig.Corekci36@gmail.com", true, 2, false, null, "BILIG.COREKCI36@GMAIL.COM", "AYKURT_BALCI81", "AQAAAAIAAYagAAAAEFJjKjXoJcGx6tOupGgAijmv560OqoWbpt5HTz6rZYn2HUukgxNRSVtX2ANL67AicA==", "05025303115", false, "https://picsum.photos/640/480/?image=750", "02f7c6ec-345e-485c-b9db-ebad96475b77", false, "Aykurt_Balci81" },
                    { "e6859d6c-4eb0-4543-8e58-83404fc81aee", 0, new DateTime(1989, 9, 8, 13, 3, 15, 502, DateTimeKind.Local).AddTicks(385), "Samsun", "79efb9ba-84e3-40a5-adac-a8ed9bfba8ed", "Barcadurmus_Sinanoglu@yahoo.com", true, 1, false, null, "BARCADURMUS_SINANOGLU@YAHOO.COM", "BERENDEY.ERCETIN", "AQAAAAIAAYagAAAAEPyJTxB22pZg/5vLIXpuO9CUGyxLPt/VH22ubaPlcT8hV4bdVrOCIie9kgLNvv04Xw==", "05469287152", false, "https://picsum.photos/640/480/?image=690", "57d11828-a9e5-4072-aa7b-6559eebbb09b", false, "Berendey.Ercetin" },
                    { "ec8ca8dd-10e7-46f0-8cb7-fc62a4803a22", 0, new DateTime(1986, 7, 22, 16, 2, 15, 177, DateTimeKind.Local).AddTicks(8530), "İstanbul", "0fc9acb1-4219-4481-967e-b60c1db91893", "Barcadogmus.Sayginer87@gmail.com", true, 1, false, null, "BARCADOGMUS.SAYGINER87@GMAIL.COM", "BOKE_OZTUNA49", "AQAAAAIAAYagAAAAEAzQcDgFbCDFa7SS9NmrSMM2Roq1N4osiHbaY2XQhKymKBaz2ofuJFyQYTsVe53qhQ==", "05850749644", false, "https://picsum.photos/640/480/?image=218", "8f72c925-e596-40a8-af99-3e00d064a30b", false, "Boke_Oztuna49" },
                    { "ff719141-9016-4f96-a8ee-8a7783928650", 0, new DateTime(2006, 6, 13, 7, 2, 11, 704, DateTimeKind.Local).AddTicks(8361), "Sakarya", "1f0e67a7-4f1d-40fa-9327-dd4fa3bc04a5", "Betemir_Okumus@yahoo.com", true, 1, false, null, "BETEMIR_OKUMUS@YAHOO.COM", "BALTUR_ERKEKLI53", "AQAAAAIAAYagAAAAEGe6uftiJ0Kex/UbCvA713gD5sMNu0QA7KJb4LAY1OqPcT5Hunipk0YfTnPWZ3g6Cw==", "05501320895", false, "https://picsum.photos/640/480/?image=593", "4c3cce98-9378-4a41-af78-b4b81f1477c3", false, "Baltur_Erkekli53" }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Communication",
                columns: new[] { "Id", "CreatedDate", "Email", "Message", "Name", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 17, 14, 19, 39, 250, DateTimeKind.Local).AddTicks(1017), "Bornak_Elicin@gmail.com", "Enim voluptatem ipsam mi. Modi velit dolorem doloremque aspernatur sevindi in. Dolayı sıradanlıktan gül ötekinden enim gidecekmiş. Dolayı commodi velit voluptatum beğendim. Ducimus okuma voluptatem nostrum odio. Bundan koyun koştum.", "Bağaşatulu Sadıklar", "Cezbelendi ama.", null },
                    { 2, new DateTime(2026, 1, 15, 3, 44, 34, 537, DateTimeKind.Local).AddTicks(6234), "Babir_Arican@yahoo.com", "Consequuntur eaque praesentium doloremque teldeki ama deleniti. Nesciunt voluptatem otobüs alias. Quae adresini duyulmamış suscipit velit dolor labore sed sıradanlıktan tempora.", "Altan Babaoğlu", "Nemo sit.", null },
                    { 3, new DateTime(2026, 1, 18, 6, 16, 19, 457, DateTimeKind.Local).AddTicks(3270), "Alaboru.Ertepinar@gmail.com", "Çorba gazete sarmal cezbelendi eum çıktılar. Quis odit quia ve in layıkıyla magnam quae. Dağılımı enim sandalye makinesi. Ad sequi consectetur bahar quia ea quaerat.", "Aygırak Saygıner", "Labore quis.", null },
                    { 4, new DateTime(2026, 1, 18, 19, 16, 40, 224, DateTimeKind.Local).AddTicks(1935), "Guvercin52@yahoo.com", "Gidecekmiş voluptatem velit. Filmini nisi totam veritatis labore sarmal. Filmini de consectetur beatae nostrum velit çorba sokaklarda dicta. Consequatur kulu sit ve sunt un quia.", "Adlıbeğ Kıraç ", "Lakin filmini.", null },
                    { 5, new DateTime(2026, 1, 18, 15, 19, 46, 294, DateTimeKind.Local).AddTicks(961), "Ertenozuk_Tekelioglu86@gmail.com", "Çobanın consequatur eius sandalye quia quaerat. Magni nemo gül sıla. Düşünüyor labore gitti çarpan iure öyle ex autem odio. Dağılımı exercitationem dignissimos incidunt voluptatem. Sinema dolor veritatis kapının lambadaki gitti bilgiyasayarı patlıcan.", "Buğday Karaduman", "Magnam umut.", null }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Blog",
                columns: new[] { "Id", "AdminId", "BlogImage", "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, "https://picsum.photos/640/480/?image=795", new DateTime(2026, 1, 15, 10, 36, 24, 51, DateTimeKind.Local).AddTicks(2936), "Qui telefonu dicta voluptas kutusu ekşili consectetur nemo illo vel. Eum gül voluptatem quia totam quia odio. Nihil sayfası sayfası dolores quia voluptatem eaque iure lakin. Labore voluptatem praesentium açılmadan.\n\nDergi aspernatur sed. İnventore eaque iusto gülüyorum quasi patlıcan beğendim balıkhaneye tv. Karşıdakine ki corporis vitae dolayı non sequi ipsa. Kulu sunt ki gördüm vel dolayı nostrum gülüyorum sevindi dolayı.\n\nVeritatis değerli eve aperiam aut camisi ama. Nemo sequi ışık sarmal fugit beatae çarpan sequi salladı umut. Mi kalemi nisi doğru koşuyorlar ki qui laudantium ut aliquid. Açılmadan sıla voluptatem nesciunt vitae.", "Alias quis et et ullam.", null },
                    { 2, 1, "https://picsum.photos/640/480/?image=263", new DateTime(2026, 1, 10, 17, 42, 21, 648, DateTimeKind.Local).AddTicks(2839), "Makinesi telefonu et doloremque eius aut voluptatem kulu. Şafak biber lambadaki labore nesciunt dışarı. Koyun ex de otobüs.\n\nMasaya labore inventore numquam gülüyorum batarya. Göze mi duyulmamış velit ratione labore sandalye koyun quia. Quia kulu exercitationem eos. Doloremque dolorem hesap orta adipisci için qui. Kalemi dergi aut ullam için kulu.\n\nVeniam ea qui filmini ışık. Fugit ut sed aspernatur. Eius eaque ipsa perferendis ipsam minima filmini ışık gitti dağılımı. İpsa orta sıla anlamsız filmini. İllo voluptatem sıradanlıktan quasi yapacakmış mutlu. Aliquid göze neque consequuntur eos çorba sit.", "Praesentium ad masanın veritatis filmini.", null },
                    { 3, 1, "https://picsum.photos/640/480/?image=317", new DateTime(2026, 1, 11, 17, 25, 5, 302, DateTimeKind.Local).AddTicks(1233), "Tempora okuma ad sit consequuntur aut sevindi gördüm. Architecto adresini kulu adresini tempora dergi. Eve gidecekmiş otobüs oldular. Consectetur enim fugit non hesap. Dolorem çıktılar ea aut odio filmini balıkhaneye ışık nostrum.\n\nConsequatur suscipit consequuntur masaya. Consequatur çobanın amet ve dolor ut. Sayfası sunt layıkıyla totam okuma nihil ut. Sayfası değirmeni filmini ducimus incidunt nesciunt consequuntur et laudantium. Bilgiyasayarı lambadaki corporis ekşili. Domates çünkü ona beatae aut gazete et.\n\nUt dolore dolorem. Değirmeni nesciunt okuma sokaklarda layıkıyla ut cesurca okuma. Sunt numquam göze rem de ratione voluptatem duyulmamış kapının quae. Voluptate iusto consequatur sarmal ullam dicta adanaya.", "Quia vitae şafak magnam nesciunt.", null },
                    { 4, 1, "https://picsum.photos/640/480/?image=60", new DateTime(2026, 1, 5, 6, 22, 18, 523, DateTimeKind.Local).AddTicks(1487), "Ona dignissimos sinema corporis non olduğu sit ötekinden. Voluptatum aspernatur eius nostrum sarmal totam dolor. De aperiam voluptate quis reprehenderit dergi in.\n\nSayfası kutusu tempora fugit. Nemo göze corporis magni fugit consequatur iure sarmal eaque consequatur. Olduğu hesap aperiam mıknatıslı çobanın. Cesurca gördüm enim laudantium değerli.\n\nKoştum sed domates ut qui balıkhaneye incidunt. Bilgiyasayarı eaque sarmal ki. Consequatur sit ekşili duyulmamış voluptatem sıfat deleniti telefonu dolorem. Neque explicabo eos aut sevindi anlamsız qui amet aperiam non. Teldeki autem eius sinema eum göze.", "Adresini dergi çıktılar anlamsız quia.", null },
                    { 5, 3, "https://picsum.photos/640/480/?image=210", new DateTime(2026, 1, 1, 12, 45, 17, 630, DateTimeKind.Local).AddTicks(5304), "Açılmadan magni ducimus teldeki çorba quaerat velit ut karşıdakine aut. Şafak sinema illo ad eve consequatur. Koşuyorlar adresini dolore ducimus rem. İpsum suscipit commodi sıradanlıktan. Mıknatıslı makinesi ducimus quia deleniti inventore ve sinema.\n\nNihil totam balıkhaneye eius ona balıkhaneye oldular ab. Aliquid incidunt voluptatem patlıcan aut kapının vitae ışık. Mıknatıslı beatae otobüs aliquam kutusu explicabo un. Koşuyorlar inventore tempora labore salladı sayfası ducimus sed magni.\n\nKoşuyorlar masaya cezbelendi ut voluptatem. Vitae bilgiyasayarı salladı dergi filmini velit bilgisayarı quaerat gülüyorum düşünüyor. Non alias layıkıyla biber quis quia. Layıkıyla gidecekmiş batarya laboriosam aut.", "Labore için incidunt bundan anlamsız.", null },
                    { 6, 2, "https://picsum.photos/640/480/?image=489", new DateTime(2025, 12, 28, 7, 4, 40, 846, DateTimeKind.Local).AddTicks(7229), "Şafak ea ea nihil. Aut göze koşuyorlar et bilgisayarı. İllo sed et.\n\nSit dolor molestiae et. Odio alias gitti. Lakin yaptı enim consequatur mutlu doloremque türemiş autem türemiş. Ea lakin bilgisayarı. Lakin cesurca voluptatem.\n\nDucimus ut de çünkü ea aperiam aut. Veniam autem ona magni batarya. Kapının sarmal iusto. İncidunt laudantium deleniti aut. Ducimus çobanın consequatur ad esse kulu.", "Quam aliquam sinema deleniti consectetur.", null },
                    { 7, 3, "https://picsum.photos/640/480/?image=903", new DateTime(2026, 1, 12, 8, 40, 2, 749, DateTimeKind.Local).AddTicks(8904), "Enim hesap eos karşıdakine çobanın numquam ducimus koştum gülüyorum camisi. Dolayı magnam sequi veritatis. Ve odit ut patlıcan gördüm quia. Adresini otobüs olduğu sıradanlıktan. Neque balıkhaneye eve bahar consequatur. Quam yapacakmış mıknatıslı aperiam bilgiyasayarı ad sit.\n\nAmet doloremque illo eius quaerat dağılımı sıradanlıktan aliquam odio un. Exercitationem odit yaptı reprehenderit. Yaptı et çıktılar magnam duyulmamış ut minima. Ullam gitti magnam sinema telefonu kutusu enim. Non corporis doloremque sevindi sarmal ab. Makinesi mutlu un iusto.\n\nAperiam sit nemo türemiş adresini. Sıfat ducimus ipsam ki doloremque modi mıknatıslı quia. Suscipit yapacakmış oldular düşünüyor.", "Domates koştum veritatis modi oldular.", null },
                    { 8, 1, "https://picsum.photos/640/480/?image=173", new DateTime(2026, 1, 3, 5, 10, 45, 326, DateTimeKind.Local).AddTicks(1661), "Eaque quia koyun sit quasi qui voluptatem değerli. Non sıfat teldeki accusantium reprehenderit velit camisi çobanın lakin voluptas. Mi sayfası umut alias dışarı vitae çorba fugit.\n\nNumquam architecto aliquam doloremque öyle quia suscipit. Quae salladı sayfası açılmadan salladı anlamsız salladı qui velit eos. Consequuntur dolore çorba otobüs teldeki ekşili adresini tv accusantium camisi. Türemiş karşıdakine olduğu orta dolorem lambadaki ea çıktılar mıknatıslı.\n\nİpsam sokaklarda blanditiis quis beatae. Quia filmini adanaya quasi batarya ipsum. Dergi ad beğendim velit. Sunt gidecekmiş veniam salladı ut çarpan et. Eve dolayı quam quis umut. Ut koştum ea.", "İnventore teldeki quaerat gidecekmiş velit.", null }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Comments",
                columns: new[] { "Id", "AppUserId", "AppUserId1", "BlogId", "BlogsId", "CommentSubject", "CommentText", "CreatedDate", "Email", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, 7, null, "Un alias consectetur.", "enim", new DateTime(2026, 1, 12, 12, 36, 45, 76, DateTimeKind.Local).AddTicks(3602), "Isik.Ozdogan@hotmail.com", "Buluç Baturalp", null },
                    { 2, "73d21eb2-7468-42f6-ba85-f2045d269c03", null, 1, null, "Ea gülüyorum aliquam.", "layıkıyla", new DateTime(2026, 1, 12, 20, 25, 21, 218, DateTimeKind.Local).AddTicks(2366), "Isik.Alyanak@yahoo.com", "Gülegen Uluhan", null },
                    { 3, null, null, 2, null, "Exercitationem dolore ab.", "eum", new DateTime(2026, 1, 17, 5, 14, 52, 11, DateTimeKind.Local).AddTicks(787), "Algu.Ozansoy@gmail.com", "Alptuğrul Uluhan", null },
                    { 4, null, null, 2, null, "Quia veritatis blanditiis.", "Amet veritatis balıkhaneye layıkıyla quaerat tempora voluptate odit uzattı.", new DateTime(2026, 1, 13, 18, 15, 38, 81, DateTimeKind.Local).AddTicks(167), "Bagaturcigsi_Mayhos17@yahoo.com", "Günçiçek Özdenak", null },
                    { 5, "ff719141-9016-4f96-a8ee-8a7783928650", null, 5, null, "Hesap makinesi ışık.", "Batarya quae çorba ea.", new DateTime(2026, 1, 16, 23, 35, 45, 881, DateTimeKind.Local).AddTicks(967), "Erten29@hotmail.com", "Bangu Özkök ", null },
                    { 6, null, null, 5, null, "Gördüm ama dolores.", "Mi qui masaya voluptatem ipsam türemiş totam ducimus. Koşuyorlar voluptate alias molestiae balıkhaneye. Odio ad patlıcan. Karşıdakine consequatur velit laudantium beğendim adanaya çıktılar voluptatem doloremque. Oldular düşünüyor blanditiis dignissimos magni aspernatur voluptate dicta. Voluptatem consequatur domates sayfası voluptatem laudantium consequatur dağılımı.", new DateTime(2026, 1, 12, 19, 58, 1, 295, DateTimeKind.Local).AddTicks(1948), "Ala40@gmail.com", "Altankağan Bakırcıoğlu", null },
                    { 7, null, null, 2, null, "Camisi aspernatur türemiş.", "beğendim", new DateTime(2026, 1, 12, 6, 10, 32, 798, DateTimeKind.Local).AddTicks(9260), "Aybars.Arican@yahoo.com", "Adık Tütüncü", null },
                    { 8, "73d21eb2-7468-42f6-ba85-f2045d269c03", null, 1, null, "Alias sarmal voluptatem.", "Göze bilgisayarı quia vel qui nemo kapının ut incidunt explicabo.", new DateTime(2026, 1, 15, 10, 55, 48, 493, DateTimeKind.Local).AddTicks(379), "Bolmus_Basoglu32@hotmail.com", "Adalan Akgül", null },
                    { 9, null, null, 7, null, "Eius yapacakmış reprehenderit.", "Explicabo dolayı salladı orta koyun dicta beatae aut.", new DateTime(2026, 1, 18, 20, 43, 53, 729, DateTimeKind.Local).AddTicks(7448), "Baykoca_Aybar60@hotmail.com", "Basat Keçeci", null },
                    { 10, null, null, 1, null, "Consequuntur de voluptatem.", "Autem iusto sarmal beatae aspernatur kulu.", new DateTime(2026, 1, 18, 12, 26, 28, 778, DateTimeKind.Local).AddTicks(5846), "Arnac8@yahoo.com", "Burkay Baykam", null },
                    { 11, "5a612e79-175a-487b-98e7-5ea2ba2c23e9", null, 8, null, "Voluptate architecto aperiam.", "açılmadan", new DateTime(2026, 1, 16, 3, 22, 3, 308, DateTimeKind.Local).AddTicks(4466), "Bolsun.Erberk73@hotmail.com", "Benlidemir Özberk", null },
                    { 12, "391effa3-4115-422c-a8a1-1a3b85331cac", null, 5, null, "Minima numquam sed.", "Kutusu değerli consequatur exercitationem bahar suscipit laudantium in. Eius amet telefonu magnam. Qui mutlu esse gül değirmeni vel velit inventore qui. İpsum qui eos quis quae modi molestiae değerli.", new DateTime(2026, 1, 10, 15, 28, 14, 831, DateTimeKind.Local).AddTicks(7651), "Baykoca.Orbay@yahoo.com", "Beğ Gönültaş", null },
                    { 13, "5a612e79-175a-487b-98e7-5ea2ba2c23e9", null, 6, null, "Ut dağılımı tempora.", "Gül dolorem amet. Teldeki masanın voluptatum kalemi exercitationem molestiae sıfat umut. Consectetur layıkıyla ut blanditiis mutlu quam. Mutlu ab qui aut domates consectetur numquam koştum. Aliquid türemiş quia enim incidunt lakin ea blanditiis kulu. Et çarpan ut eos ab dolore explicabo labore sit quasi.", new DateTime(2026, 1, 18, 8, 36, 18, 907, DateTimeKind.Local).AddTicks(2179), "Borlukcu.Corekci@yahoo.com", "Aktan Elçiboğa", null },
                    { 14, null, null, 2, null, "Ratione mutlu sunt.", "Reprehenderit salladı eius gidecekmiş domates.", new DateTime(2026, 1, 10, 16, 3, 4, 92, DateTimeKind.Local).AddTicks(1010), "Adli28@hotmail.com", "Boyankulu Yıldırım ", null },
                    { 15, "ff719141-9016-4f96-a8ee-8a7783928650", null, 2, null, "Reprehenderit umut gördüm.", "Fugit koyun cesurca çünkü. İnventore koştum ea laboriosam beğendim. Aliquam molestiae quia kapının patlıcan praesentium. Çarpan masaya eve sed uzattı odit orta biber consequatur aut. Numquam ducimus ex koşuyorlar esse.", new DateTime(2026, 1, 17, 9, 42, 16, 51, DateTimeKind.Local).AddTicks(7390), "Boga_Tekelioglu@hotmail.com", "Aşanboğa Dağdaş", null },
                    { 16, "ec8ca8dd-10e7-46f0-8cb7-fc62a4803a22", null, 3, null, "Dignissimos commodi ışık.", "Doğru gitti autem kulu domates balıkhaneye eos illo adanaya.\nDışarı et commodi iure incidunt.\nAmet dolayı sequi otobüs aut kalemi cezbelendi aut de.", new DateTime(2026, 1, 17, 13, 58, 10, 94, DateTimeKind.Local).AddTicks(7184), "Bokde38@gmail.com", "Burunduk Süleymanoğlu", null },
                    { 17, null, null, 6, null, "Kapının aperiam perferendis.", "Fugit numquam gitti sevindi. Exercitationem vel aliquid corporis quis rem aliquid illo eum. Consequatur velit iure sıradanlıktan yazın koşuyorlar bundan beğendim aperiam sıradanlıktan. Kalemi in ekşili incidunt dolorem öyle kutusu reprehenderit.", new DateTime(2026, 1, 19, 10, 17, 45, 393, DateTimeKind.Local).AddTicks(9798), "Belgi4@gmail.com", "Artukaç Öztonga", null },
                    { 18, null, null, 7, null, "Consequuntur çorba un.", "İure ea qui quaerat kutusu un iure cesurca değerli.", new DateTime(2026, 1, 11, 11, 21, 14, 656, DateTimeKind.Local).AddTicks(7036), "Edil_Yilmazer@hotmail.com", "Baykal Erez", null },
                    { 19, "73d21eb2-7468-42f6-ba85-f2045d269c03", null, 3, null, "Adipisci açılmadan lakin.", "Veritatis laudantium türemiş yazın koştum sit uzattı.\nDoğru consectetur sıla filmini masaya ipsam koştum anlamsız değirmeni.\nVoluptate düşünüyor ekşili corporis nemo adresini nesciunt.\nAut ad reprehenderit.\nSequi telefonu balıkhaneye.", new DateTime(2026, 1, 10, 4, 14, 34, 911, DateTimeKind.Local).AddTicks(5910), "Arik_Atan55@hotmail.com", "Benlidemir Koç", null },
                    { 20, null, null, 7, null, "Gazete quam sıla.", "Laboriosam velit gitti qui. Umut çobanın çünkü quis gülüyorum lambadaki ea. Ona gördüm labore kutusu inventore magni oldular. Numquam ipsam neque koşuyorlar kutusu ipsam quaerat un. Uzattı olduğu enim nihil. Beğendim sit çakıl consequuntur.", new DateTime(2026, 1, 12, 22, 2, 30, 632, DateTimeKind.Local).AddTicks(7173), "Amac_Yesilkaya@yahoo.com", "Ergene Yalçın", null },
                    { 21, null, null, 1, null, "Masanın aut sıfat.", "Quia değirmeni voluptatum masanın labore. Aut sit çorba sevindi eius ducimus duyulmamış vitae blanditiis dolor. Dergi voluptatem değirmeni koşuyorlar sed gül patlıcan.", new DateTime(2026, 1, 16, 21, 37, 20, 388, DateTimeKind.Local).AddTicks(146), "Bayruk18@hotmail.com", "Azban Mertoğlu", null },
                    { 22, null, null, 3, null, "Commodi sıla dergi.", "Koyun laudantium numquam quam quis. Patlıcan lakin salladı türemiş perferendis balıkhaneye suscipit dolor dicta iusto. Balıkhaneye değirmeni consectetur. Totam nisi sit iure aut adanaya. Consequuntur düşünüyor sayfası gül uzattı ama vitae. Deleniti gülüyorum nisi nostrum magnam architecto sarmal quis cesurca.", new DateTime(2026, 1, 13, 6, 42, 37, 93, DateTimeKind.Local).AddTicks(6328), "Badruk_Ozkara@yahoo.com", "Iyıktağ Nalbantoğlu", null },
                    { 23, "5a612e79-175a-487b-98e7-5ea2ba2c23e9", null, 2, null, "Consequatur aliquam gül.", "Ama okuma in gazete. Değirmeni yapacakmış değerli quasi ipsa yazın gitti ut duyulmamış sıfat. Quia değerli nemo.", new DateTime(2026, 1, 15, 0, 40, 58, 50, DateTimeKind.Local).AddTicks(3278), "Budak.Dusenkalkar53@yahoo.com", "Atıkutlu Kuday", null },
                    { 24, null, null, 4, null, "Otobüs magni sandalye.", "enim", new DateTime(2026, 1, 17, 10, 51, 55, 844, DateTimeKind.Local).AddTicks(2136), "Akata87@gmail.com", "Barsgan Aykaç", null },
                    { 25, null, null, 6, null, "Ötekinden düşünüyor sıradanlıktan.", "Ama ab odit.\nKoştum ki amet.\nYapacakmış deleniti camisi.\nExercitationem gazete praesentium.", new DateTime(2026, 1, 10, 21, 5, 49, 691, DateTimeKind.Local).AddTicks(3466), "Arbay_Cagiran@hotmail.com", "Baksı Yıldızoğlu", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AdminId",
                schema: "blg",
                table: "Blog",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                schema: "blg",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId1",
                schema: "blg",
                table: "Comments",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                schema: "blg",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogsId",
                schema: "blg",
                table: "Comments",
                column: "BlogsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Communication",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "AppUsers",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Blog",
                schema: "blg");

            migrationBuilder.DropTable(
                name: "Admin",
                schema: "blg");
        }
    }
}
