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
    public class QuoteRepository:IQuoteRepository<Quote>
    {
        IQuoteRepository<G.Quote> _globalService;

        public QuoteRepository()
        {
            _globalService = new S.QuoteRepository();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<Quote> Get()
        {
            return _globalService.Get().Select(u => u.ToClient());
        }

        public Quote Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public Quote Insert(Quote entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }

        public Quote Update(int Id, Quote entity)
        {
            return _globalService.Update(Id, entity.ToGlobal()).ToClient();
        }
    }
}
