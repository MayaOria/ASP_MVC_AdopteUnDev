using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common.Repositories
{
    public interface IClientRepository<TEntity, TId> : IInsertRepository<TEntity, TId>
        where TEntity: IClient
    {
        TEntity Get(TId id);
        int? CheckPassword(string login, string password);
    }
}
