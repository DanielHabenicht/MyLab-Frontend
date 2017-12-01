using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class File
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long DeviceId { get; set; }
        public string Path { get; set; }

        public Device Device { get; set; }
    }
}
