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
    [Migration("20231208115600_InitialDBSetup")]
    partial class InitialDBSetup
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
                            Name = "Waldo",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(2004, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Waldo2",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(2003, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kangoeroe",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 4,
                            DOB = new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Test",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 5,
                            DOB = new DateTime(2006, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Test2",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 6,
                            DOB = new DateTime(2005, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "A1",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 7,
                            DOB = new DateTime(2006, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "A2",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 8,
                            DOB = new DateTime(2008, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            Name = "Waldos",
                            TotalPlayers = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bebops",
                            TotalPlayers = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Foxes",
                            TotalPlayers = 2
                        },
                        new
                        {
                            Id = 4,
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
                            Id = "f50c8c6f-dcf5-46cb-9aba-107228c881e5",
                            ConcurrencyStamp = "a7ffa28e-7250-4b01-90d7-7f19882821a7",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = "860f5f7d-9aeb-46ed-ac22-0dacca773827",
                            ConcurrencyStamp = "0796fcb2-a2cb-4ed6-a33c-ceea2c8f306c",
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
                            Id = "d0c205d6-e3ff-4ebe-99d9-f8f707b7a3d6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f29be239-cdc7-4efe-bcfc-4d645cf892a1",
                            Email = "admin@testemail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@testemail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEMTSuOvi3QmFwsMUWBMa+6GPXIfhrBepVPzRpQcR+qFhtw8i1Faf95Vc0qG87Hs8tA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "c3d575c6-4f0e-4e22-a624-62ac45ecb94e",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "e1163262-2cf8-42bc-bf52-08f5b8d0c4f9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4effcce1-40c3-4556-9cb3-4dd8c0b27b8a",
                            Email = "user1@testemail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "user1@testemail.com",
                            NormalizedUserName = "user1",
                            PasswordHash = "AQAAAAEAACcQAAAAEFB/KrsMSujD0mJRtYNFg7vgoXOi6x2ufkC+e5ySviERnLKctWOYU4Whr02iO2NbqA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7bad6b30-9ffa-4c77-ab2d-370c3403e94c",
                            TwoFactorEnabled = false,
                            UserName = "user1"
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
                            UserId = "d0c205d6-e3ff-4ebe-99d9-f8f707b7a3d6",
                            RoleId = "f50c8c6f-dcf5-46cb-9aba-107228c881e5"
                        },
                        new
                        {
                            UserId = "e1163262-2cf8-42bc-bf52-08f5b8d0c4f9",
                            RoleId = "860f5f7d-9aeb-46ed-ac22-0dacca773827"
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
