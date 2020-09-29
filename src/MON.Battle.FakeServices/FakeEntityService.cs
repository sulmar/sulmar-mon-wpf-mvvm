using Bogus;
using MON.Battle.IServices;
using MON.Battle.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MON.Battle.FakeServices
{
    public class FakeEntityService<TEntity> : IEntityService<TEntity>
        where TEntity : BaseEntity           // constraints
    {
        private readonly ICollection<TEntity> entities;

        public FakeEntityService(Faker<TEntity> faker)
        {
            entities = faker.Generate(100);
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        public IEnumerable<TEntity> Get()
        {
            return entities;
        }

        public TEntity Get(Guid id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }

        public void Remove(Guid id)
        {
            entities.Remove(Get(id));
        }

        public void Update(TEntity entity)
        {
            Remove(entity.Id);
            Add(entity);
        }
    }
}
