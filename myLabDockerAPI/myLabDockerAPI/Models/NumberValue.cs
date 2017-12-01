using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class NumberValue
    {
        public long Id { get; set; }
        public long DeviceId { get; set; }
        public long DeviceAttributeId { get; set; }
        public float Value { get; set; }

        public Device Device { get; set; }
        public DeviceAttribute DeviceAttribute { get; set; }
    }
}
