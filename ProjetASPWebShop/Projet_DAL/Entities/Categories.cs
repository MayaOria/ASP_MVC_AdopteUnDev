using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_DAL.Entities
{
    public class Categories: ICategories
    {
        //INT
        public int IdCategory { get; set; }
        //NVARCHAR(50)
        public string CategLabel { get; set; }

    }
}
