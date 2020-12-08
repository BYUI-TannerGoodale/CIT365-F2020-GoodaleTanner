using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Meeting
    {

        // ID used by EF Core
        [Key]
        public int MeetingID { get; set; }

        public DateTime Date { get; set; }
        public int  LeaderId { get; set; }
        [ForeignKey("LeaderId")]
        public People Leader { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentHymn { get; set; }
        public string ClosingSong { get; set; }
        public string Intermediate { get; set; }
        public int OpeningPrayerID { get; set; }
        [ForeignKey("OpeningPrayerID")]
        public People OpeningPrayer { get; set; }
        public int ClosingPrayerID { get; set; }
        [ForeignKey("ClosingPrayerID")]
        public People ClosingPrayer { get; set; }

        //public OpeningPrayer OpeningPrayer { get; set; }
        //public ClosingPrayer ClosingPrayer { get; set; }
    }
}
