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

    public class SagaController : ApiController
    {
        private ISagaRepository<C.Saga> _service;

        public SagaController()
        {
            _service = new SagaRepository();
        }

        [HttpGet]
        public IEnumerable<C.Saga> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        public C.Saga Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("AddSaga")]
        public C.Saga AddQuote(SagaInfo apiClassInfo)
        {
            return _service.Insert(new C.Saga(apiClassInfo.SagaName));
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("UpdateSaga/{id}")]
        public C.Saga UpdateSaga(int id, SagaInfo apiClassInfo)
        {
            return _service.Update(id, new C.Saga(id, apiClassInfo.SagaName));
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("DeleteSaga/{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
