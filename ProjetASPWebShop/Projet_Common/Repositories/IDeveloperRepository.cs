using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common.Repositories
{
    public interface IDeveloperRepository<TEntity, TId> : 
            IGetRepository<TEntity, TId>, 
            IInsertRepository<TEntity, TId>,
            IUpdateRepository<TEntity, TId>
            where TEntity : IDeveloper
    {
    }
}
