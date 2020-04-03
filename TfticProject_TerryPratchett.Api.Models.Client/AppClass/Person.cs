using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Deathdate { get; set; }
    }
}
