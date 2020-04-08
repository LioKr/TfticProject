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
    public class SagaRepository : ISagaRepository<Saga>
    {
        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _dbConnection;

        public SagaRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_Saga_Delete", true);
            command.AddParameter("SagaId", id);

            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<Saga> Get()
        {
            Command command = new Command("SELECT * FROM Saga_ReadAll");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToSaga());
        }

        public Saga Get(int id)
        {
            Command command = new Command("SP_Saga_ReadOne", true);
            command.AddParameter("SagaId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToSaga()).SingleOrDefault();
        }

        public Saga Insert(Saga entity)
        {
            Command command = new Command("SP_Saga_Add", true);
            command.AddParameter("SagaName", entity.SagaName);
            entity.SagaId = (int)_dbConnection.ExecuteScalar<Saga>(command);
            return entity;
        }

        public Saga Update(int SagaId, Saga entity)
        {
            Command command = new Command("SP_Saga_Update", true);
            command.AddParameter("SagaId", SagaId);
            command.AddParameter("SagaName", entity.SagaName);

            if (_dbConnection.ExecuteNonQuery(command) > 0)
            {
                return this.Get(SagaId);
            }
            return entity;
        }
    }
}
