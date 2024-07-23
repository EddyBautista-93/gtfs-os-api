using Microsoft.EntityFrameworkCore;
using gtfs_api.Models;

namespace gtfs_api.Data
{
    public class GTFSDbContext : DbContext
    {
        
        public GTFSDbContext(DbContextOptions<GTFSDbContext> options) : base(options)
        {
        }
        
        public DbSet<Models.Route> Routes { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=gtfs.db");
            }   
        }
    }
}