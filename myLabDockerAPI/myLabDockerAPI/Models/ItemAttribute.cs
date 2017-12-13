﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public int ItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public List<Relation_Category_ItemAttribute> Relation_Category_ItemAttribute { get; set; }

    }
}
