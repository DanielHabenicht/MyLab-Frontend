using Newtonsoft.Json;
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

        public Device Device { get; set; }

        [JsonIgnore]
        public List<Relation_Category_DeviceAttribute> Relation_Category_DeviceAttribute { get; set; }

    }
}
