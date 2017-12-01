using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class DeviceAttribute_Category_Relation
    {
        public int Id { get; set; }
        public long CategoryId { get; set; }
        public long DeviceAttributeId { get; set; }

        public Category Category { get; set; }
        public DeviceAttribute DeviceAttribute { get; set; }
    }
}
