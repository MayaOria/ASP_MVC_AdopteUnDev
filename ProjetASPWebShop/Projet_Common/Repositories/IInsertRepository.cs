using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Common
{
    public interface IInsertRepository<Tentity, TId>
    {
        TId Insert(Tentity entity);
    }
}
