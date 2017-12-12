using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myLabDockerAPI.Models;

namespace myLabDockerAPI.Data
{
    public class MyLabContext : DbContext
    {
        public MyLabContext(DbContextOptions<MyLabContext> options)
            : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Datatype> Datatypes { get; set; }
        public DbSet<DeviceAttribute> DeviceAttributes { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<NumberAttribute> NumberAttributes { get; set; }
        public DbSet<RangeAttribute> RangeAttributes { get; set; }
        public DbSet<TextAttribute> TextAttributes { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>()
                .HasIndex(p => new { p.InventoryNumber })
                .IsUnique(true);
        }
    }
}
