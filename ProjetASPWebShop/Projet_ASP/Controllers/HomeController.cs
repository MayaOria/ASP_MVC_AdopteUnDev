using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projet_ASP.Handlers;
using Projet_ASP.Models;
using Projet_ASP.Models.HomeViewModel;
using Projet_BLL.Entities;
using Projet_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeveloperRepository<Developer, int> _servicesDev;
        private readonly IItLangRepository<ItLang, int> _servicesitLang;
        private readonly ICategoriesRepository<Categories, int> _servicescategories;

        public HomeController(IDeveloperRepository<Developer, int> servicesDev, IItLangRepository<ItLang, int> servicesitLang, ICategoriesRepository<Categories, int> servicescategories)
        {
            _servicesDev = servicesDev;
            _servicesitLang = servicesitLang;
            _servicescategories = servicescategories;
        }

        public IActionResult Index()
        {
            IndexModel model = new IndexModel();
            model.Developers = _servicesDev.Get().Select(e => e.ToListItem());
            model.Categories = _servicescategories.Get().Select(e=>e.ToListItem());
            model.ItLangs = _servicesitLang.Get().Select(e => e.ToListItem());
            return View(model);
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
