﻿using System.ComponentModel.DataAnnotations;

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
        public long ItemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FolderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Folder Folder { get; set; }
    }
}
