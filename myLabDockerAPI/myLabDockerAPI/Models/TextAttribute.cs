using System.ComponentModel.DataAnnotations.Schema;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Specifies an Attribute with Text Field.
    /// </summary>
    [Table("TextAttributes")]
    public class TextAttribute : ItemAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        //public TextAttribute()
        //{
        //    this.Type = AttributeType.Text;
        //}


        /// <summary>
        /// 
        /// </summary>
        public string Text { get; set; }

    }
}
