using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfticProject_TerryPratchett.Api.Models.Interfaces
{
    public interface IUserRepository<TEntity>:IRepository<TEntity, int> where TEntity : class
    {
        TEntity Login(TEntity entity);
    }
}
