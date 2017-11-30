using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabAPI.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Typ { get; set; }
        public string Lagerort { get; set; }
        public string Kommentar { get; set; }
        public string Zustand { get; set; }
    }
}
