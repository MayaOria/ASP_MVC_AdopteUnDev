using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common
{
    public interface IDeleteRepository<TEntity, TId>
    {
        bool Delete(TId id);
    }
}
