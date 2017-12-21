using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(TypeName = "datetime2")]
        [Timestamp]
        public DateTime From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime To { get; set; }

    }
}
