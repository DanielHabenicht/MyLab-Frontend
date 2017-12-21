using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Url
    {
        /// <summary>
        /// 
        /// </summary>
        [Url]
        public string UrlString { get; set; }
    }
}
