﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bidder.Data;

#nullable disable

namespace bidder.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20230415023837_downtothewire")]
    partial class downtothewire
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("bidder.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("currentBid")
                        .HasColumnType("float");

                    b.Property<DateTime>("endTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("startingBid")
                        .HasColumnType("float");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("winnerId")
                        .HasColumnType("int");

                    b.Property<double>("winningBid")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Auctions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorId = 2,
                            condition = "New",
                            currentBid = 0.0,
                            endTime = new DateTime(2023, 4, 14, 22, 38, 37, 100, DateTimeKind.Local).AddTicks(7000),
                            image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/African_buffalo_%28Syncerus_caffer_caffer%29_male_with_cattle_egret.jpg/1200px-African_buffalo_%28Syncerus_caffer_caffer%29_male_with_cattle_egret.jpg",
                            itemDescription = "Buffalo",
                            itemName = "Buffalo",
                            startTime = new DateTime(2023, 4, 14, 22, 38, 37, 100, DateTimeKind.Local).AddTicks(6967),
                            startingBid = 15.0,
                            type = "Buffalo",
                            winningBid = 15.0
                        },
                        new
                        {
                            Id = 2,
                            CreatorId = 2,
                            condition = "New",
                            currentBid = 15.0,
                            endTime = new DateTime(2023, 4, 21, 21, 18, 37, 100, DateTimeKind.Local).AddTicks(7007),
                            image = "https://static.displate.com/857x1200/displate/2020-11-13/82125307287b2e5a94c8cfb31e6ecc79_27a3dc812489a692d79f3ef7d63be919.jpg",
                            itemDescription = "Signed by us",
                            itemName = "Mark Ruffalo Signed Poster",
                            startTime = new DateTime(2023, 4, 14, 22, 38, 37, 100, DateTimeKind.Local).AddTicks(7006),
                            startingBid = 15.0,
                            type = "Collectibe",
                            winningBid = 0.0
                        });
                });

            modelBuilder.Entity("bidder.Models.Bid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("AuctionID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionID");

                    b.HasIndex("UserID");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("bidder.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("bidder.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("reviewer")
                        .HasColumnType("int");

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("userID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("bidder.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"), 1L, 1);

                    b.Property<bool>("admin")
                        .HasColumnType("bit");

                    b.Property<bool>("buyer")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwordConfirm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("seller")
                        .HasColumnType("bit");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("verifiedStatus")
                        .HasColumnType("bit");

                    b.HasKey("userID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userID = 1,
                            admin = false,
                            buyer = true,
                            email = "buyer@gmail.com",
                            firstName = "buy",
                            lastName = "er",
                            password = "123Password1$",
                            passwordConfirm = "123Password1$",
                            seller = false,
                            username = "buyer",
                            verifiedStatus = true
                        },
                        new
                        {
                            userID = 2,
                            admin = false,
                            buyer = false,
                            email = "seller@gmail.com",
                            firstName = "sel",
                            lastName = "ler",
                            password = "123Password1$",
                            passwordConfirm = "123Password1$",
                            seller = true,
                            username = "seller",
                            verifiedStatus = true
                        },
                        new
                        {
                            userID = 3,
                            admin = true,
                            buyer = true,
                            email = "admin@gmail.com",
                            firstName = "ad",
                            lastName = "min",
                            password = "123Password1$",
                            passwordConfirm = "123Password1$",
                            seller = false,
                            username = "admin",
                            verifiedStatus = true
                        });
                });

            modelBuilder.Entity("bidder.Auction", b =>
                {
                    b.HasOne("bidder.Models.User", "Creator")
                        .WithMany("CreatedAuctions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("bidder.Models.Bid", b =>
                {
                    b.HasOne("bidder.Auction", "Auction")
                        .WithMany("Bids")
                        .HasForeignKey("AuctionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bidder.Models.User", "User")
                        .WithMany("Bids")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("bidder.Models.Cart", b =>
                {
                    b.HasOne("bidder.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("bidder.Models.Review", b =>
                {
                    b.HasOne("bidder.Models.User", null)
                        .WithMany("reviews")
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("bidder.Auction", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("bidder.Models.User", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("Carts");

                    b.Navigation("CreatedAuctions");

                    b.Navigation("reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
