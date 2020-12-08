using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class People
    {
        // ID for EF Core
        [Key]
        public int PeopleID { get; set; }

        public string FirstMidName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstMidName} {LastName}";
            }
        }
    }
}
