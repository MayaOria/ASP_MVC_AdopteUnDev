
using Projet_ASP.Models.CategoriesViewModels;
using Projet_ASP.Models.DeveloperViewModel;
using Projet_ASP.Models.ItLangViewModels;
using System.Collections.Generic;

namespace Projet_ASP.Models.HomeViewModel
{
    public class IndexModel
    {
        public IEnumerable<DeveloperListItem> Developers;
        public IEnumerable<CategoriesListItem> Categories;
        public IEnumerable<ItLangListItem> ItLangs;

    }
}
