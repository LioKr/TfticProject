using System;


namespace TfticProject_TerryPratchett.Api.Models.Global
{
    class Book
    {
		public int BookId { get; set; }
		public string Title { get; set; }
		public int ReleaseYear { get; set; }
		public bool IsDiscWorld { get; set; }
		public string SagaName { get; set; }
		public DateTime LastEdit { get; set; }
	}
}
