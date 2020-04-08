using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
	public class Character
    {
		public int CharacterId { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Nickname { get; set; }
		public string Race { get; set; }
		public string Role { get; set; }
		public string CharacterDescription { get; set; }
		public DateTime? LastEdit { get; set; }

		public Character(string firstname, string lastname, string nickname, string race, string role, string characterDescription, DateTime? lastEdit)
		{
			Firstname = firstname;
			Lastname = lastname;
			Nickname = nickname;
			Race = race;
			Role = role;
			CharacterDescription = characterDescription;
			LastEdit = lastEdit;
		}

		public Character(int id, string firstname, string lastname, string nickname, string race, string role, string characterDescription, DateTime? lastEdit)
		: this(firstname, lastname, nickname, race, role, characterDescription, lastEdit)
		{
			CharacterId = id;
		}
	}
}
