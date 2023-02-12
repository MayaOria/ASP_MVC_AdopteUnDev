using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common.Repositories
{
    public interface IClientEndorseDevRepository<TEntity, TId>: 
        IInsertRepository<TEntity, TId>,
        IGetRepository<TEntity, TId>
        where TEntity : IClientEndorseDev
    {
        IEnumerable<TEntity> GetByIdClient(TId id);
        IEnumerable<TEntity> GetByIdDev(TId id);
    }
}
