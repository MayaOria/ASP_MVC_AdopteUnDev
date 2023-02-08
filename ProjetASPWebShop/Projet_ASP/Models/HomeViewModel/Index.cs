using Projet_ASP.Models.CategoriesViewModels;
using Projet_ASP.Models.DeveloperViewModel;
using Projet_ASP.Models.ItLangViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Models.HomeViewModel
{
    public class Index
    {
        IEnumerable<DeveloperListItem> allDevelopers;
        IEnumerable<CategoriesListItem> allCategories;
        IEnumerable<ItLangListItem> allItLangs;

    }
}
