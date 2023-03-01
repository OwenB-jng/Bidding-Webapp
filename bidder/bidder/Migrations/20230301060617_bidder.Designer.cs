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
    [Migration("20230301060617_bidder")]
    partial class bidder
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

                    b.Property<string>("condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("Id");

                    b.ToTable("Auctions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            condition = "New",
                            endTime = new DateTime(2023, 3, 1, 1, 6, 17, 401, DateTimeKind.Local).AddTicks(9137),
                            image = "Buffalo",
                            itemDescription = "Buffalo",
                            itemName = "Buffalo",
                            startTime = new DateTime(2023, 3, 1, 1, 6, 17, 401, DateTimeKind.Local).AddTicks(9104),
                            startingBid = 15.0,
                            type = "Buffalo"
                        });
                });

            modelBuilder.Entity("bidder.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"), 1L, 1);

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
                            buyer = true,
                            email = "buyer@gmail.com",
                            firstName = "buy",
                            lastName = "er",
                            password = "buyer",
                            passwordConfirm = "buyer",
                            seller = false,
                            username = "buyer",
                            verifiedStatus = false
                        },
                        new
                        {
                            userID = 2,
                            buyer = false,
                            email = "seller@gmail.com",
                            firstName = "sel",
                            lastName = "ler",
                            password = "seller",
                            passwordConfirm = "seller",
                            seller = true,
                            username = "seller",
                            verifiedStatus = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
