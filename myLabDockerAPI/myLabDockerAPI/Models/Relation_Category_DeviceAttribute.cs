using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class Relation_Category_DeviceAttribute
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public DeviceAttribute DeviceAttribute { get; set; }
    }
}
