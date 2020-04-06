using EcommerceApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Api.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Thịt heo thả rông", },
                new Category { Id = 2, Name = "Thịt bò hữu cơ cao cấp", },
                new Category { Id = 3, Name = "Thịt bò mỹ nhập khẩu cao cấp", },
                new Category { Id = 4, Name = "Rau", },
                new Category { Id = 5, Name = "Hải sản", },
                new Category { Id = 6, Name = "Gạo", }
            );

            modelBuilder.Entity<Product>().HasData(
                //Category 1
                new Product { Id = 1, Name = "Table Cloth 53x53 White", Price = 1022757.01M, Image = "https://robohash.org/dolorumquosculpa.bmp?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 2, Name = "Graham Cracker Mix", Price = 2787180.08M, Image = "https://robohash.org/ullametnihil.png?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 3, Name = "Cookies - Fortune", Price = 790858.73M, Image = "https://robohash.org/istenesciuntest.png?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 4, Name = "Chocolate Bar - Reese Pieces", Price = 1632710.50M, Image = "https://robohash.org/sitipsamsoluta.bmp?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 5, Name = "Pepsi, 355 Ml", Price = 2964218.80M, Image = "https://robohash.org/ipsamadipisciofficia.jpg?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 6, Name = "Squash - Sunburst", Price = 1261483.90M, Image = "https://robohash.org/autaspernaturincidunt.png?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 7, Name = "Bacardi Breezer - Tropical", Price = 2201704.36M, Image = "https://robohash.org/recusandaedeleniticorporis.jpg?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 8, Name = "Ham - Proscuitto", Price = 896790.15M, Image = "https://robohash.org/beataeidrerum.png?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 9, Name = "Coffee - Beans, Whole", Price = 1110431.91M, Image = "https://robohash.org/eligendiquodneque.jpg?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                new Product { Id = 10, Name = "Rum - White, Gg White", Price = 445931.39M, Image = "https://robohash.org/etofficiisnostrum.png?size=50x50&set=set1", Origin = "Australia (Úc)", CategoryId = 1 },
                //Category 2
                new Product
                {
                    Id = 11,
                    Name = "Sauce - Marinara",
                    Price = 2464557.98M,
                    Image = "https://robohash.org/etlaboriosameum.png?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 12,
                    Name = "Dill - Primerba, Paste",
                    Price = 2118235.41M,
                    Image = "https://robohash.org/explicaboenimamet.bmp?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 13,
                    Name = "Seedlings - Clamshell",
                    Price = 2463560.57M,
                    Image = "https://robohash.org/temporeoditvoluptatem.png?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 14,
                    Name = "Cheese - Pont Couvert",
                    Price = 1870262.24M,
                    Image = "https://robohash.org/corruptiutblanditiis.bmp?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 15,
                    Name = "Sage - Ground",
                    Price = 1597949.31M,
                    Image = "https://robohash.org/mollitialaboriosamrerum.jpg?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 16,
                    Name = "Yoplait - Strawbrasp Peac",
                    Price = 1041214.80M,
                    Image = "https://robohash.org/velitsitvel.png?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 17,
                    Name = "Beef - Flank Steak",
                    Price = 519450.40M,
                    Image = "https://robohash.org/doloremsuntvelit.jpg?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 18,
                    Name = "Cheese - Comte",
                    Price = 906840.10M,
                    Image = "https://robohash.org/ducimusestullam.bmp?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 19,
                    Name = "Halibut - Steaks",
                    Price = 593438.97M,
                    Image = "https://robohash.org/corporisquisquamautem.jpg?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 20,
                    Name = "Tea - Decaf 1 Cup",
                    Price = 523438.97M,
                    Image = "https://robohash.org/ipsamutvoluptates.bmp?size=50x50&set=set1",
                    Origin = "Mỹ",
                    CategoryId = 2
                }
            );
        }
    }
}
