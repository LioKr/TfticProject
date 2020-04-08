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
    public class SagaRepository:ISagaRepository<Saga>
    {
        ISagaRepository<G.Saga> _globalService;

        public SagaRepository()
        {
            _globalService = new S.SagaRepository();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<Saga> Get()
        {
            return _globalService.Get().Select(u => u.ToClient());
        }

        public Saga Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public Saga Insert(Saga entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }

        public Saga Update(int Id, Saga entity)
        {
            return _globalService.Update(Id, entity.ToGlobal()).ToClient();
        }
    }
}
