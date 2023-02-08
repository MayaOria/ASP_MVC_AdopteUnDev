using Projet_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BLL.Entities
{
    public class Categories : ICategories
    {


        public int IdCategory { get; set; }

        public string CategLabel { get; set; }

        public IEnumerable<ItLang> ItLangues { get; set; }

        

        
    }
}
