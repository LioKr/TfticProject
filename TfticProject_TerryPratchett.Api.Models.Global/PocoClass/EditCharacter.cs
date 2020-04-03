using System;

namespace TfticProject_TerryPratchett.Api.Models.Global
{
    class EditCharacter
    {
        public int CharacterId { get; set; }
        public int SgFormId { get; set; }
        public int ValidatorAdmin { get; set; }
        public DateTime Created { get; set; }
    }

}
