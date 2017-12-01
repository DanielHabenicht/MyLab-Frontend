using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class DeviceAttribute
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long DatatypeId { get; set; }

        public Datatype Datatype { get; set; }
    }
}
