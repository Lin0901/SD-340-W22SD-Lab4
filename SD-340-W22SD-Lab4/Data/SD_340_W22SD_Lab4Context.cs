using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Lab4.Models;

namespace SD_340_W22SD_Lab4.Data
{
    public class SD_340_W22SD_Lab4Context : DbContext
    {
        public SD_340_W22SD_Lab4Context (DbContextOptions<SD_340_W22SD_Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<SD_340_W22SD_Lab4.Models.Stop> Stop { get; set; } = default!;
        public DbSet<SD_340_W22SD_Lab4.Models.Route> Route { get; set; } = default!;
        public DbSet<SD_340_W22SD_Lab4.Models.ScheduledStop> ScheduledStop { get; set; } = default!;
    }
}
