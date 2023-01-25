﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common
{
    interface IRepository<TEntity, TId>:
        IGetRepository<TEntity, TId>,
        IInsertRepository<TEntity, TId>,
        IUpdateRepository<TEntity, TId>,
        IDeleteRepository<TEntity, TId>
    {
    }
}
