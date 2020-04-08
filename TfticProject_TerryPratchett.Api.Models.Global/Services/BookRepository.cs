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
    public class BookRepository: IBookRepository<Book>
    {
        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _dbConnection;

        public BookRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_Book_Delete", true);
            command.AddParameter("BookId", id);

            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<Book> Get()
        {
            Command command = new Command("SELECT * FROM Book_ReadAll");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToBook());
        }

        public Book Get(int id)
        {
            Command command = new Command("SP_Book_ReadOne", true);
            command.AddParameter("BookId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToBook()).SingleOrDefault();
        }

        public Book Insert(Book entity)
        {
            Command command = new Command("SP_Book_Add", true);
            command.AddParameter("BookId", entity.BookId);
            command.AddParameter("Title", entity.Title);
            command.AddParameter("ReleaseYear", entity.ReleaseYear);
            command.AddParameter("IsDiscWorld", entity.IsDiscWorld);
            command.AddParameter("SagaName", entity.SagaName);             
            command.AddParameter("LastEdit", entity.LastEdit);
            return entity;
        }

        public Book Update(int Id, Book entity)
        {
            Command command = new Command("SP_Book_Update", true);
            command.AddParameter("BookId", Id);
            command.AddParameter("Title", entity.Title);
            command.AddParameter("ReleaseYear", entity.ReleaseYear);
            command.AddParameter("IsDiscWorld", entity.IsDiscWorld);
            command.AddParameter("SagaName", entity.SagaName);
            command.AddParameter("LastEdit", entity.LastEdit);

            if (_dbConnection.ExecuteNonQuery(command) > 0)
            {
                return this.Get(Id);
            }
            return entity;
        }
    }
}
