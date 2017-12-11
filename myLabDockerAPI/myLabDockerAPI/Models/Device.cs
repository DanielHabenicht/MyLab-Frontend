using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    public class Device
    {
        public long Id { get; set; }
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Der Titel kann maximal 50 Zeichen lang sein.")]
        [Required]
        public string Title { get; set; }
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string InventoryNumber { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }
        public string State { get; set; }
    }
}
