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
    public class QuoteRepository : IQuoteRepository<Quote>
    {

        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _dbConnection;

        public QuoteRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_Quote_Delete", true);
            command.AddParameter("quoteId", id);

            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<Quote> Get()
        {
            Command command = new Command("SELECT * FROM Quote_ReadAll");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToQuote());
        }

        public Quote Get(int id)
        {
            Command command = new Command("SP_Quote_ReadOne", true);
            command.AddParameter("quoteId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToQuote()).SingleOrDefault();
        }

        public Quote Insert(Quote entity)
        {
            Command command = new Command("SP_Quote_Add", true);
            command.AddParameter("content", entity.Content);
            command.AddParameter("quote_Author", entity.Quote_Author);
            command.AddParameter("quote_Book", entity.Quote_Book);
            command.AddParameter("LastEdit", entity.LastEdit);
            entity.QuoteId = (int)_dbConnection.ExecuteScalar<Quote>(command);
            return entity;
        }

        public Quote Update(int quoteId, Quote entity)
        {
            Command command = new Command("SP_Quote_Update", true);
            command.AddParameter("quoteId", quoteId);
            command.AddParameter("content", entity.Content);
            command.AddParameter("quote_Author", entity.Quote_Author);
            command.AddParameter("quote_Book", entity.Quote_Book);
            command.AddParameter("LastEdit", entity.LastEdit);

            if (_dbConnection.ExecuteNonQuery(command) > 0)
            {
                return this.Get(quoteId);
            }
            return entity;
        }
    }
}
