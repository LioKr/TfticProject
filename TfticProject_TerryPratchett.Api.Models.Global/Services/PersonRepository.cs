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
    public class PersonRepository:IPersonRepository<Person>
    {
        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _dbConnection;

        public PersonRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_Person_Delete", true);
            command.AddParameter("PersonId", id);

            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<Person> Get()
        {
            Command command = new Command("SELECT * FROM Person_ReadAll");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToPerson());
        }

        public Person Get(int id)
        {
            Command command = new Command("SP_Person_ReadOne", true);
            command.AddParameter("PersonId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToPerson()).SingleOrDefault();
        }

        public Person Insert(Person entity)
        {
            Command command = new Command("SP_Person_Add", true);
            command.AddParameter("Firstname", entity.Firstname);
            command.AddParameter("Lastname", entity.Lastname);
            command.AddParameter("Birthdate", entity.Birthdate);
            command.AddParameter("Deathdate", entity.Deathdate);
            entity.PersonId = (int)_dbConnection.ExecuteScalar<Person>(command);
            return entity;
        }

        public Person Update(int PersonId, Person entity)
        {
            Command command = new Command("SP_Person_Update", true);
            command.AddParameter("PersonId", PersonId);
            command.AddParameter("Firstname", entity.Firstname);
            command.AddParameter("Lastname", entity.Lastname);
            command.AddParameter("Birthdate", entity.Birthdate);
            command.AddParameter("Deathdate", entity.Deathdate);

            if (_dbConnection.ExecuteNonQuery(command) > 0)
            {
                return this.Get(PersonId);
            }
            return entity;
        }
    }
}
