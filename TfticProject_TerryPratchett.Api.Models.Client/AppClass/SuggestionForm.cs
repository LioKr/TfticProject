using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
	public class SuggestionForm
    {
		public int SgFormId { get; set; }
		public string CharacterEditSuggestion { get; set; }
		public string QuoteEditSuggestion { get; set; }
		public string BookEditSuggestion { get; set; }
		public int UserId { get; set; }
		public DateTime SuggestionDate { get; set; }
    }
}
