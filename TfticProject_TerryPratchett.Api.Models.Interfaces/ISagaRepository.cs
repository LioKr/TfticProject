using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfticProject_TerryPratchett.Api.Models.Interfaces
{
    public interface ISagaRepository<TEntity>
    {        
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        TEntity Insert(TEntity entity);
        TEntity Update(int id, TEntity entity);
        void Delete(int id);
    }
}
