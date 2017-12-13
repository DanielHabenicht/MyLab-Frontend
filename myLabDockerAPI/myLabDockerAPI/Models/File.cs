using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// Class that represents a File with its Properties.
    /// </summary>
    public class File
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
        public long Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Path { get; set; }

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
        [Required]
        public long FolderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("FolderId")]
        public Folder Folder { get; set; }
    }
}
