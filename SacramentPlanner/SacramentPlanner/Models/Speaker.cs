using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        // ID for EF Core
        public int SpeakerID { get; set; }
        // FK to people table
        public int PeopleID { get; set; }
        public string Topic { get; set; }

        public People People { get; set; }
    }
}
