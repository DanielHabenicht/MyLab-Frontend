using System.ComponentModel.DataAnnotations.Schema;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Specifies an Attribute with Range Fields.
    /// </summary>
    [Table("RangeAttributes")]
    public class RangeAttribute : ItemAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        //public RangeAttribute()
        //{
        //    this.Type = AttributeType.Range;
        //}

        /// <summary>
        /// 
        /// </summary>
        public float LowerValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float HigherValue { get; set; }

    }
}
