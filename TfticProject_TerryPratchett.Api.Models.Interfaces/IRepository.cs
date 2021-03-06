﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfticProject_TerryPratchett.Api.Models.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : class where TId : struct
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
        TEntity Insert(TEntity entity);
        TEntity Update(TId id, TEntity entity);
        void Delete(TId id);
    }
}
