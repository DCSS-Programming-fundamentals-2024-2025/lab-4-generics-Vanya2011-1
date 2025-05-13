using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Interfaces
{
    interface IWriteRepository<in TKey, in TEntity>
    {
        void Add(TEntity entity);
        void Remove(TKey id);
    }
}
