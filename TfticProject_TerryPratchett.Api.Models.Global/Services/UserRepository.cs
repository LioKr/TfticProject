using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfticProject_TerryPratchett.Api.Models.Global.Mappers;
using TfticProject_TerryPratchett.Api.Models.Interfaces;
using ToolBox;

namespace TfticProject_TerryPratchett.Api.Models.Global.Services
{
    public class UserRepository : IUserRepository<User>
    {
        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _dbConnection;

        public UserRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_User_ReadOne", true);
            command.AddParameter("userId", id);

            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<User> Get()
        {
            Command command = new Command("SELECT * FROM User_All");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToUser());
        }

        public User Get(int id)
        {
            Command command = new Command("SP_User_ReadOne", true);
            command.AddParameter("userId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToUser()).SingleOrDefault();
        }

        public User Insert(User entity) 
        {
            Command command = new Command("SP_User_Add",true);
            command.AddParameter("firstname", entity.Firstname);
            command.AddParameter("lastname", entity.Lastname);
            command.AddParameter("email", entity.Email);
            command.AddParameter("userName", entity.Username);
            command.AddParameter("password", entity.Password);
            command.AddParameter("role", entity.Role);

            return _dbConnection.ExecuteReader(command, (dr) => dr.ToUser()).FirstOrDefault();
        }

        public User Update(int userId, User entity)
        {
            Command command = new Command("SP_User_Update",true);
            command.AddParameter("userId", userId);
            command.AddParameter("firstname", entity.Firstname);
            command.AddParameter("lastname", entity.Lastname);
            command.AddParameter("email", entity.Email);
            command.AddParameter("userName", entity.Username);
            command.AddParameter("password", entity.Password);
            command.AddParameter("role", entity.Role);

            return _dbConnection.ExecuteReader(command, (dr) => dr.ToUser()).SingleOrDefault();
        }
    }
}
