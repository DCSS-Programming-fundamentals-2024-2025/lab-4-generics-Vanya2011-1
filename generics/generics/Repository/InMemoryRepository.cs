using generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Repository
{
    class InMemoryRepository<TKey, TEntity> : IRepository<TKey, TEntity>, IReadOnlyRepository<TKey, TEntity>,
        IWriteRepository<TKey, TEntity>
        where TKey : struct
        where TEntity : class, new()
    {
        Dictionary<TKey, TEntity> rep = new Dictionary<TKey, TEntity>();

        public void Add(TKey id, TEntity entity)
        {
            rep.Add(id, entity);
        }

        public void Add(TEntity entity)
        {
            dynamic  e = entity;
            rep.Add(e.Id, e.Name);
        }

        public TEntity Get(TKey id)
        {
            if (rep.TryGetValue(id, out var entity))
            {
                return entity;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return rep.Values;
        }

        public void Remove(TKey id)
        {
            if (!rep.Remove(id))
            {
                throw new KeyNotFoundException();
            }
        }


    }
}
