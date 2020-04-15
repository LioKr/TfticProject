using Api_TfticProject_TerryPratchett.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls.WebParts;
using TfticProject_TerryPratchett.Api.Models.Global;
using ToolBox;
using TfticProject_TerryPratchett.Api.Models.Global.Mappers;
using Newtonsoft.Json;
using C = TfticProject_TerryPratchett.Api.Models.Client;
using TfticProject_TerryPratchett.Api.Models.Client.Services;
using TfticProject_TerryPratchett.Api.Models.Interfaces;

namespace Api_TfticProject_TerryPratchett.Controllers
{
    [RoutePrefix("api")]
    public class AuthController : ApiController
    {
        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _connection;

        //public AuthController()
        //{
        //    _connection = new Connection(ConnectionString);
        //}
        private IUserRepository<C.User> _service;

        public AuthController()
        {
            _service = new UserRepository();
            _connection = new Connection(ConnectionString);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("Register")]
        public HttpResponseMessage Register(RegisterInfo entity)
        {
            try
            {            
                if(!(entity is null) && ModelState.IsValid)
                {
                    _service.Insert(new C.User(entity.Firstname, entity.Lastname, entity.Email, entity.Username, entity.Password, entity.Role));
                    //Command command = new Command("SP_User_Add", true);
                    //command.AddParameter("firstname", entity.Firstname);
                    //command.AddParameter("lastname", entity.Lastname);
                    //command.AddParameter("email", entity.Email);
                    //command.AddParameter("userName", entity.Username);
                    //command.AddParameter("password", entity.Password);
                    //command.AddParameter("role", entity.Role);

                    //int rowCount = _connection.ExecuteNonQuery(command);
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
            }
            catch (SqlException exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest) ;
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("Login")]
        public HttpResponseMessage Login(LoginInfo entity)
        {
            try
            {
                if (!(entity is null) && ModelState.IsValid)
                {
                    Command command = new Command("SP_User_Login", true);
                    command.AddParameter("Username", entity.Username);
                    command.AddParameter("Password", entity.Password);

                    User user = _connection.ExecuteReader(command, (dr) => new User()
                    {
                        UserId = (int)dr["UserId"],
                        Firstname = dr["Firstname"].ToString(),
                        Lastname = dr["Lastname"].ToString(),
                        Email = dr["Email"].ToString(),
                        Role = dr["Role"].ToString()
                    }).SingleOrDefault();

                    if (user is null)
                        return new HttpResponseMessage(HttpStatusCode.BadRequest);
                    else
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(user))
                    };
                }
            }
            catch (SqlException exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

            }

            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }
    }
}
