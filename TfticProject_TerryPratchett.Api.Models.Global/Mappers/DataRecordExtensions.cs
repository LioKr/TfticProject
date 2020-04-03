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
                Password = dR["Password"].ToString(),
                Role = dR["Role"].ToString()
            };
        }
    }
}
