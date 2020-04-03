using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfticProject_TerryPratchett.Api.Models.Interfaces;
using S = TfticProject_TerryPratchett.Api.Models.Global.Services;
using G = TfticProject_TerryPratchett.Api.Models.Global;
using TfticProject_TerryPratchett.Api.Models.Client.Mappers;

namespace TfticProject_TerryPratchett.Api.Models.Client.Services
{
    public class UserRepository : IUserRepository<User>
    {
        IUserRepository<G.User> _globalService;

        public UserRepository()
        {
            _globalService = new S.UserRepository();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<User> Get()
        {
            return _globalService.Get().Select(u => u.ToClient());
        }

        public User Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public User Insert(User entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }

        public User Update(int userId,User entity)
        {
            return _globalService.Update(userId, entity.ToGlobal()).ToClient();
        }
    }
}
