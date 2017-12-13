using System.ComponentModel.DataAnnotations;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Datatable for m : n Relation between Category and Item Attribute.
    /// </summary>
    public class Relation_Category_ItemAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ItemAttribute ItemAttribute { get; set; }
    }
}
