﻿// <auto-generated />
using System;
using Inventory.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Data.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20241005122939_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Inventory.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 530, DateTimeKind.Local).AddTicks(335),
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 533, DateTimeKind.Local).AddTicks(3942),
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 533, DateTimeKind.Local).AddTicks(3985),
                            Name = "Groceries"
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 533, DateTimeKind.Local).AddTicks(3990),
                            Name = "Furniture"
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 533, DateTimeKind.Local).AddTicks(3993),
                            Name = "Accessories"
                        });
                });

            modelBuilder.Entity("Inventory.Data.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte?>("Rating")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 534, DateTimeKind.Local).AddTicks(7818),
                            Email_Address = "pyramidsmail@pyr.com",
                            Name = "Misr Pyramids Group",
                            Phone_Number = "01523456789",
                            Rating = (byte)7
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 534, DateTimeKind.Local).AddTicks(9478),
                            Email_Address = "hero@basics.com",
                            Name = "Hero Basics",
                            Phone_Number = "01555456789",
                            Rating = (byte)5
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 534, DateTimeKind.Local).AddTicks(9499),
                            Email_Address = "Resi@trade.com",
                            Name = "Resi Trade",
                            Phone_Number = "01529999999",
                            Rating = (byte)9
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 534, DateTimeKind.Local).AddTicks(9503),
                            Email_Address = "Lamar@gmail.com",
                            Name = "lamar",
                            Phone_Number = "01522233333",
                            Rating = (byte)3
                        });
                });

            modelBuilder.Entity("KoalaInventoryManagement.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 536, DateTimeKind.Local).AddTicks(1790),
                            Description = "Flags Products",
                            Name = "Palestine Flag",
                            Price = 9m
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 536, DateTimeKind.Local).AddTicks(3560),
                            Description = "Guns Products",
                            Name = "Gun AK-74",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 536, DateTimeKind.Local).AddTicks(3583),
                            Description = "Food Products",
                            Name = "زبادي",
                            Price = 3m
                        });
                });

            modelBuilder.Entity("KoalaInventoryManagement.Models.WareHouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("WareHouses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 535, DateTimeKind.Local).AddTicks(5372),
                            Name = "Section A"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 535, DateTimeKind.Local).AddTicks(6193),
                            Name = "Section B"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2024, 10, 5, 15, 29, 34, 535, DateTimeKind.Local).AddTicks(6213),
                            Name = "Section C"
                        });
                });

            modelBuilder.Entity("KoalaInventoryManagement.Models.WareHouseProduct", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("WareHouseID")
                        .HasColumnType("int");

                    b.Property<short>("CurrentStock")
                        .HasColumnType("smallint");

                    b.Property<short>("MaxStock")
                        .HasColumnType("smallint");

                    b.Property<short>("MinStock")
                        .HasColumnType("smallint");

                    b.HasKey("ProductID", "WareHouseID");

                    b.HasIndex("WareHouseID");

                    b.ToTable("WareHousesProducts");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            WareHouseID = 1,
                            CurrentStock = (short)20,
                            MaxStock = (short)50,
                            MinStock = (short)10
                        },
                        new
                        {
                            ProductID = 1,
                            WareHouseID = 2,
                            CurrentStock = (short)15,
                            MaxStock = (short)40,
                            MinStock = (short)5
                        },
                        new
                        {
                            ProductID = 2,
                            WareHouseID = 3,
                            CurrentStock = (short)12,
                            MaxStock = (short)30,
                            MinStock = (short)7
                        },
                        new
                        {
                            ProductID = 2,
                            WareHouseID = 1,
                            CurrentStock = (short)8,
                            MaxStock = (short)25,
                            MinStock = (short)3
                        },
                        new
                        {
                            ProductID = 3,
                            WareHouseID = 2,
                            CurrentStock = (short)5,
                            MaxStock = (short)10,
                            MinStock = (short)4
                        },
                        new
                        {
                            ProductID = 3,
                            WareHouseID = 3,
                            CurrentStock = (short)20,
                            MaxStock = (short)50,
                            MinStock = (short)15
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("KoalaInventoryManagement.Models.WareHouseProduct", b =>
                {
                    b.HasOne("KoalaInventoryManagement.Models.Product", "Product")
                        .WithMany("WareHouseProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KoalaInventoryManagement.Models.WareHouse", "WareHouse")
                        .WithMany("WareHouseProducts")
                        .HasForeignKey("WareHouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("WareHouse");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Inventory.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Inventory.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Inventory.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KoalaInventoryManagement.Models.Product", b =>
                {
                    b.Navigation("WareHouseProducts");
                });

            modelBuilder.Entity("KoalaInventoryManagement.Models.WareHouse", b =>
                {
                    b.Navigation("WareHouseProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
