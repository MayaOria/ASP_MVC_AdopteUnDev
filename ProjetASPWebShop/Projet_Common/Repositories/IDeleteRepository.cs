using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common
{
    interface IDeleteRepository<TEntity, TId>
    {
        bool Delete(TId id);
    }
}
