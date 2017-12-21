using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Defines the States of a Item.
    /// </summary>
    public class State
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public List<Item> Items { get; set; }
    }
}
