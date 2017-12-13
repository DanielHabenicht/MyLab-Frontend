using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Represents the Attribute a Item can have, with all its Properties.
    /// </summary>
    public class ItemAttribute
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
        [Required]
        public long ItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public List<Relation_Category_ItemAttribute> Relation_Category_ItemAttribute { get; set; }

    }
}
