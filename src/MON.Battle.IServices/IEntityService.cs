using System;
using System.Collections.Generic;

namespace MON.Battle.IServices
{
    public interface IEntityService<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(Guid id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(Guid id);
    }

   
}
