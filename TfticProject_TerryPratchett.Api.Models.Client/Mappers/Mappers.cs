using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = TfticProject_TerryPratchett.Api.Models.Client;
using G = TfticProject_TerryPratchett.Api.Models.Global;

namespace TfticProject_TerryPratchett.Api.Models.Client.Mappers
{
    internal static class Mappers
    {
        internal static G.User ToGlobal(this C.User entity)
        {
            return new G.User()
            {
                UserId = entity.UserId,
                Firstname = entity.Firstname,
                Lastname = entity.Lastname,
                Email = entity.Email,
                Username = entity.Username,
                Password = entity.Password,
                Role = entity.Role
            };
        }

        internal static C.User ToClient(this G.User entity)
        {
            return new C.User(entity.UserId, entity.Firstname, entity.Lastname, entity.Email, entity.Username, entity.Password, entity.Role);           
        }

    }
}
