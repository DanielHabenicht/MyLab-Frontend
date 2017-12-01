using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public int LaboratoryId { get; set; }
        public bool IsTemplate { get; set; }

        public Laboratory Laboratory { get; set; }
    }
}
