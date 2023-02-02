using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common
{
    public interface IUpdateRepository<TId, TEntity>
    {
        bool Update(TId id, TEntity entity);
    }
}
