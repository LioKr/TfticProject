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

    public class AuthorController : ApiController
    {
        private IAuthorRepository<C.Author> _service;

        public AuthorController()
        {
            _service = new AuthorRepository();
        }

        [HttpGet]
        public IEnumerable<C.Author> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        public C.Author Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("AddAuthor")]
        public C.Author AddQuote(AuthorInfo apiClassInfo)
        {
            return _service.Insert(new C.Author(apiClassInfo.Biography, apiClassInfo.Picture, apiClassInfo.PersonId));
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("UpdateAuthor/{id}")]
        public C.Author UpdateAuthor(int id, AuthorInfo apiClassInfo)
        {
            return _service.Update(id, new C.Author(id, apiClassInfo.Biography, apiClassInfo.Picture, apiClassInfo.PersonId));
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("DeleteAuthor/{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
