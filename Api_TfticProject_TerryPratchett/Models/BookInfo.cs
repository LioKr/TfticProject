using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_TfticProject_TerryPratchett.Models
{
    public class BookInfo
    {
		public int BookId { get; set; }
		public string Title { get; set; }
		public int ReleaseYear { get; set; }
		public bool IsDiscWorld { get; set; }
		public string SagaName { get; set; }
		public DateTime? LastEdit { get; set; }
	}
}