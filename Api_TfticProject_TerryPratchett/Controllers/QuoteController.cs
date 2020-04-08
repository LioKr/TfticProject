using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using C = TfticProject_TerryPratchett.Api.Models.Client;
using TfticProject_TerryPratchett.Api.Models.Client.Services;
using TfticProject_TerryPratchett.Api.Models.Interfaces;
using Api_TfticProject_TerryPratchett.Models;

namespace Api_TfticProject_TerryPratchett.Controllers
{
    [RoutePrefix("api")]

    public class QuoteController : ApiController
    {
        private IQuoteRepository<C.Quote> _service;

        public QuoteController()
        {
            _service = new QuoteRepository();
        }

        [HttpGet]
        public IEnumerable<C.Quote> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        public C.Quote Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("AddQuote")]
        public C.Quote AddQuote(QuoteInfo apiClassInfo)
        {
            return _service.Insert(new C.Quote(apiClassInfo.Content, apiClassInfo.Quote_Author, apiClassInfo.Quote_Book, apiClassInfo.LastEdit));
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("UpdateQuote/{id}")]
        public C.Quote UpdateQuote(int id, QuoteInfo apiClassInfo)
        {
            return _service.Update(id, new C.Quote(id, apiClassInfo.Content, apiClassInfo.Quote_Author, apiClassInfo.Quote_Book, apiClassInfo.LastEdit));
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("DeleteQuote/{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
