using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class TextValue
    {
        public long Id { get; set; }
        public long DeviceId { get; set; }
        public long DeviceAttributeId { get; set; }
        public string Value { get; set; }

        public Device Device { get; set; }
        public DeviceAttribute DeviceAttribute { get; set; }
    }
}
