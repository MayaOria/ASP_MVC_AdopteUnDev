using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common.Repositories
{
    public interface IItLangRepository<TEntity, Tid> :
        IGetRepository<TEntity, Tid>
        where TEntity : IItLang
    {
    }
}
