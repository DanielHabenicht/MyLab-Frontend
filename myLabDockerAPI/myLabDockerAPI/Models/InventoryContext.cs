using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myLabDockerAPI.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Device> DeviceItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Datatype> Datatypes { get; set; }
        public DbSet<DeviceAttribute> DeviceAttributes { get; set; }
        public DbSet<DeviceAttribute_Category_Relation> DeviceAttribute_Category_Relations { get; set; }
        public DbSet<File> FIless { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<NumberValue> NumberValues { get; set; }
        public DbSet<RangeValue> RangeValues { get; set; }
        public DbSet<TextValue> TextValues { get; set; }
    }
}
