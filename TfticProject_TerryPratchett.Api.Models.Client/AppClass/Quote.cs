using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string Content { get; set; }
        public int? Quote_Author { get; set; }
        public string Quote_Book { get; set; }
        public DateTime? LastEdit { get; set; }

		public Quote(string content, int? quote_Author, string quote_Book, DateTime? lastEdit)
		{
			Content = content;
			Quote_Author = quote_Author;
			Quote_Book = quote_Book;
			LastEdit = lastEdit;
		}

		public Quote(int id, string content, int? quote_Author, string quote_Book, DateTime? lastEdit)			
		: this(content, quote_Author, quote_Book, lastEdit)
		{
			QuoteId = id;
		}
	}
}
