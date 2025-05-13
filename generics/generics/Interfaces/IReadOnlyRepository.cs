using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Interfaces
{
    interface IReadOnlyRepository<in TKey,out TEntity>
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
    }

}
