using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gtfs_api.Data;

namespace gtfs_api.Data
{
    public class GTFSDbContext : DbContext
    {
        
        public GTFSDbContext(DbContextOptions<GTFSDbContext> options) : base(options)
        {
        }
        
        public DbSet<Route> Routes { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=gtfs.db");
            }   
        }
    }
}