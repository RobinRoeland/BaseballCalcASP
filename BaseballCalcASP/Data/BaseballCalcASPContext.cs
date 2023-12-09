using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaseballCalcASP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace BaseballCalcASP.Data
{
    public class BaseballCalcASPContext : IdentityDbContext
    {
        public BaseballCalcASPContext (DbContextOptions<BaseballCalcASPContext> options)
            : base(options)
        {
        }

        public DbSet<BaseballCalcASP.Models.Team> Teams { get; set; } = default!;

        public DbSet<BaseballCalcASP.Models.Player>? Players { get; set; }

        public DbSet<BaseballCalcASP.Models.Season>? Seasons { get; set; }


        // any unique string id
        string ADMIN_ID = Guid.NewGuid().ToString("D");
        string USR1_ID = Guid.NewGuid().ToString("D");

        string ADMINROLE_ID = Guid.NewGuid().ToString("D");
        string USERROLE_ID = Guid.NewGuid().ToString("D");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())//.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("BaseballCalcASPContext");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            this.SeedRoles(modelBuilder);
            this.SeedUsers(modelBuilder);
            this.SeedUserRoles(modelBuilder);

            this.SeedTeams (modelBuilder);
            this.SeedPlayers(modelBuilder);
            this.SeedSeasons(modelBuilder);
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = ADMINROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            },
            new IdentityRole
            {
                Id = USERROLE_ID,
                Name = "user",
                NormalizedName = "user"
            });
        }
        private void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin@testemail.com",
                NormalizedUserName = "ADMIN@TESTEMAIL.COM",
                Email = "admin@testemail.com",
                NormalizedEmail = "ADMIN@TESTEMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Start123#"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                PhoneNumberConfirmed = true
            },
            new IdentityUser
            {
                Id = USR1_ID,
                UserName = "user1@testemail.com",
                NormalizedUserName = "USER1@TESTEMAIL.COM",
                Email = "user1@testemail.com",
                NormalizedEmail = "USER1@TESTEMAIL.COM",
                EmailConfirmed = true,//false,
                PasswordHash = hasher.HashPassword(null, "Start123#"),
                SecurityStamp = Guid.NewGuid().ToString("D"), //string.Empty,
                PhoneNumberConfirmed = true
            });
        }
        private void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = ADMINROLE_ID,
                UserId = ADMIN_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = USERROLE_ID,
                UserId = USR1_ID
            });
        }

        private void SeedTeams(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Id = 1,
				Name = "Waldos",
                TotalPlayers = 2
            },
            new Team
            {
                Id = 2,
				Name = "Bebops",
                TotalPlayers = 2
            },
            new Team
            {
                Id = 3,
				Name = "Foxes",
                TotalPlayers = 2
            },
            new Team
            {
                Id = 4,
				Name = "Kangeroos",
                TotalPlayers = 1
            });
        }
        private void SeedPlayers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
            new Player
            {
                Id = 1,
                Name = "Waldo",
				TeamId = 1,
				DOB = DateTime.ParseExact("05-12-2004 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            },
            new Player
            {
                Id = 2,
                Name = "Waldo2",
				TeamId = 1,
				DOB = DateTime.ParseExact("12-04-2004 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            },
            new Player
            {
                Id = 3,
                Name = "Kangoeroe",
				TeamId = 4,
				DOB = DateTime.ParseExact("15-03-2003 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            },
            new Player
            {
                Id = 4,
                Name = "Test",
				TeamId = 2,
				DOB = DateTime.ParseExact("03-02-2006 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            },
            new Player
            {
                Id = 5,
                Name = "Test2",
				TeamId = 2,
				DOB = DateTime.ParseExact("27-08-2006 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            },
            new Player
            {
                Id = 6,
                Name = "A1",
				TeamId = 2,
				DOB = DateTime.ParseExact("04-03-2005 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            },
            new Player
            {
                Id = 7,
                Name = "A2",
				TeamId = 3,
				DOB = DateTime.ParseExact("02-07-2006 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            },
            new Player
            {
                Id = 8,
                Name = "A3",
				TeamId = 3,
				DOB = DateTime.ParseExact("04-12-2008 12:00 am", "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture)
            });
        }
        private void SeedSeasons(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Season>().HasData(
            new Season
            {
                Id = 1,
				PlayerKey = 8,
				GamesPlayed = 3,
				Year = 2023,
				PlateAppearences = 7,
				HStrikeOuts = 2,
				Hits = 3,
				Singles = 1,
				Doubles = 2,
				Triples = 0,
				HomeRuns = 0,
				BaseOnBalls = 1,
				HitByPitch = 1,
				SacrificeFlies = 0,
				SacrificeHits = 0,
				CaughtStealing = 2,
				StolenBases = 4,
				Runs = 3,
				Errors = 1,
				DoublePlays = 0,
				TriplePlays = 0,
				PassedBalls = 0,
				PStrikeOuts = 0
            },
            new Season
            {
                Id = 2,
				PlayerKey = 6,
				GamesPlayed = 4,
				Year = 2023,
				PlateAppearences = 7,
				HStrikeOuts = 4,
				Hits = 2,
				Singles = 1,
				Doubles = 2,
				Triples = 0,
				HomeRuns = 0,
				BaseOnBalls = 1,
				HitByPitch = 1,
				SacrificeFlies = 0,
				SacrificeHits = 0,
				CaughtStealing = 2,
				StolenBases = 1,
				Runs = 3,
				Errors = 1,
				DoublePlays = 0,
				TriplePlays = 0,
				PassedBalls = 0,
				PStrikeOuts = 0
            });
        }
    }
}
