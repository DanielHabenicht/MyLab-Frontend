using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<File> Files { get; set; }
    }
}
