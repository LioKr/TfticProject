using System;


namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public int PersonId { get; set; }

		public Author(string biography, string picture, int personId)
		{
			Biography = biography;
			Picture = picture;
			PersonId = personId;
		}

		public Author(int id, string biography, string picture, int personId)
		: this(biography, picture, personId)
		{
			AuthorId = id;
		}
	}
}
