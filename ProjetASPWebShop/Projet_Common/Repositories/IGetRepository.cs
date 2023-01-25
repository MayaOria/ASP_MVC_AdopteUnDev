using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common
{
   public  interface IGetRepository<TEntity, TId>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
    }
}
