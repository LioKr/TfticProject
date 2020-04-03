using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string Content { get; set; }
        public int Quote_Author { get; set; }
        public string Quote_Book { get; set; }
        public DateTime LastEdit { get; set; }

    }
}
