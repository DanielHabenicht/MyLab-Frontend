using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class RangeAttribute : DeviceAttribute
    {
        public float LowerValue { get; set; }
        public float HigherValue { get; set; }

    }
}
