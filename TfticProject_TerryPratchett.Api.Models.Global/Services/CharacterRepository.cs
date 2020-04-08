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
    public class CharacterRepository: ICharacterRepository<Character>
    {

        private const string ConnectionString = @"Data Source=DESKTOP-12FD2HA\SQLEXPRESS;Initial Catalog=DB_TerryPratchett;Integrated Security=True";
        private Connection _dbConnection;

        public CharacterRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_Character_Delete", true);
            command.AddParameter("CharacterId", id);

            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<Character> Get()
        {
            Command command = new Command("SELECT * FROM Character_ReadAll");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToCharacter());
        }

        public Character Get(int id)
        {
            Command command = new Command("SP_Character_ReadOne", true);
            command.AddParameter("CharacterId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToCharacter()).SingleOrDefault();
        }

        public Character Insert(Character entity)
        {
            Command command = new Command("SP_Character_Add", true);
            command.AddParameter("Firstname", entity.Firstname);
            command.AddParameter("Lastname", entity.Lastname);
            command.AddParameter("Nickname", entity.Nickname);
            command.AddParameter("Race", entity.Race);
            command.AddParameter("Role", entity.Role);
            command.AddParameter("CharacterDescription", entity.CharacterDescription);
            command.AddParameter("LastEdit", entity.LastEdit);
            entity.CharacterId = (int)_dbConnection.ExecuteScalar<Character>(command);
            return entity;
        }

        public Character Update(int Id, Character entity)
        {
            Command command = new Command("SP_Character_Update", true);
            command.AddParameter("CharacterId", Id);
            command.AddParameter("Firstname", entity.Firstname);
            command.AddParameter("Lastname", entity.Lastname);
            command.AddParameter("Nickname", entity.Nickname);
            command.AddParameter("Race", entity.Race);
            command.AddParameter("Role", entity.Role);
            command.AddParameter("CharacterDescription", entity.CharacterDescription);
            command.AddParameter("LastEdit", entity.LastEdit);

            if (_dbConnection.ExecuteNonQuery(command) > 0)
            {
                return this.Get(Id);
            }
            return entity;
        }
    }
}
