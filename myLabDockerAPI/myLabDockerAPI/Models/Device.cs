using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class Device
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string InventoryNumber { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }
        public string State { get; set; }
    }
}
