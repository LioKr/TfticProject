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
    public class BookController : ApiController
    {
        private IBookRepository<C.Book> _service;

        public BookController()
        {
            _service = new BookRepository();
        }

        [HttpGet]
        public IEnumerable<C.Book> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        public C.Book Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("AddBook")]
        public C.Book AddBook(BookInfo apiClassInfo)
        {
            return _service.Insert(new C.Book(apiClassInfo.BookId, apiClassInfo.Title, apiClassInfo.ReleaseYear, apiClassInfo.IsDiscWorld, apiClassInfo.SagaName, apiClassInfo.LastEdit));
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("UpdateBook/{id}")]
        public C.Book UpdateBook(int id, BookInfo apiClassInfo)
        {
            return _service.Update(id, new C.Book(id, apiClassInfo.Title, apiClassInfo.ReleaseYear, apiClassInfo.IsDiscWorld, apiClassInfo.SagaName, apiClassInfo.LastEdit));
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("DeleteBook/{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}
