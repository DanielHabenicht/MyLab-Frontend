using System.ComponentModel.DataAnnotations.Schema;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Specifies an Attribute with Number Field.
    /// </summary>
    [Table("NumberAttributes")]
    public class NumberAttribute : ItemAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        //public NumberAttribute()
        //{
        //    this.Type = AttributeType.Number;
        //}
        /// <summary>
        /// 
        /// </summary>
        public float Value { get; set; }
    }
}
