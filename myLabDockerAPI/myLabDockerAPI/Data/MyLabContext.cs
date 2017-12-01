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
        public DbSet<DeviceAttribute_Category_Relation> DeviceAttribute_Category_Relations { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<NumberValue> NumberValues { get; set; }
        public DbSet<RangeValue> RangeValues { get; set; }
        public DbSet<TextValue> TextValues { get; set; }
    }
}
