using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Represents a Folder with its Properties.
    /// </summary>
    public class Folder
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<File> Files { get; set; }
    }
}
