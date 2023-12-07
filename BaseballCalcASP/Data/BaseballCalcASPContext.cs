using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaseballCalcASP.Models;

namespace BaseballCalcASP.Data
{
    public class BaseballCalcASPContext : DbContext
    {
        public BaseballCalcASPContext (DbContextOptions<BaseballCalcASPContext> options)
            : base(options)
        {
        }

        public DbSet<BaseballCalcASP.Models.Team> Teams { get; set; } = default!;

        public DbSet<BaseballCalcASP.Models.Player>? Players { get; set; }

        public DbSet<BaseballCalcASP.Models.Season>? Seasons { get; set; }
    }
}
