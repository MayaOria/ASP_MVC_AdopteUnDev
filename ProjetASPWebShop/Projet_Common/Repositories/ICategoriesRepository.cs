using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common.Repositories
{
    public interface ICategoriesRepository<TEntity, Tid>:
        IGetRepository<TEntity, Tid>
        where TEntity: ICategories
    {
    }
}
