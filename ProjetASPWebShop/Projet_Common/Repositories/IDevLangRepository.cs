using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common.Repositories
{
    public interface IDevLangRepository<TEntity, TId> where TEntity : IDevLang
    {
        IEnumerable<TEntity> GetByDev(int idDev);
    }
}
