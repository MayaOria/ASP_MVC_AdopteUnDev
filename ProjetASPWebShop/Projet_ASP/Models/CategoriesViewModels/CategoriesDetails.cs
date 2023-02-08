using Projet_BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.CategoriesViewModels
{
    public class CategoriesDetails
    {
        [ScaffoldColumn(false)]
        public int IdCategory { get; set; }

        [DisplayName("Label")]
        public string IdLabel { get; set; }

        [DisplayName("IT Langues")]
        public IEnumerable<ItLang> itLangs { get; set; }
    }
}
