using System;


namespace TfticProject_TerryPratchett.Api.Models.Client
{
	public class Book
    {
		public int BookId { get; set; }
		public string Title { get; set; }
		public int ReleaseYear { get; set; }
		public bool IsDiscWorld { get; set; }
		public string SagaName { get; set; }
		public DateTime? LastEdit { get; set; }

		public Book(string title, int releaseYear, bool isDiscWorld, string sagaName, DateTime? lastEdit)
		{
			Title = title;
			ReleaseYear = releaseYear;
			IsDiscWorld = isDiscWorld;
			SagaName = sagaName;
			LastEdit = lastEdit;
		}

		public Book(int id, string title, int releaseYear, bool isDiscWorld, string sagaName, DateTime? lastEdit)
		: this(title, releaseYear, isDiscWorld, sagaName, lastEdit)
		{
			BookId = id;
		}
	}
}
