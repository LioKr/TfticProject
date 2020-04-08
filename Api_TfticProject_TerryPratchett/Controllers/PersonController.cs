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

    public class PersonController : ApiController
    {
        private IPersonRepository<C.Person> _service;

        public PersonController()
        {
            _service = new PersonRepository();
        }

        [HttpGet]
        public IEnumerable<C.Person> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        public C.Person Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("AddPerson")]
        public C.Person AddPerson(PersonInfo apiClassInfo)
        {
            return _service.Insert(new C.Person(apiClassInfo.Firstname, apiClassInfo.Lastname, apiClassInfo.Birthdate, apiClassInfo.Deathdate));
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("UpdatePerson/{id}")]
        public C.Person UpdatePerson(int id, PersonInfo apiClassInfo)
        {
            return _service.Update(id, new C.Person(id, apiClassInfo.Firstname, apiClassInfo.Lastname, apiClassInfo.Birthdate, apiClassInfo.Deathdate));
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("DeletePerson/{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
