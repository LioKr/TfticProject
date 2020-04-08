using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfticProject_TerryPratchett.Api.Models.Interfaces;
using S = TfticProject_TerryPratchett.Api.Models.Global.Services;
using G = TfticProject_TerryPratchett.Api.Models.Global;
using TfticProject_TerryPratchett.Api.Models.Client.Mappers;

namespace TfticProject_TerryPratchett.Api.Models.Client.Services
{
    public class AuthorRepository:IAuthorRepository<Author>
    {
        IAuthorRepository<G.Author> _globalService;

        public AuthorRepository()
        {
            _globalService = new S.AuthorRepository();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<Author> Get()
        {
            return _globalService.Get().Select(u => u.ToClient());
        }

        public Author Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public Author Insert(Author entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }

        public Author Update(int Id, Author entity)
        {
            return _globalService.Update(Id, entity.ToGlobal()).ToClient();
        }
    }
}
