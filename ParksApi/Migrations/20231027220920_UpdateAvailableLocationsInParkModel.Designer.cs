﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

#nullable disable

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20231027220920_UpdateAvailableLocationsInParkModel")]
    partial class UpdateAvailableLocationsInParkModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ParksApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "abc123",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a4e81f6c-2576-41c1-ae67-8edadbf1ea4f",
                            Email = "james@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JAMES@TEST.COM",
                            NormalizedUserName = "JOEY",
                            PasswordHash = "AQAAAAEAACcQAAAAEFiGGmGq1feweu0CF9R71/E3DtSIoFBn8Kak7hyxjnLKiR7xoIaAq+DaqeaS6f7yDA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "58eda642-a978-42f1-8926-e4f49d25b70e",
                            TwoFactorEnabled = false,
                            UserName = "James"
                        },
                        new
                        {
                            Id = "def456",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2b1ff46b-a531-4f1e-8c2c-c738f3d2823c",
                            Email = "mary@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MARY@TEST.COM",
                            NormalizedUserName = "MARY",
                            PasswordHash = "AQAAAAEAACcQAAAAECzawBnaJR0wQFyXB1nZgmCtA7bd4zQe7n1MmIc1gISi9lFxNg/pWARov37nw5OBBg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b52cc749-df24-4cef-9e08-c1aeae1d9f5d",
                            TwoFactorEnabled = false,
                            UserName = "Mary"
                        });
                });

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Authority")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Authority = "National",
                            Location = "CA",
                            Name = "Yosemite National Park"
                        },
                        new
                        {
                            ParkId = 2,
                            Authority = "National",
                            Location = "CA",
                            Name = "Joshua Tree National Park"
                        },
                        new
                        {
                            ParkId = 3,
                            Authority = "National",
                            Location = "CA",
                            Name = "Sequoia National Park"
                        },
                        new
                        {
                            ParkId = 4,
                            Authority = "National",
                            Location = "CA",
                            Name = "Channel Islands National Park"
                        },
                        new
                        {
                            ParkId = 5,
                            Authority = "National",
                            Location = "CA",
                            Name = "Death Valley National Park"
                        },
                        new
                        {
                            ParkId = 6,
                            Authority = "National",
                            Location = "CA",
                            Name = "Kings Canyon National Park"
                        },
                        new
                        {
                            ParkId = 7,
                            Authority = "State",
                            Location = "CA",
                            Name = "Point Mugu Park"
                        },
                        new
                        {
                            ParkId = 8,
                            Authority = "State",
                            Location = "CA",
                            Name = "El Presidio de Santa Barbara State Historic Park"
                        },
                        new
                        {
                            ParkId = 9,
                            Authority = "State",
                            Location = "CA",
                            Name = "Monterey State Beach"
                        },
                        new
                        {
                            ParkId = 10,
                            Authority = "State",
                            Location = "CA",
                            Name = "Tahoe State Recreation Area"
                        },
                        new
                        {
                            ParkId = 11,
                            Authority = "National",
                            Location = "AK",
                            Name = "Denali National Park and Preserve"
                        },
                        new
                        {
                            ParkId = 12,
                            Authority = "National",
                            Location = "AK",
                            Name = "Kenai Fjords National Park"
                        },
                        new
                        {
                            ParkId = 13,
                            Authority = "National",
                            Location = "AK",
                            Name = "Gates of the Artic National Park and Preserve"
                        },
                        new
                        {
                            ParkId = 14,
                            Authority = "National",
                            Location = "AK",
                            Name = "Glacier Bay National Park and Preserve"
                        },
                        new
                        {
                            ParkId = 15,
                            Authority = "National",
                            Location = "AK",
                            Name = "Katmai National Park and Preserve"
                        },
                        new
                        {
                            ParkId = 16,
                            Authority = "National",
                            Location = "AK",
                            Name = "Wrangell-St Elias National Park and Preserve"
                        },
                        new
                        {
                            ParkId = 17,
                            Authority = "State",
                            Location = "AK",
                            Name = "Chugach State Park"
                        },
                        new
                        {
                            ParkId = 18,
                            Authority = "State",
                            Location = "AK",
                            Name = "Kachemak Bay State Park"
                        },
                        new
                        {
                            ParkId = 19,
                            Authority = "State",
                            Location = "AK",
                            Name = "Wood-TikChik State Park"
                        });
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
                    b.HasOne("ParksApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ParksApi.Models.ApplicationUser", null)
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

                    b.HasOne("ParksApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ParksApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
