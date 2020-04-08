using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_TfticProject_TerryPratchett.Models
{
    public class QuoteInfo
    {
        public int QuoteId { get; set; }
        public string Content { get; set; }
        public int? Quote_Author { get; set; }
        public string Quote_Book { get; set; }
        public DateTime? LastEdit { get; set; }
    }
}