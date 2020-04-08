using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_TfticProject_TerryPratchett.Models
{
    public class PersonInfo
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? Deathdate { get; set; }
    }
}