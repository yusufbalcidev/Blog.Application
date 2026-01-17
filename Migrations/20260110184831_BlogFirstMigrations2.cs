using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Application.Migrations
{
    /// <inheritdoc />
    public partial class BlogFirstMigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Admin_AdminsId",
                schema: "blg",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Members_MembersId",
                schema: "blg",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MembersId",
                schema: "blg",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Blog_AdminsId",
                schema: "blg",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "MembersId",
                schema: "blg",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AdminsId",
                schema: "blg",
                table: "Blog");

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UserName" },
                values: new object[] { new DateTime(2025, 12, 11, 19, 42, 14, 207, DateTimeKind.Local).AddTicks(9197), "Xs7GWxyi", "Alpulug.Adal" });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UserName" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 35, 42, 637, DateTimeKind.Local).AddTicks(4807), "aUFdiDvX", "Arsun_Ozansoy93" });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UserName" },
                values: new object[] { new DateTime(2025, 2, 14, 9, 35, 28, 502, DateTimeKind.Local).AddTicks(9479), "XTPwfgca", "Bugduz.Evliyaoglu81" });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Blog",
                columns: new[] { "Id", "AdminId", "BlogImage", "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, "https://picsum.photos/640/480/?image=336", new DateTime(2026, 1, 4, 12, 6, 1, 460, DateTimeKind.Local).AddTicks(5689), "Qui koyun makinesi totam amet ve eos filmini. Domates kulu bilgiyasayarı gördüm açılmadan. Sıla çorba perferendis. Bilgisayarı mıknatıslı sarmal umut corporis dolorem un.\n\nOlduğu sayfası cezbelendi illo kulu cezbelendi ipsam otobüs. Doloremque bundan deleniti architecto dolayı ducimus. Camisi non eos değirmeni ab gördüm çünkü.\n\nExplicabo laudantium yaptı. Perferendis sit düşünüyor ullam aut et blanditiis labore quis velit. Sed çıktılar ve yaptı dergi bilgiyasayarı. Duyulmamış corporis molestiae voluptas göze çıktılar nesciunt. Doloremque olduğu eos sinema beğendim. Sayfası koyun makinesi.", "Laudantium karşıdakine voluptate koşuyorlar de.", null },
                    { 2, 3, "https://picsum.photos/640/480/?image=336", new DateTime(2025, 12, 27, 7, 51, 12, 707, DateTimeKind.Local).AddTicks(1770), "Quaerat otobüs biber quis aut. Nemo magnam quam salladı adanaya telefonu suscipit. Quam domates adipisci dignissimos nisi türemiş gidecekmiş ut sit.\n\nSevindi aliquid adanaya velit dolore sokaklarda gülüyorum. Çıktılar modi velit. Koştum öyle hesap ea. Tempora dolayı qui yazın yapacakmış.\n\nSalladı neque sevindi sunt kapının. Qui aliquam balıkhaneye gül. Sevindi hesap ducimus amet ona oldular koyun totam sequi. Çıktılar mutlu non voluptas ea sunt aspernatur ve voluptatem nostrum. Alias adanaya uzattı modi iure koşuyorlar aut.", "Dignissimos ea magnam voluptate aspernatur.", null },
                    { 3, 1, "https://picsum.photos/640/480/?image=1053", new DateTime(2025, 12, 20, 11, 48, 16, 778, DateTimeKind.Local).AddTicks(6780), "Layıkıyla nemo adresini minima dolores. İure gitti çünkü eius çobanın eaque ipsum tv umut teldeki. Enim dolores fugit labore sarmal.\n\nRem makinesi voluptatem perferendis. Bilgisayarı ratione sit aperiam odio lambadaki mıknatıslı dışarı duyulmamış. Düşünüyor consectetur numquam kapının gazete layıkıyla nostrum dağılımı tv. Doloremque ratione odit. İllo aspernatur çakıl sevindi labore praesentium qui. Gazete hesap nihil accusantium voluptatem beğendim dolore.\n\nOdio aliquam quia dolore karşıdakine nesciunt qui değerli koşuyorlar. Sıfat ullam quis adresini deleniti fugit masanın. Ratione gülüyorum sıfat veritatis sokaklarda. Gül gitti suscipit. Göze sinema beğendim qui vitae odio gazete enim layıkıyla magni.", "Işık kutusu layıkıyla nostrum veritatis.", null },
                    { 4, 1, "https://picsum.photos/640/480/?image=985", new DateTime(2025, 12, 15, 9, 9, 59, 133, DateTimeKind.Local).AddTicks(9484), "Eaque sandalye doloremque. Laudantium ekşili ekşili quae salladı explicabo velit tv olduğu gidecekmiş. Sed gitti enim. Adanaya illo quaerat ducimus inventore.\n\nOdio adipisci ut qui teldeki değerli öyle anlamsız. Ut eaque çobanın qui açılmadan masanın kulu ışık. İpsa enim koşuyorlar ötekinden beatae kalemi adipisci. Ullam açılmadan lambadaki yapacakmış voluptatem architecto. Autem aut velit sarmal aliquid. Koyun sandalye ipsam mi beatae.\n\nŞafak sed nostrum adanaya. Dağılımı duyulmamış bilgisayarı modi. Teldeki kalemi sarmal alias voluptate consectetur velit. Ducimus gazete çünkü layıkıyla ducimus. Sıradanlıktan ötekinden alias ipsa teldeki dolayı masaya.", "Minima koşuyorlar masanın cezbelendi yazın.", null },
                    { 5, 2, "https://picsum.photos/640/480/?image=619", new DateTime(2025, 12, 15, 13, 34, 34, 398, DateTimeKind.Local).AddTicks(7462), "Sandalye için exercitationem ipsa minima in consequatur nihil teldeki. Veniam okuma uzattı orta. Kulu bundan değirmeni totam dolorem accusantium sevindi.\n\nMinima praesentium kulu amet kutusu et eve. Exercitationem masanın ipsum nesciunt ipsam adanaya layıkıyla dolor düşünüyor. Uzattı illo un.\n\nAperiam koştum vel kapının koyun. Patlıcan biber yazın odit hesap batarya. Gülüyorum sed dolorem gidecekmiş magni gül. Doloremque doloremque iusto.", "Ex yapacakmış quaerat velit duyulmamış.", null }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Comment",
                columns: new[] { "Id", "CommentSubject", "CommentText", "CreatedDate", "Email", "MemberId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Non açılmadan göze.", "rem", new DateTime(2026, 1, 3, 1, 16, 15, 255, DateTimeKind.Local).AddTicks(5477), "Belek.Ozbey@gmail.com", 8, "Kezlik Gümüşpala", null },
                    { 2, "Gidecekmiş quia reprehenderit.", "Aliquid sayfası filmini mutlu gitti ötekinden dolorem beatae ullam. Mi ki dağılımı doloremque mi değirmeni voluptatem tempora praesentium lambadaki. İnventore sayfası ona alias mi quia de. Karşıdakine layıkıyla ullam dolorem hesap magnam. Lakin sed kapının. Corporis ut velit vitae nesciunt yapacakmış çobanın gördüm.", new DateTime(2026, 1, 7, 5, 42, 59, 907, DateTimeKind.Local).AddTicks(6389), "Altintamgan.Dalkiran@gmail.com", 6, "Alptegin Tanrıkulu", null },
                    { 3, "Sandalye qui nemo.", "Gülüyorum quis makinesi enim.\nQuis blanditiis dicta masanın consequatur kalemi magni accusantium dolor ut.\nOldular gazete dolayı yaptı nisi.\nNumquam ut değirmeni sevindi.\nDicta ut dışarı.", new DateTime(2026, 1, 10, 4, 13, 0, 384, DateTimeKind.Local).AddTicks(8658), "Bonek_Balaban@gmail.com", 10, "Belgüc Körmükçü", null },
                    { 4, "Consequuntur sit ipsa.", "salladı", new DateTime(2026, 1, 4, 10, 49, 28, 478, DateTimeKind.Local).AddTicks(3403), "Bukaktutuk53@yahoo.com", 9, "Elkin Küçükler", null },
                    { 5, "Adresini gülüyorum consequatur.", "Ex dolor yaptı duyulmamış quam consequatur.\nUllam sıla masaya eius anlamsız aperiam.\nEnim cesurca kapının yaptı lakin.\nGidecekmiş deleniti makinesi fugit quia mi sit.", new DateTime(2026, 1, 3, 15, 45, 20, 531, DateTimeKind.Local).AddTicks(8474), "Ilbilge53@hotmail.com", 1, "Borçul Egeli", null },
                    { 6, "Dolorem et ışık.", "Sevindi aliquam ekşili otobüs minima gördüm totam un consequatur adanaya. Şafak sıla iure adanaya. Accusantium quia vitae. Corporis sıradanlıktan bilgiyasayarı quis illo biber mutlu.", new DateTime(2026, 1, 2, 9, 31, 2, 596, DateTimeKind.Local).AddTicks(5821), "Alperen6@yahoo.com", 4, "Beker Tokgöz", null },
                    { 7, "Exercitationem kutusu et.", "Karşıdakine masaya consequuntur biber.", new DateTime(2026, 1, 8, 12, 2, 41, 720, DateTimeKind.Local).AddTicks(1882), "Berginsenge.Karaduman@hotmail.com", 4, "Çimen Adal", null },
                    { 8, "Aut alias sıla.", "çünkü", new DateTime(2026, 1, 8, 8, 24, 27, 599, DateTimeKind.Local).AddTicks(9192), "Karak_Egeli@hotmail.com", 10, "Bağa Karadaş", null },
                    { 9, "Salladı reprehenderit qui.", "Consectetur sunt ona gidecekmiş okuma eaque.", new DateTime(2026, 1, 1, 8, 25, 14, 508, DateTimeKind.Local).AddTicks(9130), "Aygirak_Karabulut30@gmail.com", 4, "Basut Yılmazer", null },
                    { 10, "Reprehenderit uzattı blanditiis.", "Tempora mutlu quasi telefonu incidunt layıkıyla mi.\nEos ötekinden qui sarmal molestiae consequatur sed layıkıyla çorba.\nSıradanlıktan enim adresini.\nKi yazın ullam quae ama dolayı eos.\nQuia fugit corporis aut voluptatem lambadaki gitti yaptı.\nDucimus koştum dignissimos.", new DateTime(2026, 1, 2, 14, 19, 36, 196, DateTimeKind.Local).AddTicks(7090), "Baltaci.Ekici@hotmail.com", 2, "Alpagut Erbulak", null },
                    { 11, "İure commodi teldeki.", "ışık", new DateTime(2026, 1, 10, 10, 37, 9, 567, DateTimeKind.Local).AddTicks(302), "Alper.Basoglu@gmail.com", 3, "Arık Arıcan", null },
                    { 12, "De minima commodi.", "Beğendim çorba yazın. Masanın non şafak gül nesciunt numquam dolorem. Neque veritatis adresini sit non sinema. Ratione lambadaki lakin voluptatem gül iure sayfası consequatur için ama.", new DateTime(2026, 1, 3, 10, 57, 11, 311, DateTimeKind.Local).AddTicks(4484), "Basti35@yahoo.com", 5, "Arıkağan Koç", null },
                    { 13, "Karşıdakine explicabo consequuntur.", "Aperiam dolores sinema quis ona aliquid voluptatem. Sıfat laboriosam dağılımı adipisci doğru. Koşuyorlar beğendim qui quis doloremque makinesi dışarı.", new DateTime(2026, 1, 4, 15, 17, 53, 768, DateTimeKind.Local).AddTicks(1579), "Kirgavul38@hotmail.com", 4, "Barlıbay Denkel", null },
                    { 14, "Açılmadan koştum layıkıyla.", "Ut quis sit mıknatıslı sıradanlıktan ona laboriosam aliquid ötekinden voluptatem.\nTeldeki ea quia koyun laboriosam doğru praesentium modi masanın.\nEnim ratione domates olduğu sunt cezbelendi filmini un sokaklarda bilgiyasayarı.\nBeğendim voluptatem esse uzattı masanın quis dolores rem et.", new DateTime(2026, 1, 10, 11, 3, 8, 947, DateTimeKind.Local).AddTicks(8769), "Bokde.Tuglu93@yahoo.com", 5, "Aygırak Tuğlu", null },
                    { 15, "Nemo fugit odit.", "Bilgiyasayarı dolores fugit commodi un eve iusto tempora.", new DateTime(2026, 1, 8, 21, 37, 35, 322, DateTimeKind.Local).AddTicks(8668), "Baykara.Avan@yahoo.com", 10, "Ağlamış Erkekli", null }
                });

            migrationBuilder.InsertData(
                schema: "blg",
                table: "Communication",
                columns: new[] { "Id", "CreatedDate", "Email", "Message", "Name", "Subject", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 6, 15, 54, 28, 893, DateTimeKind.Local).AddTicks(4511), "Dururbunsuz_Dalkiran45@gmail.com", "Lakin voluptatum enim quasi et. Un nisi ama öyle umut modi dolorem balıkhaneye. Patlıcan alias consequatur praesentium sit. Velit in nostrum voluptatem reprehenderit domates. Voluptatem magnam ab architecto ona nostrum ut beğendim.", "Bilgiç Karaer", "Magnam cezbelendi.", null },
                    { 2, new DateTime(2026, 1, 6, 15, 36, 52, 833, DateTimeKind.Local).AddTicks(330), "Aral_Bolatli29@hotmail.com", "İnventore non suscipit accusantium domates voluptate modi patlıcan. Değerli ea dolore autem. Quae voluptate et sıradanlıktan voluptatum quis. Kalemi quia umut. Sit ea consequuntur veritatis dolayı. Quis corporis quia teldeki enim ve dolores sevindi ullam.", "Alpata Tekelioğlu", "Commodi bilgisayarı.", null },
                    { 3, new DateTime(2026, 1, 8, 12, 45, 2, 292, DateTimeKind.Local).AddTicks(4162), "Akbas.Sezek@hotmail.com", "Sed sit tv. Alias quaerat koşuyorlar açılmadan voluptas ipsam architecto. Amet iusto koşuyorlar.", "Balaban Akgül", "Dicta esse.", null },
                    { 4, new DateTime(2026, 1, 7, 20, 5, 17, 239, DateTimeKind.Local).AddTicks(1318), "Caba_Dogan@yahoo.com", "Layıkıyla deleniti koşuyorlar aut alias sayfası koşuyorlar. Nihil velit iusto gitti ratione voluptatem rem. Eum sunt oldular sed nostrum layıkıyla açılmadan de. İnventore layıkıyla tv balıkhaneye bilgiyasayarı değerli voluptatem consequuntur suscipit lakin. Çıktılar sayfası doğru uzattı voluptas olduğu velit telefonu otobüs ut. Koyun gitti enim bundan koşuyorlar architecto ex eaque gidecekmiş.", "Ayızdağ Dağdaş", "İpsam bahar.", null },
                    { 5, new DateTime(2026, 1, 10, 3, 37, 16, 407, DateTimeKind.Local).AddTicks(5095), "Baltur.Sezek28@hotmail.com", "Numquam domates amet sit lambadaki quia gitti mutlu qui anlamsız. Ut et ducimus. Otobüs dağılımı sevindi ve aperiam totam gördüm sinema sıla voluptatum. Gördüm sıla ad koştum architecto. Quia ea corporis ducimus ab qui iusto camisi. Neque bilgiyasayarı çorba ve ab molestiae odit.", "Asuğ Örge", "Rem koyun.", null }
                });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "58", new DateTime(2025, 5, 1, 7, 47, 16, 66, DateTimeKind.Local).AddTicks(3391), "Akibudak72@hotmail.com", "Barkdurmuş", "Akan", "oKmv5SgI5Z", 9827996 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "58", new DateTime(2025, 2, 22, 10, 53, 15, 771, DateTimeKind.Local).AddTicks(8874), "Acik.Demirel@hotmail.com", "Adberilgen", "Akman", "lMS9i5R3F9", 3639888 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "32", new DateTime(2025, 9, 15, 20, 3, 14, 130, DateTimeKind.Local).AddTicks(807), "Isik3@gmail.com", "Bengi", "Erberk", "jFuxVHPRd2", 5657393 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "45", new DateTime(2025, 11, 27, 9, 58, 9, 442, DateTimeKind.Local).AddTicks(4721), "Alpamis_Mayhos88@gmail.com", "Kezlik", "Öymen", "gDSIecwqb9", 8441234 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "33", new DateTime(2025, 10, 4, 4, 41, 11, 856, DateTimeKind.Local).AddTicks(2266), "Atasu55@yahoo.com", "Akpıra", "Akyüz", "I9D930dE2F", 3232194 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "31", new DateTime(2025, 7, 2, 20, 24, 48, 954, DateTimeKind.Local).AddTicks(7729), "Askin.Eronat22@hotmail.com", "Abakan", "Abadan", "xN5ycjcI56", 7739958 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "32", new DateTime(2025, 7, 28, 7, 19, 28, 887, DateTimeKind.Local).AddTicks(8339), "Gulemen6@hotmail.com", "Aydemir", "Baykam", "WOKhy3gcdK", 4025494 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "47", new DateTime(2025, 3, 14, 6, 35, 25, 454, DateTimeKind.Local).AddTicks(4381), "Berkyaruk_Oraloglu57@gmail.com", "Atıkutlutaş", "Dağlaroğlu", "_JqBRy4iuk", 1832736 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "63", new DateTime(2025, 12, 30, 19, 13, 38, 346, DateTimeKind.Local).AddTicks(2691), "Burulgu.Atakol95@yahoo.com", "Bökde", "Tazegül", "xxo1q6p3fp", 6366399 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "30", new DateTime(2025, 5, 5, 19, 8, 34, 225, DateTimeKind.Local).AddTicks(9254), "Bengi82@gmail.com", "Eğrim", "Saygıner", "R7SPmrHdLW", 9540697 });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberId",
                schema: "blg",
                table: "Comment",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AdminId",
                schema: "blg",
                table: "Blog",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Admin_AdminId",
                schema: "blg",
                table: "Blog",
                column: "AdminId",
                principalSchema: "blg",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Members_MemberId",
                schema: "blg",
                table: "Comment",
                column: "MemberId",
                principalSchema: "blg",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Admin_AdminId",
                schema: "blg",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Members_MemberId",
                schema: "blg",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MemberId",
                schema: "blg",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Blog_AdminId",
                schema: "blg",
                table: "Blog");

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Blog",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Blog",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Blog",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Blog",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Blog",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Comment",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Communication",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Communication",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Communication",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Communication",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "blg",
                table: "Communication",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "MembersId",
                schema: "blg",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdminsId",
                schema: "blg",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UserName" },
                values: new object[] { new DateTime(2025, 7, 15, 5, 18, 59, 976, DateTimeKind.Local).AddTicks(3459), "sG7p18vO", "Anil56" });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UserName" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 50, 32, 714, DateTimeKind.Local).AddTicks(8097), "n2fd9Wu1", "Bulan.Aclan" });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Admin",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UserName" },
                values: new object[] { new DateTime(2024, 10, 11, 13, 39, 45, 974, DateTimeKind.Local).AddTicks(2211), "R2pY1fcv", "Baykal.Yildirim83" });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "34", new DateTime(2025, 6, 14, 21, 55, 38, 55, DateTimeKind.Local).AddTicks(307), "Baymunke.Sinanoglu88@hotmail.com", "Bulmuş", "Barbarosoğlu", "EKT1tm6QYr", 2802150 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "53", new DateTime(2025, 10, 3, 0, 43, 57, 845, DateTimeKind.Local).AddTicks(7745), "Alpertunga_Velioglu@gmail.com", "Aladoğan", "Aclan", "pzCyvMv_G5", 4793339 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "23", new DateTime(2025, 5, 5, 5, 5, 16, 856, DateTimeKind.Local).AddTicks(5267), "Baldu78@yahoo.com", "Işığ", "Ertepınar", "oCf3y6SDt0", 1771156 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "58", new DateTime(2025, 4, 21, 14, 49, 34, 941, DateTimeKind.Local).AddTicks(2220), "Barlibay_Akgul60@hotmail.com", "Beçkem", "Pektemek", "kUbr1_BjNS", 7835622 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "29", new DateTime(2025, 12, 31, 16, 0, 22, 59, DateTimeKind.Local).AddTicks(5408), "Dururbunsuz62@hotmail.com", "Ceyhun", "Çatalbaş", "aZczRi5KTr", 9225076 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "64", new DateTime(2025, 3, 5, 0, 15, 33, 635, DateTimeKind.Local).AddTicks(2379), "Beg39@yahoo.com", "Bozkurt", "Çetiner", "Ns_LYNToqa", 9122321 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "49", new DateTime(2025, 3, 8, 15, 40, 36, 377, DateTimeKind.Local).AddTicks(5284), "Alpbilge.Tekelioglu88@yahoo.com", "Bulut", "Yalçın", "ondrJeTbaP", 3475922 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "49", new DateTime(2025, 5, 12, 14, 44, 1, 110, DateTimeKind.Local).AddTicks(9450), "Balkik93@gmail.com", "Etil", "Tunçeri", "IYk7dVLj8I", 2233570 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "45", new DateTime(2025, 11, 8, 20, 4, 55, 35, DateTimeKind.Local).AddTicks(8489), "Azban.Daglaroglu@gmail.com", "Aşan", "Çetin", "SypE3B2R9P", 5697001 });

            migrationBuilder.UpdateData(
                schema: "blg",
                table: "Members",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CreatedDate", "Email", "Firstame", "LastName", "PassWord", "PhoneNumber" },
                values: new object[] { "35", new DateTime(2025, 12, 21, 14, 7, 16, 163, DateTimeKind.Local).AddTicks(7678), "Adli.Cagiran@gmail.com", "Alparslan", "Tazegül", "AVO3xqtRoe", 3692632 });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MembersId",
                schema: "blg",
                table: "Comment",
                column: "MembersId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AdminsId",
                schema: "blg",
                table: "Blog",
                column: "AdminsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Admin_AdminsId",
                schema: "blg",
                table: "Blog",
                column: "AdminsId",
                principalSchema: "blg",
                principalTable: "Admin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Members_MembersId",
                schema: "blg",
                table: "Comment",
                column: "MembersId",
                principalSchema: "blg",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
