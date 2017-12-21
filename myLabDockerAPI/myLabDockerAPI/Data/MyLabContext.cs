using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myLabDockerAPI.Models;

namespace myLabDockerAPI.Data
{
    /// <summary>
    /// Defines the Database Context.
    /// </summary>
    public class MyLabContext : DbContext
    {
        /// <summary>
        /// Constructs the Context.
        /// </summary>
        /// <param name="options"></param>
        public MyLabContext(DbContextOptions<MyLabContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Generates a Table for Items.
        /// </summary>
        public DbSet<Item> Items { get; set; }

        /// <summary>
        /// Generates a Table for Categories.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Generates a Table for Datatypes.
        /// </summary>
        public DbSet<Datatype> Datatypes { get; set; }

        /// <summary>
        /// Generates a Table for ItemAttributes.
        /// </summary>
        public DbSet<ItemAttribute> ItemAttributes { get; set; }

        /// <summary>
        /// Generates a Table for Files.
        /// </summary>
        public DbSet<File> Files { get; set; }

        /// <summary>
        /// Generates a Table for Laboratories.
        /// </summary>
        public DbSet<Laboratory> Laboratories { get; set; }

        /// <summary>
        /// Generates a Table for NumberAttributes.
        /// </summary>
        public DbSet<NumberAttribute> NumberAttributes { get; set; }

        /// <summary>
        /// Generates a Table for RangeAttributes.
        /// </summary>
        public DbSet<RangeAttribute> RangeAttributes { get; set; }

        /// <summary>
        /// Generates a Table for TextAttributes.
        /// </summary>
        public DbSet<TextAttribute> TextAttributes { get; set; }

        /// <summary>
        /// Generates a Table for States.
        /// </summary>
        public DbSet<State> States { get; set; }

        /// <summary>
        /// Specifies extra Settings via Microsofts Fluent API
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasIndex(p => new { p.Barcode })
                .IsUnique(true);

            modelBuilder.Entity<ItemAttribute>()
                .HasDiscriminator<int>("Type")
                .HasValue<NumberAttribute>(1)
                .HasValue<RangeAttribute>(2)
                .HasValue<TextAttribute>(3);

        }
    }
}
