using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_TfticProject_TerryPratchett.Models
{
    public class AuthorInfo
    {
        public int AuthorId { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public int PersonId { get; set; }
    }
}