using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.ItLangViewModels
{
    public class ItLangDetails
    {
        
            [ScaffoldColumn(false)]

            public int IdIT { get; set; }

            [DisplayName("Label")]
            public string IdLabel { get; set; }

        
    }
}
