using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiqri.AssetManagement.Models
{
    public class AssetDatabaseContext: DbContext
    {
        public AssetDatabaseContext(DbContextOptions<AssetDatabaseContext> options)
         : base(options)
        { }

        public DbSet<Asset> Assets { get; set; }
        //public DbSet<Location> Locations{ get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<AssetType> AssetTypes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>()
              .Property(b => b.UpdatedDate)
              .HasDefaultValueSql("getdate()");
        }
    }
}
