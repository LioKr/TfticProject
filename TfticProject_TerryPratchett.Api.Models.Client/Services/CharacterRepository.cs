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
    public class CharacterRepository:ICharacterRepository<Character>
    {
        ICharacterRepository<G.Character> _globalService;

        public CharacterRepository()
        {
            _globalService = new S.CharacterRepository();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<Character> Get()
        {
            return _globalService.Get().Select(u => u.ToClient());
        }

        public Character Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public Character Insert(Character entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }

        public Character Update(int Id, Character entity)
        {
            return _globalService.Update(Id, entity.ToGlobal()).ToClient();
        }
    }
}
