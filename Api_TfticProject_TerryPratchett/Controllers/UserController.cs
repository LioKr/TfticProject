using Api_TfticProject_TerryPratchett.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using C = TfticProject_TerryPratchett.Api.Models.Client;
using TfticProject_TerryPratchett.Api.Models.Client.Services;
using TfticProject_TerryPratchett.Api.Models.Interfaces;

namespace Api_TfticProject_TerryPratchett.Controllers
{
    [RoutePrefix("api")]
    public class UserController : ApiController
    {
        private IRepository<C.User,int> _service;

        public UserController()
        {
            _service = new UserRepository();
        }

        [HttpGet]
        public IEnumerable<C.User> Get()
        {
            return _service.Get();   
        }

        [HttpGet]
        public C.User Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("AddUser")]
        public C.User AddUser(UserInfo userInfo)
        {
            return _service.Insert(new C.User(userInfo.Firstname, userInfo.Lastname, userInfo.Email, userInfo.Username, userInfo.Password, userInfo.Role));
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("UpdateUser/{id}")]
        public C.User UpdateUser(int id, UserInfo userInfo)
        {
            return _service.Update(id, new C.User(userInfo.Firstname, userInfo.Lastname, userInfo.Email, userInfo.Username, userInfo.Password, userInfo.Role));
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("DeleteUser/{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}
