using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.ItLangViewModels
{
    public class ItLangListItem
    {
        [ScaffoldColumn(false)]
        
        public int IdIT { get; set; }

        public string ItLabel { get; set; }

    }
}
