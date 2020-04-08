using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_TfticProject_TerryPratchett.Models
{
    public class CharacterInfo
    {
		public int CharacterId { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Nickname { get; set; }
		public string Race { get; set; }
		public string Role { get; set; }
		public string CharacterDescription { get; set; }
		public DateTime? LastEdit { get; set; }

	}
}