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
    public class BookRepository : IBookRepository<Book>
    {
        IBookRepository<G.Book> _globalService;

        public BookRepository()
        {
            _globalService = new S.BookRepository();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<Book> Get()
        {
            return _globalService.Get().Select(u => u.ToClient());
        }

        public Book Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public Book Insert(Book entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }

        public Book Update(int Id, Book entity)
        {
            return _globalService.Update(Id, entity.ToGlobal()).ToClient();
        }
    }
}
