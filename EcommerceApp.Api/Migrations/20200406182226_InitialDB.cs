using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceApp.Api.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Origin = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Active", "CreatedTime", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, false, null, "Thịt heo thả rông", null },
                    { 2, false, null, "Thịt bò hữu cơ cao cấp", null },
                    { 3, false, null, "Thịt bò mỹ nhập khẩu cao cấp", null },
                    { 4, false, null, "Rau", null },
                    { 5, false, null, "Hải sản", null },
                    { 6, false, null, "Gạo", null }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Active", "CategoryId", "CreatedTime", "Image", "Name", "Origin", "Price", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, false, 1, null, "https://robohash.org/dolorumquosculpa.bmp?size=50x50&set=set1", "Table Cloth 53x53 White", "Australia (Úc)", 1022757.01m, null },
                    { 18, false, 2, null, "https://robohash.org/ducimusestullam.bmp?size=50x50&set=set1", "Cheese - Comte", "Mỹ", 906840.10m, null },
                    { 17, false, 2, null, "https://robohash.org/doloremsuntvelit.jpg?size=50x50&set=set1", "Beef - Flank Steak", "Mỹ", 519450.40m, null },
                    { 16, false, 2, null, "https://robohash.org/velitsitvel.png?size=50x50&set=set1", "Yoplait - Strawbrasp Peac", "Mỹ", 1041214.80m, null },
                    { 15, false, 2, null, "https://robohash.org/mollitialaboriosamrerum.jpg?size=50x50&set=set1", "Sage - Ground", "Mỹ", 1597949.31m, null },
                    { 14, false, 2, null, "https://robohash.org/corruptiutblanditiis.bmp?size=50x50&set=set1", "Cheese - Pont Couvert", "Mỹ", 1870262.24m, null },
                    { 13, false, 2, null, "https://robohash.org/temporeoditvoluptatem.png?size=50x50&set=set1", "Seedlings - Clamshell", "Mỹ", 2463560.57m, null },
                    { 12, false, 2, null, "https://robohash.org/explicaboenimamet.bmp?size=50x50&set=set1", "Dill - Primerba, Paste", "Mỹ", 2118235.41m, null },
                    { 11, false, 2, null, "https://robohash.org/etlaboriosameum.png?size=50x50&set=set1", "Sauce - Marinara", "Mỹ", 2464557.98m, null },
                    { 10, false, 1, null, "https://robohash.org/etofficiisnostrum.png?size=50x50&set=set1", "Rum - White, Gg White", "Australia (Úc)", 445931.39m, null },
                    { 9, false, 1, null, "https://robohash.org/eligendiquodneque.jpg?size=50x50&set=set1", "Coffee - Beans, Whole", "Australia (Úc)", 1110431.91m, null },
                    { 8, false, 1, null, "https://robohash.org/beataeidrerum.png?size=50x50&set=set1", "Ham - Proscuitto", "Australia (Úc)", 896790.15m, null },
                    { 7, false, 1, null, "https://robohash.org/recusandaedeleniticorporis.jpg?size=50x50&set=set1", "Bacardi Breezer - Tropical", "Australia (Úc)", 2201704.36m, null },
                    { 6, false, 1, null, "https://robohash.org/autaspernaturincidunt.png?size=50x50&set=set1", "Squash - Sunburst", "Australia (Úc)", 1261483.90m, null },
                    { 5, false, 1, null, "https://robohash.org/ipsamadipisciofficia.jpg?size=50x50&set=set1", "Pepsi, 355 Ml", "Australia (Úc)", 2964218.80m, null },
                    { 4, false, 1, null, "https://robohash.org/sitipsamsoluta.bmp?size=50x50&set=set1", "Chocolate Bar - Reese Pieces", "Australia (Úc)", 1632710.50m, null },
                    { 3, false, 1, null, "https://robohash.org/istenesciuntest.png?size=50x50&set=set1", "Cookies - Fortune", "Australia (Úc)", 790858.73m, null },
                    { 2, false, 1, null, "https://robohash.org/ullametnihil.png?size=50x50&set=set1", "Graham Cracker Mix", "Australia (Úc)", 2787180.08m, null },
                    { 19, false, 2, null, "https://robohash.org/corporisquisquamautem.jpg?size=50x50&set=set1", "Halibut - Steaks", "Mỹ", 593438.97m, null },
                    { 20, false, 2, null, "https://robohash.org/ipsamutvoluptates.bmp?size=50x50&set=set1", "Tea - Decaf 1 Cup", "Mỹ", 523438.97m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
