using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainWatchSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace TrainWatchSystem.DAL
{
    internal class TrainWatchContext: DbContext
    {
        
            public TrainWatchContext()
            {

            }

            public TrainWatchContext(DbContextOptions<TrainWatchContext> options) : base(options)
            {

            }

            //We need DBsets (set of data from the database) for each entity
            public DbSet<DbVersion> DbVersions { get; set; }
            public DbSet<RailCarType> RailCarTypes { get; set; }
            public DbSet<RollingStock> RollingStock { get; set; }
        
    }
}
