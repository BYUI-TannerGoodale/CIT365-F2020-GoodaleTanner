using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }
        [Required]
        public string Book { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only numbers greater then zreo, please.")]
        public int Chapter { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only numbers greater then zreo, please.")]
        public string Verse { get; set; }
        [Required]
        public string Note { get; set; }
        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
    }
}
