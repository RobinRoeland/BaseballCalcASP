﻿// <auto-generated />
using System;
using BaseballCalcASP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseballCalcASP.Migrations
{
    [DbContext(typeof(BaseballCalcASPContext))]
    [Migration("20231210140304_addedDeleted")]
    partial class addedDeleted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BaseballCalcASP.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rugnummer")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2004, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Waldo",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(2004, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Waldo2",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(2003, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Kangoeroe",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 4,
                            DOB = new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Test",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 5,
                            DOB = new DateTime(2006, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "Test2",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 6,
                            DOB = new DateTime(2005, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "A1",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 7,
                            DOB = new DateTime(2006, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "A2",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 8,
                            DOB = new DateTime(2008, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Name = "A3",
                            TeamId = 3
                        });
                });

            modelBuilder.Entity("BaseballCalcASP.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BaseOnBalls")
                        .HasColumnType("int");

                    b.Property<int>("CaughtStealing")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("DoublePlays")
                        .HasColumnType("int");

                    b.Property<int>("Doubles")
                        .HasColumnType("int");

                    b.Property<int>("Errors")
                        .HasColumnType("int");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("HStrikeOuts")
                        .HasColumnType("int");

                    b.Property<int>("HitByPitch")
                        .HasColumnType("int");

                    b.Property<int>("Hits")
                        .HasColumnType("int");

                    b.Property<int>("HomeRuns")
                        .HasColumnType("int");

                    b.Property<int>("PStrikeOuts")
                        .HasColumnType("int");

                    b.Property<int>("PassedBalls")
                        .HasColumnType("int");

                    b.Property<int>("PlateAppearences")
                        .HasColumnType("int");

                    b.Property<int>("PlayerKey")
                        .HasColumnType("int");

                    b.Property<int>("Runs")
                        .HasColumnType("int");

                    b.Property<int>("SacrificeFlies")
                        .HasColumnType("int");

                    b.Property<int>("SacrificeHits")
                        .HasColumnType("int");

                    b.Property<int>("Singles")
                        .HasColumnType("int");

                    b.Property<int>("StolenBases")
                        .HasColumnType("int");

                    b.Property<int>("TriplePlays")
                        .HasColumnType("int");

                    b.Property<int>("Triples")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseOnBalls = 1,
                            CaughtStealing = 2,
                            Deleted = false,
                            DoublePlays = 0,
                            Doubles = 2,
                            Errors = 1,
                            GamesPlayed = 3,
                            HStrikeOuts = 2,
                            HitByPitch = 1,
                            Hits = 3,
                            HomeRuns = 0,
                            PStrikeOuts = 0,
                            PassedBalls = 0,
                            PlateAppearences = 7,
                            PlayerKey = 8,
                            Runs = 3,
                            SacrificeFlies = 0,
                            SacrificeHits = 0,
                            Singles = 1,
                            StolenBases = 4,
                            TriplePlays = 0,
                            Triples = 0,
                            Year = 2023
                        },
                        new
                        {
                            Id = 2,
                            BaseOnBalls = 1,
                            CaughtStealing = 2,
                            Deleted = false,
                            DoublePlays = 0,
                            Doubles = 2,
                            Errors = 1,
                            GamesPlayed = 4,
                            HStrikeOuts = 4,
                            HitByPitch = 1,
                            Hits = 2,
                            HomeRuns = 0,
                            PStrikeOuts = 0,
                            PassedBalls = 0,
                            PlateAppearences = 7,
                            PlayerKey = 6,
                            Runs = 3,
                            SacrificeFlies = 0,
                            SacrificeHits = 0,
                            Singles = 1,
                            StolenBases = 1,
                            TriplePlays = 0,
                            Triples = 0,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("BaseballCalcASP.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPlayers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Waldos",
                            TotalPlayers = 2
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Bebops",
                            TotalPlayers = 2
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            Name = "Foxes",
                            TotalPlayers = 2
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            Name = "Kangeroos",
                            TotalPlayers = 1
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

                    b.HasData(
                        new
                        {
                            Id = "cd955ee2-869c-4b6d-a487-99ef087fe66c",
                            ConcurrencyStamp = "ee82da03-32a8-440c-ba1b-26e30e3580ac",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = "f6326ae0-d212-4a46-87d0-abae83b2c4ad",
                            ConcurrencyStamp = "aed1b6c5-84c1-4399-92b9-15df9bee4a7a",
                            Name = "user",
                            NormalizedName = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "fa0c3432-795d-4316-abc3-ffbdcf849fc5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8c492e82-7dd3-4885-9eef-430f6bb3a08c",
                            Email = "admin@testemail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TESTEMAIL.COM",
                            NormalizedUserName = "ADMIN@TESTEMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFtL6EYhrWgeWaKdy0GKtu+L+wJjKHB16R+BGRFVCjOgKjJ82PzlwchQ0UZ2CzVMaQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fe3ed45b-faed-4d8b-9487-d304a5b319ad",
                            TwoFactorEnabled = false,
                            UserName = "admin@testemail.com"
                        },
                        new
                        {
                            Id = "6520247f-384c-4b0b-94a7-260c5cc8304a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "af58277f-952a-4ea2-a899-86eec607db0d",
                            Email = "user1@testemail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@TESTEMAIL.COM",
                            NormalizedUserName = "USER1@TESTEMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENwUUkHakgCOa3cuOoASiSk4nmxVU4PZNDL2ufgsw7HFi+LXgxSqfHNbpB8nVt6NOw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "099c0084-d1c2-448e-ab2f-d71e815add91",
                            TwoFactorEnabled = false,
                            UserName = "user1@testemail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "fa0c3432-795d-4316-abc3-ffbdcf849fc5",
                            RoleId = "cd955ee2-869c-4b6d-a487-99ef087fe66c"
                        },
                        new
                        {
                            UserId = "6520247f-384c-4b0b-94a7-260c5cc8304a",
                            RoleId = "f6326ae0-d212-4a46-87d0-abae83b2c4ad"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BaseballCalcASP.Models.Player", b =>
                {
                    b.HasOne("BaseballCalcASP.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
