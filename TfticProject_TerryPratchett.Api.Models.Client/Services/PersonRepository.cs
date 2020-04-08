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
    public class PersonRepository:IPersonRepository<Person>
    {
        IPersonRepository<G.Person> _globalService;

        public PersonRepository()
        {
            _globalService = new S.PersonRepository();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<Person> Get()
        {
            return _globalService.Get().Select(u => u.ToClient());
        }

        public Person Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public Person Insert(Person entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }

        public Person Update(int Id, Person entity)
        {
            return _globalService.Update(Id, entity.ToGlobal()).ToClient();
        }
    }
}
