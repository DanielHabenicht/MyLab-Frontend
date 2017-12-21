using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myLabDockerAPI.Models
{
    /// <summary> 
    /// A Inventory Item with its Properties.
    /// </summary>
    public class Item
    {
        /// <summary>  
        ///  The unique Id of the Item.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>  
        ///  The Title of the Item.
        /// </summary>
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Der Titel kann maximal 50 Zeichen lang sein.")]
        [Required]
        public string Title { get; set; }

        /// <summary>  
        ///  The unqique Barcode of the Item.
        /// </summary>
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string Barcode { get; set; }

        /// <summary>  
        ///  The Location of the Item.  
        /// </summary>
        public string Location { get; set; }

        /// <summary> 
        /// The Comment to the Item.
        /// </summary>
        public string Comment { get; set; }

        /// <summary> 
        /// The Foreign Keys for the Item Attributes.
        /// </summary>
        public List<ItemAttribute> ItemAttributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public long CategoryId { get; set; }
        /// <summary> 
        /// The Foreign Key of the Item Category.
        /// </summary>
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int StateId { get; set; }
        /// <summary> 
        /// The Foreign Key of the Item State.
        /// </summary>
        [ForeignKey("StateId")]
        public State State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Update(Item item)
        {
            this.Barcode = item.Barcode;
            this.Category = item.Category;
            this.Comment = item.Comment;
            this.Location = item.Location;
            this.ItemAttributes = item.ItemAttributes;
            this.State = item.State;
            this.Title = item.Title;
        }
    }
}
