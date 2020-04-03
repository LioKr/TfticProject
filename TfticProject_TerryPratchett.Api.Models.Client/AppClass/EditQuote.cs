using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class EditQuote
    {
        public int QuoteId { get; set; }
        public int SgFormId { get; set; }
        public int ValidatorAdmin { get; set; }
        public DateTime Created { get; set; }
    }
}
