﻿// <auto-generated />
using System;
using EcommerceApp.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EcommerceApp.Api.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    [Migration("20200406182226_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EcommerceApp.Api.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            Name = "Thịt heo thả rông"
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            Name = "Thịt bò hữu cơ cao cấp"
                        },
                        new
                        {
                            Id = 3,
                            Active = false,
                            Name = "Thịt bò mỹ nhập khẩu cao cấp"
                        },
                        new
                        {
                            Id = 4,
                            Active = false,
                            Name = "Rau"
                        },
                        new
                        {
                            Id = 5,
                            Active = false,
                            Name = "Hải sản"
                        },
                        new
                        {
                            Id = 6,
                            Active = false,
                            Name = "Gạo"
                        });
                });

            modelBuilder.Entity("EcommerceApp.Api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/dolorumquosculpa.bmp?size=50x50&set=set1",
                            Name = "Table Cloth 53x53 White",
                            Origin = "Australia (Úc)",
                            Price = 1022757.01m
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/ullametnihil.png?size=50x50&set=set1",
                            Name = "Graham Cracker Mix",
                            Origin = "Australia (Úc)",
                            Price = 2787180.08m
                        },
                        new
                        {
                            Id = 3,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/istenesciuntest.png?size=50x50&set=set1",
                            Name = "Cookies - Fortune",
                            Origin = "Australia (Úc)",
                            Price = 790858.73m
                        },
                        new
                        {
                            Id = 4,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/sitipsamsoluta.bmp?size=50x50&set=set1",
                            Name = "Chocolate Bar - Reese Pieces",
                            Origin = "Australia (Úc)",
                            Price = 1632710.50m
                        },
                        new
                        {
                            Id = 5,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/ipsamadipisciofficia.jpg?size=50x50&set=set1",
                            Name = "Pepsi, 355 Ml",
                            Origin = "Australia (Úc)",
                            Price = 2964218.80m
                        },
                        new
                        {
                            Id = 6,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/autaspernaturincidunt.png?size=50x50&set=set1",
                            Name = "Squash - Sunburst",
                            Origin = "Australia (Úc)",
                            Price = 1261483.90m
                        },
                        new
                        {
                            Id = 7,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/recusandaedeleniticorporis.jpg?size=50x50&set=set1",
                            Name = "Bacardi Breezer - Tropical",
                            Origin = "Australia (Úc)",
                            Price = 2201704.36m
                        },
                        new
                        {
                            Id = 8,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/beataeidrerum.png?size=50x50&set=set1",
                            Name = "Ham - Proscuitto",
                            Origin = "Australia (Úc)",
                            Price = 896790.15m
                        },
                        new
                        {
                            Id = 9,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/eligendiquodneque.jpg?size=50x50&set=set1",
                            Name = "Coffee - Beans, Whole",
                            Origin = "Australia (Úc)",
                            Price = 1110431.91m
                        },
                        new
                        {
                            Id = 10,
                            Active = false,
                            CategoryId = 1,
                            Image = "https://robohash.org/etofficiisnostrum.png?size=50x50&set=set1",
                            Name = "Rum - White, Gg White",
                            Origin = "Australia (Úc)",
                            Price = 445931.39m
                        },
                        new
                        {
                            Id = 11,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/etlaboriosameum.png?size=50x50&set=set1",
                            Name = "Sauce - Marinara",
                            Origin = "Mỹ",
                            Price = 2464557.98m
                        },
                        new
                        {
                            Id = 12,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/explicaboenimamet.bmp?size=50x50&set=set1",
                            Name = "Dill - Primerba, Paste",
                            Origin = "Mỹ",
                            Price = 2118235.41m
                        },
                        new
                        {
                            Id = 13,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/temporeoditvoluptatem.png?size=50x50&set=set1",
                            Name = "Seedlings - Clamshell",
                            Origin = "Mỹ",
                            Price = 2463560.57m
                        },
                        new
                        {
                            Id = 14,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/corruptiutblanditiis.bmp?size=50x50&set=set1",
                            Name = "Cheese - Pont Couvert",
                            Origin = "Mỹ",
                            Price = 1870262.24m
                        },
                        new
                        {
                            Id = 15,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/mollitialaboriosamrerum.jpg?size=50x50&set=set1",
                            Name = "Sage - Ground",
                            Origin = "Mỹ",
                            Price = 1597949.31m
                        },
                        new
                        {
                            Id = 16,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/velitsitvel.png?size=50x50&set=set1",
                            Name = "Yoplait - Strawbrasp Peac",
                            Origin = "Mỹ",
                            Price = 1041214.80m
                        },
                        new
                        {
                            Id = 17,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/doloremsuntvelit.jpg?size=50x50&set=set1",
                            Name = "Beef - Flank Steak",
                            Origin = "Mỹ",
                            Price = 519450.40m
                        },
                        new
                        {
                            Id = 18,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/ducimusestullam.bmp?size=50x50&set=set1",
                            Name = "Cheese - Comte",
                            Origin = "Mỹ",
                            Price = 906840.10m
                        },
                        new
                        {
                            Id = 19,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/corporisquisquamautem.jpg?size=50x50&set=set1",
                            Name = "Halibut - Steaks",
                            Origin = "Mỹ",
                            Price = 593438.97m
                        },
                        new
                        {
                            Id = 20,
                            Active = false,
                            CategoryId = 2,
                            Image = "https://robohash.org/ipsamutvoluptates.bmp?size=50x50&set=set1",
                            Name = "Tea - Decaf 1 Cup",
                            Origin = "Mỹ",
                            Price = 523438.97m
                        });
                });

            modelBuilder.Entity("EcommerceApp.Api.Models.Product", b =>
                {
                    b.HasOne("EcommerceApp.Api.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
