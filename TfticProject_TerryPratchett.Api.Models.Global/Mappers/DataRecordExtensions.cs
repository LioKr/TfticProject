using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfticProject_TerryPratchett.Api.Models.Global.Mappers
{
   internal static class DataRecordExtensions
    {
        internal static User ToUser(this IDataRecord dR)
        {
            return new User()
            {
                UserId = (int)dR["UserId"],
                Firstname = dR["Firstname"].ToString(),
                Lastname = dR["Lastname"].ToString(),
                Email = dR["Email"].ToString(),
                Username = dR["Username"].ToString(),
                Password = "******", //Attention, mot de passe encrypté, pas possible de le récupérer_
                Role = dR["Role"].ToString()
            };
        }

        internal static Book ToBook(this IDataRecord dR)
        {
            return new Book()
            {
                BookId = (int)dR["BookId"],
                Title = dR["Title"].ToString(),
                ReleaseYear = (int)dR["ReleaseYear"],
                IsDiscWorld = (bool)dR["IsDiscWorld"],
                SagaName = (dR["SagaName"] != DBNull.Value) ? dR["SagaName"].ToString() : null,
                LastEdit = (dR["LastEdit"] != DBNull.Value) ? (DateTime?)dR["LastEdit"] : null
            };
        }

        internal static Character ToCharacter(this IDataRecord dR)
        {
            return new Character()
            {
                CharacterId = (int)dR["CharacterId"],
                Firstname = dR["Firstname"].ToString(),
                Lastname = dR["Lastname"].ToString(),
                Nickname = dR["Nickname"].ToString(),
                Race = dR["Race"].ToString(),
                Role = dR["Role"].ToString(),
                CharacterDescription = dR["CharacterDescription"].ToString(),
                LastEdit = (dR["LastEdit"] != DBNull.Value) ? (DateTime?)dR["LastEdit"] : null
            };
        }

        internal static Quote ToQuote(this IDataRecord dR)
        {
            return new Quote()
            {
                QuoteId = (int)dR["QuoteId"],
                Content = dR["Content"].ToString(),
                Quote_Author = (dR["Quote_Author"] != DBNull.Value) ? (int?)dR["Quote_Author"] : null,
                Quote_Book = dR["Quote_Book"].ToString(),               
                LastEdit = (dR["LastEdit"] != DBNull.Value) ? (DateTime?)dR["LastEdit"] : null
            };
        }
    }
}
