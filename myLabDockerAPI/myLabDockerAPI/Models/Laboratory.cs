using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Represents a Laboratory with all its Properties
    /// </summary>
    public class Laboratory
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
        public List<Category> Categories { get; set; }
    }
}
