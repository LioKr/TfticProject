using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? Deathdate { get; set; }

		public Person(string firstname, string lastname, DateTime birthdate, DateTime? deathdate)
		{
			Firstname = firstname;
			Lastname = lastname;
			Birthdate = birthdate;
			Deathdate = deathdate;
		}

		public Person(int id, string firstname, string lastname, DateTime birthdate, DateTime? deathdate)
		: this(firstname, lastname, birthdate, deathdate)
		{
			PersonId = id;
		}
	}
}
