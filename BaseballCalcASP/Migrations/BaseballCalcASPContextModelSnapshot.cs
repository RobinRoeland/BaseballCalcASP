﻿// <auto-generated />
using System;
using BaseballCalcASP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseballCalcASP.Migrations
{
    [DbContext(typeof(BaseballCalcASPContext))]
    partial class BaseballCalcASPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("BaseballCalcASP.Models.Player", b =>
                {
                    b.HasOne("BaseballCalcASP.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
