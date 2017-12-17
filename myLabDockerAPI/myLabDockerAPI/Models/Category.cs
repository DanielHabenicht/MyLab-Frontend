using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// A Category with its Properties.
    /// </summary>
    public class Category
    {
        /// <summary> 
        /// The unique Id of the Category.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary> 
        /// The Title of the Category
        /// </summary>
        public string Title { get; set; }

        /// <summary> 
        /// The Comment to the Category.
        /// </summary>
        public string Comment { get; set; }

        /// <summary> 
        /// Determines if the Category is a Template or not.
        /// </summary>
        public bool IsTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public long LaboratoryId { get; set; }
        /// <summary> 
        /// The Foreign Key of the Category State.
        /// </summary>
        [ForeignKey("LaboratoryId")]
        public Laboratory Laboratory { get; set; }

        /// <summary> 
        /// The Foreign Key of the Item State.
        /// </summary>
        [JsonIgnore]
        public List<Relation_Category_ItemAttribute> Relation_Category_ItemAttribute { get; set; }
    }
}
