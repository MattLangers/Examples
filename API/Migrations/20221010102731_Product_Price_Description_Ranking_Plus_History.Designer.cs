﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221010102731_Product_Price_Description_Ranking_Plus_History")]
    partial class Product_Price_Description_Ranking_Plus_History
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Database.Models.Hitory.ProductDescriptionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ToDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDescriptionHistory");
                });

            modelBuilder.Entity("Database.Models.Hitory.ProductNameHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductNameHistory");
                });

            modelBuilder.Entity("Database.Models.Hitory.ProductPriceHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("From")
                        .HasColumnType("smallmoney");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("To")
                        .HasColumnType("smallmoney");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductPriceHistory");
                });

            modelBuilder.Entity("Database.Models.Hitory.ProductRankingHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<short>("From")
                        .HasColumnType("smallint");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("To")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductRankingHistory");
                });

            modelBuilder.Entity("Database.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f284aa7d-f280-4f81-9435-4b43b24e7bc7"),
                            Archived = false,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1561),
                            Name = "Sherbet Fountain",
                            ProductTypeId = 10
                        },
                        new
                        {
                            Id = new Guid("36e3555a-4d12-455b-9915-17260e798840"),
                            Archived = false,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1592),
                            Name = "Cadbury Creme Egg",
                            ProductTypeId = 11
                        },
                        new
                        {
                            Id = new Guid("611622e1-5c10-4e7e-a7d5-43d1457179d7"),
                            Archived = false,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1598),
                            Name = "Curly Wurly",
                            ProductTypeId = 11
                        },
                        new
                        {
                            Id = new Guid("ae942935-a413-4c83-8d0f-5c87ed468f79"),
                            Archived = false,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1602),
                            Name = "Liquorice Allsorts",
                            ProductTypeId = 7
                        },
                        new
                        {
                            Id = new Guid("c67a4aff-699f-4ba2-8513-7731864c6efe"),
                            Archived = false,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1607),
                            Name = "Coconut Mushrooms",
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = new Guid("822bea15-489a-49ac-bc05-32cc6a05e2ec"),
                            Archived = false,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1610),
                            Name = "Jelly Babies",
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = new Guid("faea9f16-a461-463d-a70e-051fb130fbd0"),
                            Archived = false,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1613),
                            Name = "Dolly Mixtures",
                            ProductTypeId = 2
                        });
                });

            modelBuilder.Entity("Database.Models.ProductDescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductDescription");
                });

            modelBuilder.Entity("Database.Models.ProductPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("smallmoney");

                    b.HasKey("Id");

                    b.ToTable("ProductPrice");
                });

            modelBuilder.Entity("Database.Models.ProductPublished", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductPublished");
                });

            modelBuilder.Entity("Database.Models.ProductRanking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<short>("Rank")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("ProductRanking");
                });

            modelBuilder.Entity("Database.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1489),
                            Name = "Boiled"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1498),
                            Name = "Chewy"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1499),
                            Name = "BubbleGum"
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1501),
                            Name = "Fizzy"
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1502),
                            Name = "Marshmallow"
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1504),
                            Name = "Jellies"
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1505),
                            Name = "Liquorice"
                        },
                        new
                        {
                            Id = 8,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1507),
                            Name = "Lollipops"
                        },
                        new
                        {
                            Id = 9,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1509),
                            Name = "Mints"
                        },
                        new
                        {
                            Id = 10,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1511),
                            Name = "Sherbet"
                        },
                        new
                        {
                            Id = 11,
                            CreationDate = new DateTime(2022, 10, 10, 10, 27, 31, 282, DateTimeKind.Utc).AddTicks(1512),
                            Name = "Chocolate"
                        });
                });

            modelBuilder.Entity("Database.Models.Hitory.ProductDescriptionHistory", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithMany("ProductDescriptionHistory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.Hitory.ProductNameHistory", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithMany("ProductNameHistory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.Hitory.ProductPriceHistory", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithMany("ProductPriceHistory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.Hitory.ProductRankingHistory", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithMany("ProductRankingHistory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.Product", b =>
                {
                    b.HasOne("Database.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Database.Models.ProductDescription", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithOne("Description")
                        .HasForeignKey("Database.Models.ProductDescription", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.ProductPrice", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithOne("Price")
                        .HasForeignKey("Database.Models.ProductPrice", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.ProductPublished", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithOne("ProductPublished")
                        .HasForeignKey("Database.Models.ProductPublished", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.ProductRanking", b =>
                {
                    b.HasOne("Database.Models.Product", "Product")
                        .WithOne("Ranking")
                        .HasForeignKey("Database.Models.ProductRanking", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Database.Models.Product", b =>
                {
                    b.Navigation("Description")
                        .IsRequired();

                    b.Navigation("Price")
                        .IsRequired();

                    b.Navigation("ProductDescriptionHistory");

                    b.Navigation("ProductNameHistory");

                    b.Navigation("ProductPriceHistory");

                    b.Navigation("ProductPublished")
                        .IsRequired();

                    b.Navigation("ProductRankingHistory");

                    b.Navigation("Ranking")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
