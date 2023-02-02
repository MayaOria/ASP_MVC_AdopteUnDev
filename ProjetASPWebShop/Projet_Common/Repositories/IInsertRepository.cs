using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common
{
    public interface IInsertRepository<TEntity, TId>
    {
        TId Insert(TEntity entity);
    }
}
