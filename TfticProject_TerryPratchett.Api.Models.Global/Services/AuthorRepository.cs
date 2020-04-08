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
    public class AuthorRepository: IAuthorRepository<Author>
    {
        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _dbConnection;

        public AuthorRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_Author_Delete", true);
            command.AddParameter("AuthorId", id);

            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<Author> Get()
        {
            Command command = new Command("SELECT * FROM Author_ReadAll");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToAuthor());
        }

        public Author Get(int id)
        {
            Command command = new Command("SP_Author_ReadOne", true);
            command.AddParameter("AuthorId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToAuthor()).SingleOrDefault();
        }

        public Author Insert(Author entity)
        {
            Command command = new Command("SP_Author_Add", true);
            command.AddParameter("Biography", entity.Biography);
            command.AddParameter("Picture", entity.Picture);
            command.AddParameter("PersonId", entity.PersonId);
            entity.AuthorId = (int)_dbConnection.ExecuteScalar<Quote>(command);
            return entity;
        }

        public Author Update(int AuthorId, Author entity)
        {
            Command command = new Command("SP_Author_Update", true);
            command.AddParameter("AuthorId", AuthorId);
            command.AddParameter("Biography", entity.Biography);
            command.AddParameter("Picture", entity.Picture);
            command.AddParameter("PersonId", entity.PersonId);

            if (_dbConnection.ExecuteNonQuery(command) > 0)
            {
                return this.Get(AuthorId);
            }
            return entity;
        }
    }
}
