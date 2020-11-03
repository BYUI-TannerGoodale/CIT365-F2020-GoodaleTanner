using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class DeskQuote
    {

        public int ID { get; set; }

        [Required]
        [Display(Name = "Cutomer Name")]
        public string CustName { get; set; }

        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        [Required]
        [Display(Name = "Desk Width")]
        [Range(24, 96, ErrorMessage = "Please enter a value between 24 and 96")]
        [RegularExpression(@"^[1-9][0-9]+$")]
        public int DeskWidth { get; set; }

        [Required]
        [Display(Name = "Desk Depth")]
        [Range(12, 48, ErrorMessage = "Please enter a value between 12 and 48")]
        [RegularExpression(@"^[1-9][0-9]+$")]
        public int DeskDepth { get; set; }

        [Display(Name = "Desk Area")]
        public int DeskArea { get; set; }

        [Required]
        [Range(0, 7, ErrorMessage = "Please enter a value between 0 and 7")]
        [RegularExpression(@"^[0-9]+$")]
        public int Drawers { get; set; }

        [Required]
        public string Material { get; set; }

        [Required]
        [Display(Name = "Shipping Time")]
        public int ShippingTime { get; set; }

        [Display(Name = "Total Price")]
        public int TotalPrice { get; set; }
    }
}
