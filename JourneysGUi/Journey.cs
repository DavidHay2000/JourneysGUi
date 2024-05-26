using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneysGUi
{
    public class Journey
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public DateTime Departure { get; set; } 
        public int? Capacity { get; set; }
        public int? vehicleid { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
