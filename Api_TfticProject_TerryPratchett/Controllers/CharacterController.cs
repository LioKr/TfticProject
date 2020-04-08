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

    public class CharacterController : ApiController
    {
        private ICharacterRepository<C.Character> _service;

        public CharacterController()
        {
            _service = new CharacterRepository();
        }

        [HttpGet]
        public IEnumerable<C.Character> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        public C.Character Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("AddCharacter")]
        public C.Character AddCharacter(CharacterInfo apiClassInfo)
        {
            return _service.Insert(new C.Character(apiClassInfo.Firstname, apiClassInfo.Lastname, apiClassInfo.Nickname, apiClassInfo.Race, apiClassInfo.Role, apiClassInfo.CharacterDescription, apiClassInfo.LastEdit));
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("UpdateCharacter/{id}")]
        public C.Character UpdateCharacter(int id, CharacterInfo apiClassInfo)
        {
            return _service.Update(id, new C.Character(id, apiClassInfo.Firstname, apiClassInfo.Lastname, apiClassInfo.Nickname, apiClassInfo.Race, apiClassInfo.Role, apiClassInfo.CharacterDescription, apiClassInfo.LastEdit));
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("DeleteCharacter/{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
    
}
